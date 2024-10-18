FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["HomeTaskScheduler.API/HomeTaskScheduler.API.csproj", "HomeTaskScheduler.API/"]
RUN dotnet restore "HomeTaskScheduler.API/HomeTaskScheduler.API.csproj"
COPY . .
WORKDIR "/src/HomeTaskScheduler.API"
RUN dotnet build "HomeTaskScheduler.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "HomeTaskScheduler.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HomeTaskScheduler.API.dll"]
