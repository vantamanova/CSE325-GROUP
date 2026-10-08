# Build the GameTracker application using .NET 10 SDK
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copy the application source code
COPY . .

# Publish the application for production
RUN dotnet publish CSE325-GROUP.csproj -c Release -o /app/publish

# Run the application using ASP.NET Core 10
FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app

# Copy the published application
COPY --from=build /app/publish .

# Configure ASP.NET Core for container hosting
ENV ASPNETCORE_URLS=http://0.0.0.0:10000
ENV ASPNETCORE_ENVIRONMENT=Production

EXPOSE 10000

# Start GameTracker
ENTRYPOINT ["dotnet", "CSE325-GROUP.dll"]