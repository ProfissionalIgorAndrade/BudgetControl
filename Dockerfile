# Etapa 1: Build da aplicação (compilar todas as class libs)
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia o arquivo de solução e restaura dependências
COPY BudgetControl.sln ./
COPY src/ ./src/
RUN dotnet restore

# Compila e publica a aplicação
RUN dotnet publish src/BudgetControl.Api/BudgetControl.Api.csproj -c Release -o /app/publish

# Etapa 2: Criar imagem final para execução
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copia os arquivos publicados
COPY --from=build /app/publish .

# Expõe a porta 8080
EXPOSE 8080

# Comando para rodar a API
CMD ["dotnet", "BudgetControl.Api.dll"]
