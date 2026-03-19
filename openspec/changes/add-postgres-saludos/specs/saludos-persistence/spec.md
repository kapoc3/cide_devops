## ADDED Requirements

### Requirement: Greeting Storage

The system SHALL persist each greeting request in PostgreSQL with name, timestamp, and IP address.

#### Scenario: Successful greeting storage
- **GIVEN** a user submits a greeting request via frontend
- **WHEN** the `/hello/{name}` endpoint is called
- **THEN** the system SHALL insert a record into the greetings table with the name, current timestamp, and client IP address

#### Scenario: Database connection failure
- **GIVEN** PostgreSQL is unavailable
- **WHEN** a greeting request is received
- **THEN** the system SHALL log the error and still return the greeting response (graceful degradation)

### Requirement: Database Schema

The system SHALL maintain a `greetings` table with the following columns:
- `id`: Auto-increment primary key
- `name`: VARCHAR(100) - the greeted name
- `ip_address`: VARCHAR(45) - client IP address
- `created_at`: TIMESTAMP - timestamp of the request

#### Scenario: Table creation
- **GIVEN** the application starts
- **WHEN** the database connection is established
- **THEN** the system SHALL create the `greetings` table if it doesn't exist

### Requirement: Database Configuration

The system SHALL use environment variables for database connection:
- `DB_HOST`: Database server host
- `DB_PORT`: Database server port (default: 5432)
- `DB_NAME`: Database name
- `DB_USER`: Database username
- `DB_PASSWORD`: Database password

#### Scenario: Development environment
- **GIVEN** the application is running locally
- **WHEN** connecting to the database
- **THEN** it SHALL use the default credentials for local PostgreSQL
