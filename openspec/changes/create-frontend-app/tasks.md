## 1. Project Setup

- [x] 1.1 Create Angular project using `ng new frontend --standalone --skip-git --port 5600`
- [x] 1.2 Configure environment files with API URL (http://localhost:5000 for development)
- [x] 1.3 Install Angular HttpClient module

## 2. Greeting Service Implementation

- [x] 2.1 Create greeting service using `inject(HttpClient)`
- [x] 2.2 Implement `getGreeting(name: string)` method returning an Observable
- [x] 2.3 Add error handling for HTTP failures

## 3. Greeting Component

- [x] 3.1 Generate standalone component `ng generate component greeting`
- [x] 3.2 Add input field for name with signal-based state
- [x] 3.3 Add submit button with loading state
- [x] 3.4 Display greeting response or error message
- [x] 3.5 Use OnPush change detection strategy

## 4. App Configuration

- [x] 4.1 Add HttpClient provider in app config
- [x] 4.2 Include greeting component in main app template
- [x] 4.3 Add basic styling for the greeting interface

## 5. CORS Configuration (Backend)

- [ ] 5.1 Update HelloWorldApi Program.cs to enable CORS
- [ ] 5.2 Allow frontend origin (http://localhost:5600)

## 6. Docker Configuration

- [x] 6.1 Create Dockerfile for Angular frontend (nginx-based production build)
- [x] 6.2 Create nginx.conf for serving Angular build
- [x] 6.3 Add frontend service to docker-compose.yml
- [x] 6.4 Configure environment variables for backend URL in Docker
