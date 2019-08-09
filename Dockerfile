#
# *************************************************
# Copyright (c) 2019, Grant D. Miller
# License MIT: https://opensource.org/licenses/MIT
# **************************************************
#

# Build stage
FROM mcr.microsoft.com/dotnet/core/sdk:2.2-alpine as build-env
RUN apk update
RUN apk upgrade
WORKDIR /src
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o /publish


# runtime stage
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-alpine
RUN apk update
RUN apk upgrade
WORKDIR /publish
COPY --from=build-env /publish .

ENTRYPOINT ["dotnet", "cli.dll"]
CMD ["fileToRead"]
