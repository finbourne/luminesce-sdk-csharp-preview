FROM mcr.microsoft.com/dotnet/core/sdk:3.1

RUN mkdir -p /usr/src
WORKDIR /usr/src

COPY Finbourne.Luminesce.Sdk.sln /usr/src/
COPY Finbourne.Luminesce.Sdk/Finbourne.Luminesce.Sdk.csproj /usr/src/Finbourne.Luminesce.Sdk/
RUN dotnet restore Finbourne.Luminesce.Sdk

ENTRYPOINT dotnet build --configuration Release --verbosity normal Finbourne.Luminesce.Sdk