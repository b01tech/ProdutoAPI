FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish

FROM base AS final
WORKDIR /app
RUN mkdir -p /app/Data
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "ProdutosAPI.dll"]
CMD ["bash", "-c", "while true; do sleep 1000; done"]
