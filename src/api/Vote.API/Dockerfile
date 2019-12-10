#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/api/Vote.API/Vote.API.csproj", "src/api/Vote.API/"]
COPY ["src/model/Vote.Model/Vote.Model.csproj", "src/model/Vote.Model/"]
RUN dotnet restore "src/api/Vote.API/Vote.API.csproj"
COPY . .
WORKDIR "/src/api/Vote.API"
RUN dotnet build "Vote.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Vote.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Vote.API.dll"]