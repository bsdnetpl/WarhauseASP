FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
COPY /bin/Release/net7.0/publish .
ENTRYPOINT ["dotnet", "WarhauseASP.Server.dll"]
ENV ASPNETCORE_URLS=http://+:5000
