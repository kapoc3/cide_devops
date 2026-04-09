## ADDED Requirements

### Requirement: Traces Explorer Dashboard Available
Grafana SHALL provide a "Traces Explorer" dashboard accessible from the Grafana UI that displays distributed tracing data from Tempo.

#### Scenario: Dashboard loads successfully
- **WHEN** user navigates to Grafana dashboards section
- **THEN** "Traces Explorer" dashboard appears in the dashboards list
- **AND** dashboard loads without errors

### Requirement: Trace List Display
The Traces Explorer dashboard SHALL show a table of recent traces with service name, operation, duration, and status.

#### Scenario: Trace list shows recent traces
- **WHEN** dashboard is displayed
- **THEN** a table shows at least 20 most recent traces
- **AND** each row shows service, operation, duration, and status code

### Requirement: Latency Distribution Histogram
The Traces Explorer dashboard SHALL show a histogram of trace durations.

#### Scenario: Latency histogram visible
- **WHEN** dashboard is displayed
- **THEN** a histogram shows distribution of trace durations
- **AND** buckets are labeled in milliseconds

### Requirement: Error Trace Count
The Traces Explorer dashboard SHALL show the count of error traces (status code 500+) as a stat panel.

#### Scenario: Error count visible
- **WHEN** dashboard is displayed
- **THEN** a stat panel shows total error traces in selected time range
- **AND** updates when time range changes
