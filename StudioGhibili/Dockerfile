##see https://aka.ms/containerfastmode to understand how visual studio uses this dockerfile to build your images for faster debugging.
#
#from mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim as base
#workdir /app
#expose 80
#expose 443
#
#from mcr.microsoft.com/dotnet/core/sdk:3.1-buster as build
#workdir /src
#COPY ["StudioGhibili.csproj", "StudioGhibili/"]
#RUN dotnet restore "StudioGhibili/StudioGhibili.csproj"
#copy . .
#workdir "/src/studioghibili"
#RUN dotnet build "StudioGhibili/StudioGhibili.csproj" -c Release -o /app/build
#
#from build as publish
#RUN dotnet publish "StudioGhibili/StudioGhibili.csproj" -c Release -o /app/publish
#
#from base as final
#workdir /app
#copy --from=publish /app/publish .
#entrypoint ["dotnet", "studioghibili.dll"]
#cmd aspnetcore_urls=http://*:$port dotnet studioghibili.dll
######################
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
expose 80
expose 443
 
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
# I changed here and worked, fron this "StudioGhibili/StudioGhibili.csproj"
# to this "StudioGhibili.csproj"
COPY ["StudioGhibili.csproj", "StudioGhibili/"]
RUN dotnet restore "StudioGhibili/StudioGhibili.csproj"
WORKDIR "/src/StudioGhibili"
COPY . .
RUN dotnet build "StudioGhibili.csproj" -c Release -o /app/build
 
FROM build AS publish
RUN dotnet publish "StudioGhibili.csproj" -c Release -o /app/publish
 
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet StudioGhibili.dll