FROM mcr.microsoft.com/dotnet/core/runtime
WORKDIR /app
COPY . .

ARG ENVIRONMENT
ENV ASPNETCORE_ENVIRONMENT="Production" ASPNETCORE_URLS="http://*:80"
#RUN apt update && apt -y install libgdiplus && cp /usr/share/zoneinfo/Asia/Shanghai /etc/localtime
#RUN ln -s /lib/x86_64-linux-gnu/libdl.so.2 /lib/x86_64-linux-gnu/libdl.so
#RUN dotnet restore

EXPOSE 80
ENTRYPOINT ["dotnet", "Vote.API.dll"]
