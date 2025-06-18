# Biblioteca em C#

Sistema de gerenciamento de biblioteca desenvolvido em C# com duas interfaces: Web (MVC) e Desktop (Windows Forms).

## Estrutura do Projeto

- `Biblioteca.Core`: Biblioteca de classes compartilhada
- `Biblioteca.Web`: Aplicação Web MVC
- `Biblioteca.Desktop`: Aplicação Desktop Windows Forms

## Pré-requisitos

- .NET 8.0
- Visual Studio 2022
- SQL Server (ou outro banco de dados compatível)
- Visual Studio 2022
- SQL Server (ou outro banco de dados compatível)

## Como Executar

1. Restaure as dependências:
   ```bash
   dotnet restore
   ```

2. Configure o banco de dados:
   - Crie uma string de conexão válida
   - Configure o arquivo appsettings.json

3. Compile a solução:
   ```bash
   dotnet build
   ```

4. Execute as migrations:
   ```bash
   dotnet ef database update
   ```

5. Execute o projeto Web:
   ```bash
   dotnet run --project Biblioteca.Web
   ```

6. Execute o projeto Desktop:
   ```bash
   dotnet run --project Biblioteca.Desktop
   ```
