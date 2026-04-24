FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY NuGet.Config ./
COPY Innovation4Albania.DashboardBackend.slnx ./
COPY Innovation4Albania.DashboardBackend.Api/Innovation4Albania.DashboardBackend.Api.csproj Innovation4Albania.DashboardBackend.Api/
RUN dotnet restore Innovation4Albania.DashboardBackend.Api/Innovation4Albania.DashboardBackend.Api.csproj --configfile ./NuGet.Config

COPY Innovation4Albania.DashboardBackend.Api/ Innovation4Albania.DashboardBackend.Api/
RUN dotnet publish Innovation4Albania.DashboardBackend.Api/Innovation4Albania.DashboardBackend.Api.csproj -c Release -o /app/publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=build /app/publish ./
ENV ASPNETCORE_URLS=http://0.0.0.0:10000
EXPOSE 10000
ENTRYPOINT ["dotnet", "Innovation4Albania.DashboardBackend.Api.dll"]
