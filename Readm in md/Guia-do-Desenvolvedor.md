# Guia do Desenvolvedor - Biblioteca em C#

## Estrutura de Pastas

```
Biblioteca em C#
├── Biblioteca.Core/          # Biblioteca compartilhada
│   ├── Models/              # Modelos de dados
│   ├── Services/            # Serviços compartilhados
│   └── Interfaces/          # Interfaces compartilhadas
├── Biblioteca.Web/          # Aplicação Web
│   ├── Controllers/         # Controladores MVC
│   ├── Views/               # Views Razor
│   └── wwwroot/             # Arquivos estáticos
└── Biblioteca.Desktop/      # Aplicação Desktop
    ├── Forms/               # Formulários
    └── Controls/            # Controles personalizados
```

## Configuração do Ambiente

1. **Pré-requisitos**
   - .NET 8.0 SDK
   - Visual Studio 2022 ou VS Code
   - SQL Server 2019+ ou SQLite

2. **Configuração Inicial**
   ```bash
   # Clonar o repositório
   git clone [url-do-repositorio]
   cd "Biblioteca em C#"
   
   # Restaurar pacotes
   dotnet restore
   
   # Executar migrações
   cd Biblioteca.Web
   dotnet ef database update
   ```

## Padrões de Desenvolvimento

### Convenções de Código
- Usar nomes descritivos em inglês
- Comentar código complexo
- Seguir as diretrizes de estilo do C#

### Branching Strategy
- `main`: Código de produção
- `develop`: Próxima versão em desenvolvimento
- `feature/`: Novas funcionalidades
- `bugfix/`: Correções de bugs
- `hotfix/`: Correções críticas em produção

## Testes

### Executando Testes
```bash
dotnet test
```

### Cobertura de Testes
```bash
# Gerar relatório de cobertura
dotnet test --collect:"XPlat Code Coverage"
```

## Deploy

### Web
- Publicar para Azure App Service
- Configurar variáveis de ambiente
- Configurar banco de dados

### Desktop
- Criar instalador MSI
- Assinar o aplicativo
- Publicar no portal de downloads

## Dependências

### Principais Pacotes
- Entity Framework Core
- AutoMapper
- FluentValidation
- xUnit (testes)

## Licença

Este projeto está licenciado sob a licença MIT.
