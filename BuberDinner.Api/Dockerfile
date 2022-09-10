#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR .
COPY ["BuberDinner.Api/BuberDinner.Api.csproj", "BuberDinner.Api/"]
COPY ["BuberDinner.Application/BuberDinner.Application.csproj", "BuberDinner.Application/"]
COPY ["BuberDinner.Domain/BuberDinner.Domain.csproj", "BuberDinner.Domain/"]
COPY ["BuberDinner.Contracts/BuberDinner.Contracts.csproj", "BuberDinner.Contracts/"]
COPY ["BuberDinner.Infrastructure/BuberDinner.Infrastructure.csproj", "BuberDinner.Infrastructure/"]
RUN dotnet restore "BuberDinner.Api/BuberDinner.Api.csproj"
COPY . .
WORKDIR "/BuberDinner.Api"
RUN dotnet build "BuberDinner.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BuberDinner.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BuberDinner.Api.dll"]
