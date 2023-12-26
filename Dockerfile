FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
ARG configuration=Release
WORKDIR /App
EXPOSE 8080

ENV ASPNETCORE_URLS=http://+:8080

# Copy everything
COPY . .
# Restore as distinct layers
RUN dotnet restore -a amd64
# Build and publish a release
RUN dotnet publish -c $configuration -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App
COPY --from=build-env /App/out .
#COPY --chmod=755 ./wait-for-it.sh .
ENTRYPOINT ["dotnet", "WebApi.dll"]
