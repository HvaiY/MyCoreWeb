FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY Web.Host/Web.Host.csproj Web.Host/
RUN dotnet restore Web.Host/Web.Host.csproj
COPY . .
WORKDIR /src/Web.Host
RUN dotnet build Web.Host.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Web.Host.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Web.Host.dll"]
