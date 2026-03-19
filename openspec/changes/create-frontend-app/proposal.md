## Why

We need a frontend application that allows users to interact with the HelloWorldApi backend. The frontend will provide a user-friendly interface to call the `/hello/{name}` endpoint and display the greetings, enabling non-technical users to consume the API.

## What Changes

- Create a new Angular standalone application
- Implement HTTP communication with the HelloWorldApi backend
- Build a simple UI to input a name and display the greeting response
- Configure environment-based API URL settings
- Add loading states and error handling for HTTP requests

## Capabilities

### New Capabilities
- `frontend-hello`: Frontend interface to call the `/hello/{name}` endpoint and display greetings

### Modified Capabilities
- None (new capability)

## Impact

- New `frontend/` directory with Angular application
- Integration with existing `HelloWorldApi` backend
- New `angular-component` and `angular-http` patterns applied
