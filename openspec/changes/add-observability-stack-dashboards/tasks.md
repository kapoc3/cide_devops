## 1. Setup Dashboard Provisioning

- [x] 1.1 Create directory structure `docker/observability/grafana/dashboards/`
- [x] 1.2 Create `dashboards.yml` provisioning config file
- [x] 1.3 Update docker-compose.yml to mount dashboards volume to Grafana

## 2. Create API Overview Dashboard

- [x] 2.1 Create `api-overview.json` dashboard file
- [x] 2.2 Add request rate panel (requests/sec time series)
- [x] 2.3 Add latency percentiles panel (p50, p95, p99)
- [x] 2.4 Add error rate panel (4xx/5xx split)
- [x] 2.5 Add active requests gauge panel

## 3. Create Service Health Dashboard

- [x] 3.1 Create `service-health.json` dashboard file
- [x] 3.2 Add CPU usage panel
- [x] 3.3 Add memory usage panel
- [x] 3.4 Add database connections panel
- [x] 3.5 Add service uptime stat panel

## 4. Create Traces Explorer Dashboard

- [x] 4.1 Create `traces-explorer.json` dashboard file
- [x] 4.2 Add trace list table panel
- [x] 4.3 Add latency distribution histogram
- [x] 4.4 Add error trace count stat panel

## 5. Create Logs Explorer Dashboard

- [x] 5.1 Create `logs-explorer.json` dashboard file
- [x] 5.2 Add log volume time series panel
- [x] 5.3 Add error log count stat panel
- [x] 5.4 Add Loki log search panel

## 6. Add Prometheus Recording Rules

- [x] 6.1 Create `docker/observability/prometheus/rules.yml`
- [x] 6.2 Add recording rules for common queries (if not present)
- [x] 6.3 Update prometheus config to load rules

## 7. Verify Implementation

- [x] 7.1 Run `docker-compose up` and verify services start
- [x] 7.2 Access Grafana and verify dashboards appear
- [x] 7.3 Verify each dashboard loads data correctly
