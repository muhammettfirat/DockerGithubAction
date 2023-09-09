#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["NuGet.Config", "."]
COPY ["host/Serender.Test.HttpApi.Host/Serender.Test.HttpApi.Host.csproj", "host/Serender.Test.HttpApi.Host/"]
COPY ["src/Serender.Test.HttpApi/Serender.Test.HttpApi.csproj", "src/Serender.Test.HttpApi/"]
COPY ["src/Serender.Test.Application.Contracts/Serender.Test.Application.Contracts.csproj", "src/Serender.Test.Application.Contracts/"]
COPY ["src/Serender.Test.Domain.Shared/Serender.Test.Domain.Shared.csproj", "src/Serender.Test.Domain.Shared/"]
COPY ["src/Serender.Test.Application/Serender.Test.Application.csproj", "src/Serender.Test.Application/"]
COPY ["src/Serender.Test.Domain/Serender.Test.Domain.csproj", "src/Serender.Test.Domain/"]
COPY ["src/Serender.Test.EntityFrameworkCore/Serender.Test.EntityFrameworkCore.csproj", "src/Serender.Test.EntityFrameworkCore/"]
RUN dotnet restore "host/Serender.Test.HttpApi.Host/Serender.Test.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/host/Serender.Test.HttpApi.Host"
RUN dotnet build "Serender.Test.HttpApi.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Serender.Test.HttpApi.Host.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Serender.Test.HttpApi.Host.dll"]