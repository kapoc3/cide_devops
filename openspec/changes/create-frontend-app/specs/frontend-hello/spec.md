## ADDED Requirements

### Requirement: Greeting Input Form

The system SHALL provide an input field where users can enter a name to request a personalized greeting.

#### Scenario: User enters a name
- **GIVEN** the user is on the greeting page
- **WHEN** user types a name in the input field
- **THEN** the name is stored in the component state

#### Scenario: User submits the form
- **GIVEN** the user has entered a name
- **WHEN** user clicks the submit button or presses Enter
- **THEN** the system SHALL call the backend API with the entered name
- **AND** display a loading indicator while waiting for the response

### Requirement: API Communication

The system SHALL communicate with the HelloWorldApi backend at the `/hello/{name}` endpoint.

#### Scenario: Successful API call
- **GIVEN** the user has submitted a valid name
- **WHEN** the API returns a successful response
- **THEN** the system SHALL display the greeting message from the response
- **AND** remove the loading indicator

#### Scenario: API error handling
- **GIVEN** the user has submitted a name
- **WHEN** the API returns an error or is unreachable
- **THEN** the system SHALL display an appropriate error message
- **AND** remove the loading indicator

### Requirement: Environment Configuration

The system SHALL use configurable API URLs based on environment settings.

#### Scenario: Development environment
- **GIVEN** the application is running in development mode
- **WHEN** the frontend loads
- **THEN** it SHALL use the local backend URL from environment configuration

#### Scenario: Production environment
- **GIVEN** the application is running in production mode
- **WHEN** the frontend loads
- **THEN** it SHALL use the production backend URL from environment configuration
