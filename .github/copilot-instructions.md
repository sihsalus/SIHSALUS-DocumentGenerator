# Copilot Instructions

## Project Guidelines
- User prefers storing application secrets/configuration (DB credentials, tokens, encryption keys, mode/port) via a .env file instead of appsettings.json for this project.
- Ensure the Docker-exposed application port matches the APP_PORT value defined in .env (currently 3000), avoiding random mapped host ports in debug.

## Code Style
- Use cleaner constructor patterns with options/interface-like objects instead of long parameter lists for model classes.
- Use explicit type declarations (avoiding var) for objects used in Roslyn-loaded mapping files.
- Prefer strongly typed mapping files with full IDE completion/IntelliSense, even when files are executed by Roslyn at runtime.
- Avoid helper methods with arbitrary names in mapping declarations, as they reduce clarity when renderer logic is based on arrays/properties.