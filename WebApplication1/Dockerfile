﻿FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
COPY ./bin/Debug/net9.0/publish /app
ENTRYPOINT ["dotnet", "WebApplication1.dll"]
