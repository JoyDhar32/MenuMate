# Use the official ASP.NET Core runtime as a parent image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Use the SDK image for building the application
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["MenuMate/MenuMate.csproj", "MenuMate/"]
RUN dotnet restore "MenuMate/MenuMate.csproj"
COPY . .
WORKDIR "/src/MenuMate"
RUN dotnet build "MenuMate.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MenuMate.csproj" -c Release -o /app/publish

# Use the runtime image to run the application
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MenuMate.dll"]
