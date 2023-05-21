FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["DrivingQuizApp/Client/DrivingQuizApp.Client.csproj", "DrivingQuizApp/Client/"]
COPY ["DrivingQuizApp/Shared/DrivingQuizApp.Shared.csproj", "DrivingQuizApp/Shared/"]
RUN dotnet restore "DrivingQuizApp/Client/DrivingQuizApp.Client.csproj"
COPY . .
WORKDIR "/src/DrivingQuizApp/Client"
RUN dotnet build "DrivingQuizApp.Client.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DrivingQuizApp.Client.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DrivingQuizApp.Client.dll"]
