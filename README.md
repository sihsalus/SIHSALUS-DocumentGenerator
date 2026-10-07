# SIHSALUS-DocumentGenerator

## Environment configuration

Copy `.env.example` to `.env` and provide the required secret and database values. The `.env` file is for local development only: it is ignored by Git, excluded from Docker build contexts, and never published with the application.

When running locally with `dotnet run`, the application reads `.env` from the project directory. Explicit environment variables take precedence over values in that file.

For a regular container, provide configuration when starting the container:

```powershell
docker build -t sihsalus-document-generator .
docker run --env-file .env -p 3000:3000 sihsalus-document-generator
```

For the Visual Studio **Container (Dockerfile)** debug profile, Visual Studio 2022 17.12 or later reads the local `.env` through `containerRunEnvironmentFiles`. Do not add secret values to `launchSettings.json`; it only contains safe debug defaults such as the port and `APP_MODE=DEV`.
