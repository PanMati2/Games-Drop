FROM  mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY GamesDrop/*.csproj ./GamesDrop/
RUN dotnet restore GamesDrop/

# Copy everything else and build
COPY GamesDrop/. ./GamesDrop/.
RUN dotnet publish GamesDrop/*.csproj -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "GamesDrop.dll"]