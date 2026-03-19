## Context

We need to persist greetings in PostgreSQL to create a history of all greeting requests made to the API. This is useful for analytics, auditing, and potentially showing recent greetings on the frontend.

**Database Details:**
- PostgreSQL 16.x
- Database name: `saludos_db`
- User: `saludos_user`
- Password: `saludos_pass`
- Port: 5432

## Goals / Non-Goals

**Goals:**
- Store greeting records with name, timestamp, and IP address
- Create Docker service for PostgreSQL
- Update backend to use Entity Framework Core with Npgsql
- Handle database connection errors gracefully

**Non-Goals:**
- Complex queries or analytics dashboard (out of scope)
- Data migration from existing greetings (none exist)
- Database backup/restore procedures

## Decisions

### Decision: PostgreSQL with Entity Framework Core
**Choice:** Use `Microsoft.EntityFrameworkCore.Npgsql` for database access
**Rationale:** Standard .NET ORM, provides migrations, LINQ queries, and integrates well with dependency injection.

### Decision: Docker Compose Integration
**Choice:** Add PostgreSQL service to existing docker-compose.yml
**Rationale:** Consistent with existing architecture, enables easy local development.

### Decision: Environment Configuration
**Choice:** Use environment variables for DB credentials
**Rationale:** Security best practice, supports different environments (dev/prod).

## Risks / Trade-offs

| Risk | Mitigation |
|------|------------|
| Database connection failures | Log errors, continue without persistence (graceful degradation) |
| Schema migration issues | Use EF Core migrations for safe schema updates |
| Performance impact | Minimal - single insert per greeting request |

## Open Questions

1. Should we expose an API endpoint to query greeting history?
2. Do we need to clean up old records automatically?
