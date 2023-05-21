FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["DrivingQuizApp/Server/DrivingQuizApp.Server.csproj", "DrivingQuizApp/Server/"]
COPY ["DrivingQuizApp/Client/DrivingQuizApp.Client.csproj", "DrivingQuizApp/Client/"]
COPY ["DrivingQuizApp/Shared/DrivingQuizApp.Shared.csproj", "DrivingQuizApp/Shared/"]
RUN dotnet restore "DrivingQuizApp/Server/DrivingQuizApp.Server.csproj"
COPY . .
WORKDIR "/src/DrivingQuizApp/Server"
RUN dotnet build "DrivingQuizApp.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DrivingQuizApp.Server.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DrivingQuizApp.Server.dll"]
