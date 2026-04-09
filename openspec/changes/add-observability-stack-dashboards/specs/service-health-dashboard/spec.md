## ADDED Requirements

### Requirement: Service Health Dashboard Available
Grafana SHALL provide a "Service Health" dashboard accessible from the Grafana UI that displays the health status of the HelloWorldApi backend and its dependencies.

#### Scenario: Dashboard loads successfully
- **WHEN** user navigates to Grafana dashboards section
- **THEN** "Service Health" dashboard appears in the dashboards list
- **AND** dashboard loads without errors

### Requirement: Container Resource Usage Display
The Service Health dashboard SHALL show CPU and memory usage for the backend container as time series graphs.

#### Scenario: Resource metrics visible
- **WHEN** dashboard is displayed
- **THEN** CPU usage graph shows percentage over time
- **AND** Memory usage graph shows usage in MB/GB

### Requirement: Database Connection Status
The Service Health dashboard SHALL show PostgreSQL connection pool status for the backend.

#### Scenario: DB connections visible
- **WHEN** dashboard is displayed
- **THEN** a panel shows active database connections
- **AND** shows connection pool usage percentage

### Requirement: Service Uptime Display
The Service Health dashboard SHALL show the service uptime as a stat panel.

#### Scenario: Uptime shows correctly
- **WHEN** dashboard is displayed
- **THEN** a stat panel shows days/hours since last restart
- **AND** updates on page refresh
