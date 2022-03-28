#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["dmf.Helpdesk.csproj", "."]
RUN dotnet restore "./dmf.Helpdesk.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "dmf.Helpdesk.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "dmf.Helpdesk.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "dmf.Helpdesk.dll"]