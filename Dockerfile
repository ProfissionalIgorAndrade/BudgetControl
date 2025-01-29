# Etapa 1: Base image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Defina o diretório de trabalho dentro da imagem Docker
WORKDIR /app

# Copia o arquivo de solução
COPY BudgetControl.sln ./

# Copia o diretório src e seus arquivos para a imagem
COPY ./src/ ./src/

# Restaura as dependências
RUN dotnet restore

# Publica a aplicação
RUN dotnet publish -c Release -o out

# Etapa 2: Imagem de produção
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final

WORKDIR /app

# Copia os arquivos publicados da etapa anterior
COPY --from=build /app/out .

# Defina a porta padrão
EXPOSE 80

# Executa a aplicação
ENTRYPOINT ["dotnet", "BudgetControl.Api.dll"]
