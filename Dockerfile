FROM selenium/standalone-chrome:latest
COPY ["AutomatedFlow.csproj", "."]
RUN dotnet restore "./AutomatedFlow.csproj"
COPY . .
WORKDIR /app
RUN dotnet build "AutomatedFlow.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AutomatedFlow.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AutomatedFlow.dll"]

CMD ["dotnet", "test", "--configuration", "Release"]

# Alternatively, if you want to run your application and tests separately:
# CMD ["dotnet", "run"]

# Note: Adjust the CMD command based on how you run your tests in your project