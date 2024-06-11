#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base #take runtime asp.net Core
WORKDIR /app 
EXPOSE 80 #We get the ports from the internal network of the Docker containe

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build # Get the sdk from our shared repository
WORKDIR /src
COPY ["WebApi/WebApi.csproj", "WebApi/"]
RUN dotnet restore "WebApi/WebApi.csproj" #With the help of our SDK, we restore our project, all libraries
COPY . .
WORKDIR "/src/WebApi"
RUN dotnet build "WebApi.csproj" -c Release -o /app/build #Buld our project

FROM build AS publish
RUN dotnet publish "WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false #Publish our project

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApi.dll"] #Run through the entrypoint