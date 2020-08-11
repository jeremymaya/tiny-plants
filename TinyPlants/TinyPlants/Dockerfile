#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
#Source: https://adevtalks.com/programming/deployment/deploy-net-core-3-1-web-api-to-heroku/

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 5000
ENV ASPNETCORE_URLS=http://*:5000

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
# The below is commented and the line after is used when in heroku
# COPY TinyPlants/TinyPlants.csproj TinyPlants/
COPY ["TinyPlants.csproj", "./"]
# The below is commented and the line after is used when in heroku
# RUN dotnet restore "TinyPlants/TinyPlants.csproj"
RUN dotnet restore "./TinyPlants.csproj"
COPY . .
# The below is commented and the line after is used when in heroku
# WORKDIR "/src/TinyPlants"
WORKDIR "/src/."
RUN dotnet build "TinyPlants.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TinyPlants.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
# The below is commented and the line after is used when in heroku
# ENTRYPOINT ["dotnet", "TinyPlants.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet TinyPlants.dll
