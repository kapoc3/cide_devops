## ADDED Requirements

### Requirement: Logs Explorer Dashboard Available
Grafana SHALL provide a "Logs Explorer" dashboard accessible from the Grafana UI that displays log data from Loki.

#### Scenario: Dashboard loads successfully
- **WHEN** user navigates to Grafana dashboards section
- **THEN** "Logs Explorer" dashboard appears in the dashboards list
- **AND** dashboard loads without errors

### Requirement: Log Volume Time Series
The Logs Explorer dashboard SHALL show log volume over time as a time series graph.

#### Scenario: Log volume displayed
- **WHEN** dashboard is displayed
- **THEN** a graph shows log entries per minute over time
- **AND** differentiates by log level via color coding

### Requirement: Error Log Count
The Logs Explorer dashboard SHALL show the count of error-level logs as a stat panel.

#### Scenario: Error count visible
- **WHEN** dashboard is displayed
- **AND** a stat panel shows total error logs in selected time range
- **AND** updates when time range changes

### Requirement: Log Search/Filter Panel
The Logs Explorer dashboard SHALL include a Loki log search panel that allows filtering logs by query.

#### Scenario: Log search works
- **WHEN** dashboard is displayed
- **THEN** a log panel shows entries with labels
- **AND** supports Loki query filtering (e.g., `{app="helloworldapi"}`)
