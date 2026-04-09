## ADDED Requirements

### Requirement: API Observability Dashboard Available
Grafana SHALL provide an "API Overview" dashboard accessible from the Grafana UI that displays real-time metrics from the HelloWorldApi backend.

#### Scenario: Dashboard loads successfully
- **WHEN** user navigates to Grafana dashboards section
- **THEN** "API Overview" dashboard appears in the dashboards list
- **AND** dashboard loads without errors

### Requirement: Request Rate Display
The API Overview dashboard SHALL show the request rate (requests per second) as a time series graph.

#### Scenario: Request rate shows current traffic
- **WHEN** dashboard is displayed
- **THEN** a graph shows requests/sec over time
- **AND** data is sourced from Prometheus metrics

### Requirement: Latency Metrics Display
The API Overview dashboard SHALL show latency percentiles (p50, p95, p99) as time series graphs.

#### Scenario: Latency percentiles visible
- **WHEN** dashboard is displayed
- **THEN** three graphs show p50, p95, and p99 latency
- **AND** values are displayed in milliseconds

### Requirement: Error Rate Display
The API Overview dashboard SHALL show the error rate (HTTP 4xx/5xx responses) as a time series graph.

#### Scenario: Error rate shows failures
- **WHEN** dashboard is displayed
- **THEN** a graph shows error count per second
- **AND** distinguishes between client errors (4xx) and server errors (5xx)

### Requirement: Active Requests Display
The API Overview dashboard SHALL show the number of currently active requests as a gauge metric.

#### Scenario: Active requests gauge visible
- **WHEN** dashboard is displayed
- **THEN** a gauge shows current active request count
- **AND** gauge updates in near real-time
