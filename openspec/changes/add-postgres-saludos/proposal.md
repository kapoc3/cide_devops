## Why

We need to persist greetings received by the frontend in a PostgreSQL database for historical tracking, analytics, and audit purposes. This will allow us to query greeting history and analyze usage patterns.

## What Changes

- Add PostgreSQL database service to docker-compose
- Create database schema for storing greetings (name, date, IP address)
- Update HelloWorldApi to connect to PostgreSQL and save greetings
- Modify `/hello/{name}` endpoint to persist each greeting request

## Capabilities

### New Capabilities
- `saludos-persistence`: Database storage and query for greeting history

### Modified Capabilities
- `frontend-hello`: Updated to track usage (implicit)

## Impact

- New PostgreSQL service in docker-compose
- HelloWorldApi needs `Microsoft.EntityFrameworkCore.Npgsql` package
- New environment variables for database connection
- Database migration scripts needed
