FROM mcr.microsoft.com/dotnet/sdk:6.0

WORKDIR /source

COPY . .

RUN dotnet build -c release -o out

ENTRYPOINT ["dotnet", "./out/api.dll", "--urls", "http://*:3000"]
