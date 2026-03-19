using OpenTelemetry.Metrics;
using OpenTelemetry.Trace;
using OpenTelemetry.Resources;
using OpenTelemetry.Logs;
using Scalar.AspNetCore;
using Microsoft.EntityFrameworkCore;
using HelloWorldApi.Data;

var builder = WebApplication.CreateBuilder(args);

const string serviceName = "HelloWorldApi";

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddDbContext<GreetingDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddOpenApi();

builder.Logging.AddOpenTelemetry(logging =>
{
    logging.IncludeFormattedMessage = true;
    logging.IncludeScopes = true;
    logging.AddOtlpExporter(opts =>
    {
        opts.Endpoint = new Uri(builder.Configuration["Otlp:Endpoint"] ?? "http://otel-collector:4317");
    });
});

builder.Services.AddOpenTelemetry()
    .ConfigureResource(resource => resource.AddService(serviceName))
    .WithTracing(tracing => tracing
        .AddAspNetCoreInstrumentation()
        .AddHttpClientInstrumentation()
        .AddOtlpExporter(opts =>
        {
            opts.Endpoint = new Uri(builder.Configuration["Otlp:Endpoint"] ?? "http://otel-collector:4317");
        }))
    .WithMetrics(metrics => metrics
        .AddAspNetCoreInstrumentation()
        .AddHttpClientInstrumentation()
        .AddOtlpExporter(opts =>
        {
            opts.Endpoint = new Uri(builder.Configuration["Otlp:Endpoint"] ?? "http://otel-collector:4317");
        }));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<GreetingDbContext>();
    db.Database.EnsureCreated();
}

app.UseCors();

app.MapOpenApi();
app.MapScalarApiReference();

app.MapGet("/hello/{name}", async (string name, HttpContext context, GreetingDbContext db, ILogger<Program> logger) =>
{
    var greeting = $"Hello {name}!";
    var ipAddress = context.Connection.RemoteIpAddress?.ToString() ?? "unknown";

    try
    {
        var record = new GreetingRecord
        {
            Name = name,
            IpAddress = ipAddress,
            CreatedAt = DateTime.UtcNow
        };
        db.Greetings.Add(record);
        await db.SaveChangesAsync();
        logger.LogInformation("Persisted greeting for {Name} from {IpAddress}", name, ipAddress);
    }
    catch (Exception ex)
    {
        logger.LogError(ex, "Error persisting greeting to database");
    }

    return greeting;
});

app.Run();
