#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/runtime:3.1
WORKDIR /app
COPY bin/publish /app

ARG ENVIRONMENT
ENV ASPNETCORE_ENVIRONMENT="Production" ASPNETCORE_URLS="http://*:80"
RUN apt update && apt -y install libgdiplus && cp /usr/share/zoneinfo/Asia/Shanghai /etc/localtime
#RUN ln -s /lib/x86_64-linux-gnu/libdl.so.2 /lib/x86_64-linux-gnu/libdl.so
#RUN dotnet restore

EXPOSE 80
ENTRYPOINT ["dotnet", "Vote.API.dll"]