#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["DigitalDepot.Api/DigitalDepot.Api.csproj", "DigitalDepot.Api/"]
RUN dotnet restore "DigitalDepot.Api/DigitalDepot.Api.csproj"
COPY . .
WORKDIR "/src/DigitalDepot.Api"
RUN dotnet build "DigitalDepot.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DigitalDepot.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DigitalDepot.Api.dll"]