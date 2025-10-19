FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY TextServer/Api/Api.csproj ./Api/
COPY TextServer/Logic/Logic.csproj ./Logic/
COPY TextServer/Dal/Dal.csproj ./Dal/

RUN dotnet restore ./Api/Api.csproj

COPY TextServer/ ./TextServer/

WORKDIR /src/TextServer/Api
RUN dotnet publish "Api.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
EXPOSE 5082

ENV ASPNETCORE_ENVIRONMENT=Production
ENV ASPNETCORE_URLS=http://+:5082

COPY --from=build /app/publish ./

ENTRYPOINT ["dotnet", "Api.dll"]
