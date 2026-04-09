## Why

Currently our observability stack (Grafana, Tempo, Prometheus, Loki, OTEL Collector) is deployed and running, but lacks custom dashboards for monitoring the backend application's health, performance, and logs. Without these dashboards, it's difficult to quickly diagnose issues, track API performance, and monitor system metrics.

## What Changes

- Create custom Grafana dashboards for the HelloWorldApi backend
- Dashboard 1: **API Overview** - Request rates, response times, error rates
- Dashboard 2: **Service Health** - Uptime, dependencies, resource usage
- Dashboard 3: **Traces Overview** - Trace sampling, latency distribution
- Dashboard 4: **Logs Analysis** - Log volume, error patterns, query builder
- Configure datasource provisioning for dashboards
- Add recording rules for common metric patterns

## Capabilities

### New Capabilities
- `api-observability-dashboard`: Custom Grafana dashboard showing API metrics (requests/sec, latency percentiles, error rates)
- `service-health-dashboard`: Service health monitoring with dependency status and resource metrics
- `traces-explorer-dashboard`: Distributed tracing overview with service map and latency histograms
- `logs-explorer-dashboard`: Log aggregation and analysis with Loki integration

### Modified Capabilities
- None. All dashboards are net new.

## Impact

- **New files**:
  - `docker/observability/grafana/provisioning/dashboards/dashboards.yml`
  - `docker/observability/grafana/dashboards/api-overview.json`
  - `docker/observability/grafana/dashboards/service-health.json`
  - `docker/observability/grafana/dashboards/traces-explorer.json`
  - `docker/observability/grafana/dashboards/logs-explorer.json`
  - `docker/observability/prometheus/rules.yml`
- **Modified files**: None (dashboard provisioning directory will be created)
- **Dependencies**: Requires existing Grafana, Prometheus, Loki, Tempo, OTEL Collector services
