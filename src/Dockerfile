# Etapa 1: Build da aplicação
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copia todos os arquivos do projeto para dentro do container
COPY . .

# Restaura as dependências
RUN dotnet restore

# Compila e publica a aplicação
RUN dotnet publish -c Release -o /out

# Etapa 2: Criar imagem final apenas com o runtime do .NET 8
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copia os arquivos publicados na etapa anterior
COPY --from=build /out .

# Expõe a porta 8080
EXPOSE 8080

# Comando para rodar a API
CMD ["dotnet", "BudgetControl.dll"]
