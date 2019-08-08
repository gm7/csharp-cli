# Build stage
FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch as build-env
WORKDIR /src
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o /publish


# runtime stage
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim
WORKDIR /publish
COPY --from=build-env /publish .

ENTRYPOINT ["dotnet", "cli.dll"]
CMD ["fileToRead"]
