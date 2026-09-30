# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.



# This image includes the Chromium binary and Linux dependencies required by
# Microsoft.Playwright 1.63.0, which is used by RenderService.
FROM mcr.microsoft.com/playwright/dotnet:v1.63.0-noble AS base
# Keep Chromium sandboxed while rendering untrusted HTML.
USER pwuser
WORKDIR /app
ENV ASPNETCORE_HTTP_PORTS=3000
ENV APP_PORT=3000
ENV APP_MODE=DEV
EXPOSE 3000

# GitHub Package integration
LABEL org.opencontainers.image.source=https://github.com/sihsalus/SIHSALUS-DocumentGenerator


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["SIHSALUS-DocumentGenerator.csproj", "."]
RUN dotnet restore "./SIHSALUS-DocumentGenerator.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "./SIHSALUS-DocumentGenerator.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./SIHSALUS-DocumentGenerator.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
USER root
WORKDIR /app
COPY --from=publish /app/publish .
RUN chown -R pwuser:pwuser /app \
    && chmod +x /app/.playwright/node/linux-x64/node
USER pwuser
ENTRYPOINT ["dotnet", "SIHSALUS-DocumentGenerator.dll"]
