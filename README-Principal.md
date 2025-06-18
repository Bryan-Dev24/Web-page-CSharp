# Biblioteca em C#

Sistema de gerenciamento de biblioteca desenvolvido em C# com duas interfaces: Web (MVC) e Desktop (Windows Forms).

## Estrutura do Projeto

- `Biblioteca.Core`: Biblioteca de classes compartilhada
- `Biblioteca.Web`: Aplicação Web MVC
- `Biblioteca.Desktop`: Aplicação Desktop Windows Forms

## Funcionalidades

- Cadastro de livros, autores e usuários
- Controle de empréstimos e devoluções
- Busca avançada de livros
- Geração de relatórios
- Múltiplas interfaces (Web e Desktop)

## Pré-requisitos

- .NET 8.0 SDK
- SQL Server 2019+ ou SQLite
- Visual Studio 2022 (recomendado) ou VS Code

## Como Executar

1. Clone o repositório:
   ```bash
   git clone [url-do-repositorio]
   cd "Biblioteca em C#"
   ```

2. Restaure os pacotes:
   ```bash
   dotnet restore
   ```

3. Execute as migrações do banco de dados:
   ```bash
   cd Biblioteca.Web
   dotnet ef database update
   ```

4. Inicie a aplicação Web:
   ```bash
   dotnet run
   ```
   
   Ou abra a solução no Visual Studio e pressione F5.

## Documentação

Consulte a pasta `Documentacao/` para:
- Manual do usuário
- Documentação da API
- Guia de instalação

## Contribuição

1. Faça um fork do projeto
2. Crie uma branch para sua feature (`git checkout -b feature/nova-feature`)
3. Faça commit das suas alterações (`git commit -m 'Adiciona nova feature'`)
4. Faça push para a branch (`git push origin feature/nova-feature`)
5. Abra um Pull Request

## Licença

Este projeto está licenciado sob a licença MIT.
