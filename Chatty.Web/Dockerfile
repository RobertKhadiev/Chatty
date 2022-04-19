FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Chatty.Web/Chatty.Web.csproj", "Chatty.Web/"]
RUN dotnet restore "Chatty.Web/Chatty.Web.csproj"
COPY . .
WORKDIR "/src/Chatty.Web"
RUN dotnet build "Chatty.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Chatty.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Chatty.Web.dll"]
