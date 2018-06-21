FROM microsoft/aspnetcore:2.0-nanoserver-sac2016 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-nanoserver-sac2016 AS build
WORKDIR /src
COPY BackendMantenimiento/BackendMantenimiento.csproj BackendMantenimiento/
RUN dotnet restore BackendMantenimiento/BackendMantenimiento.csproj
COPY . .
WORKDIR /src/BackendMantenimiento
RUN dotnet build BackendMantenimiento.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish BackendMantenimiento.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "BackendMantenimiento.dll"]
