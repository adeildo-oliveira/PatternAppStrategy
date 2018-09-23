FROM microsoft/dotnet:2.1-sdk as build  
WORKDIR /PatternAppStrategy
COPY PatternAppStrategy . 

RUN dotnet restore
RUN dotnet publish "PatternAppStrategy.csproj" -c Release -o /app

FROM microsoft/dotnet:2.1-runtime as deployment
WORKDIR /app 
COPY --from=build /app .
ENTRYPOINT [ "dotnet", "PatternAppStrategy.dll" ]