## Context

The observability stack is already deployed via docker-compose with Grafana, Prometheus, Loki, Tempo, and OTEL Collector. The backend API (HelloWorldApi) is already configured to send telemetry data to the OTEL Collector. However, there are no custom dashboards to visualize this data.

## Goals / Non-Goals

**Goals:**
- Create 4 custom Grafana dashboards for backend observability
- Configure Prometheus recording rules for common queries
- Set up dashboard provisioning to persist dashboard definitions
- Dashboards should work out-of-the-box without manual configuration

**Non-Goals:**
- Modify the existing docker-compose.yml (observability stack already exists)
- Add new metrics to the application (use existing OTEL instrumentation)
- Create alerts/alerting rules (out of scope for this change)
- Implement custom OTEL exporters (already configured)

## Decisions

1. **Dashboard Storage**: Store dashboards as JSON files in `docker/observability/grafana/dashboards/` and use Grafana's provisioning feature rather than storing dashboard state in database.

2. **Data Sources**: Use existing datasources (Prometheus, Loki, Tempo) already provisioned via `datasources.yaml`.

3. **Metrics Source**: Use histogram_quantile for latency calculations from OTEL metrics. Fall back to raw counters for rates.

4. **Dashboard Panels**:
   - API Overview: Request rate (counter), Latency p50/p95/p99 (histogram), Error rate (counter), Active requests (gauge)
   - Service Health: Container CPU/Memory (from Prometheus node_exporter or cAdvisor), Database connections, Uptime
   - Traces Explorer: Service map (from Tempo), Latency distribution histogram, Trace list
   - Logs Explorer: Log volume over time, Error log count, Loki log search

## Risks / Trade-offs

- **Risk**: Dashboard queries may need adjustment based on actual metric names from OTEL → **Mitigation**: Start with generic OTEL metric names, allow for easy query updates
- **Risk**: Resource metrics (CPU/Memory) require node_exporter or cAdvisor → **Mitigation**: Add node_exporter to docker-compose if not present, or use container metrics from Docker
- **Risk**: Tempo service map requires specific traces setup → **Mitigation**: Use basic trace list as fallback

## Migration Plan

1. Create dashboard provisioning directory structure
2. Add dashboard definitions (JSON files)
3. Add Prometheus recording rules
4. Update docker-compose to mount dashboard directory (if needed)
5. Verify dashboards load in Grafana

No rollback needed - dashboards are additive.
