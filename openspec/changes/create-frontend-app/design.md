## Context

We need to create a standalone Angular application that communicates with the existing HelloWorldApi (.NET backend). The backend exposes a single endpoint `/hello/{name}` that returns a greeting message. The frontend will provide a simple UI for users to input a name and see the greeting response.

**Backend Details:**
- Endpoint: `GET /hello/{name}`
- Response: `"Hello {name}!"`
- Running at: `http://localhost:5000` (development)

## Goals / Non-Goals

**Goals:**
- Create an Angular standalone application with modern v20+ patterns
- Implement HTTP communication using Angular's `httpResource()` or `HttpClient`
- Display loading states and error handling
- Use environment-based configuration for API URLs
- Follow Angular best practices (signals, OnPush, standalone components)

**Non-Goals:**
- Authentication/authorization (out of scope)
- State management libraries (NgRx, etc.) - use signals instead
- Complex routing or lazy loading (single page app)
- Unit testing (out of scope)

## Decisions

### Decision: Angular Standalone Architecture
**Choice:** Use standalone components without NgModules
**Rationale:** Angular v20+ defaults to standalone components, reducing boilerplate and aligning with modern patterns.

### Decision: Signal-Based State
**Choice:** Use Angular Signals (`signal()`, `computed()`) for local state
**Rationale:** Signals are the recommended reactive primitive in Angular v20+, providing better performance with OnPush change detection.

### Decision: HTTP Approach
**Choice:** Use `httpResource()` for simple GET requests or `HttpClient` with signals
**Rationale:** `httpResource()` provides a clean way to handle loading/error states automatically. For more control, `HttpClient` with signal-based state is preferred.

### Decision: Environment Configuration
**Choice:** Use Angular `environment.ts` files for API configuration
**Rationale:** Standard Angular pattern that supports different configurations per environment.

## Risks / Trade-offs

| Risk | Mitigation |
|------|------------|
| CORS issues with backend | Configure CORS in HelloWorldApi to allow frontend origin |
| Backend URL changes | Use environment files to centralize configuration |
| Network failures | Add error handling and retry logic |

## Open Questions

1. Should the frontend run on a specific port/URL? → **Yes, port 5600**
2. Do we need Docker configuration for the frontend? → **Yes, Dockerfile + integrated in docker-compose.yml**
3. Should we add basic unit tests? → **No, unit tests are out of scope**

## Additional Decisions

### Decision: Frontend Port Configuration
**Choice:** Angular dev server runs on port 5600
**Rationale:** Avoid conflicts with other services (HelloWorldApi on 5000, landing page, etc.)

### Decision: Docker Integration
**Choice:** Create Dockerfile for frontend and integrate into existing docker-compose.yml
**Rationale:** Maintain consistency with existing services and enable containerized development
