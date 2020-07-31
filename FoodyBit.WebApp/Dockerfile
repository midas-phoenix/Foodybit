#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["FoodyBit.WebApp/FoodyBit.WebApp.csproj", "FoodyBit.WebApp/"]
COPY ["FoodyBit.Infrastructure/FoodyBit.Infrastructure.csproj", "FoodyBit.Infrastructure/"]
COPY ["Foodybit.Core/Foodybit.Core.csproj", "Foodybit.Core/"]
RUN dotnet restore "FoodyBit.WebApp/FoodyBit.WebApp.csproj"
COPY . .
WORKDIR "/src/FoodyBit.WebApp"
RUN dotnet build "FoodyBit.WebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FoodyBit.WebApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FoodyBit.WebApp.dll"]