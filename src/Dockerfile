# Usando a imagem oficial do .NET 8
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# Criando diretório para a aplicação
WORKDIR /app

# Copiando os arquivos do projeto para dentro do container
COPY . .

# Publicando a aplicação
RUN dotnet publish -c Release -o out

# Definindo a porta padrão
EXPOSE 8080

# Definindo o comando de inicialização da API
CMD ["dotnet", "out/BudgetControl.dll"]
