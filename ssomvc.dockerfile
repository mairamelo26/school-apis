FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /SingleSignon
COPY ["SingleSignon/Frontend/SingleSignonPage/SingleSignonPage.csproj", "Frontend/SingleSignonPage/"]
RUN dotnet restore "Frontend/SingleSignonPage/SingleSignonPage.csproj"
COPY SingleSignon/ .
WORKDIR "/SingleSignon/Frontend/SingleSignonPage"
RUN dotnet build "SingleSignonPage.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SingleSignonPage.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SingleSignonPage.dll"]