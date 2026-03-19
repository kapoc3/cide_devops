## 1. Database Setup
1. 
- [x] 1.1 Create PostgreSQL service in docker-compose.yml
- [x] 1.2 Configure database credentials (host: postgres, port: 5432, db: saludos_db)
- [x] 1.3 Add volumes for data persistence

## 2. Backend Configuration

- [x] 2.1 Add EF Core Npgsql package to HelloWorldApi
- [x] 2.2 Create entity model for Greeting record
- [x] 2.3 Create DbContext with greetings table configuration
- [x] 2.4 Configure DI for DbContext

## 3. Database Schema

- [x] 3.1 Create initial migration with greetings table (Note: Used EnsureCreated for simplicity)
- [x] 3.2 Apply migrations automatically on startup
- [x] 3.3 Ensure table has: id, name, ip_address, created_at

## 4. API Integration

- [x] 4.1 Modify `/hello/{name}` endpoint to save greeting
- [x] 4.2 Extract client IP address from request
- [x] 4.3 Add try-catch for database errors
- [x] 4.4 Return greeting response regardless of persistence result

## 5. Testing

- [x] 5.1 Verify Docker services start correctly
- [x] 5.2 Test greeting request saves to database
- [x] 5.3 Test graceful degradation when DB is down
