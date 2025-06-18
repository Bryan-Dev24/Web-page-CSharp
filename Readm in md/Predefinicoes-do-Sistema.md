## Predefinições do Sistema de Biblioteca

### 1. Versão do .NET
- .NET 8.0

### 2. Estrutura de Pastas
- `Biblioteca.Core/Models` - Modelos de dados
- `Biblioteca.Core/Nugets` - Pacotes NuGet
- `Biblioteca.Core/Database` - Configurações de banco de dados
- `Biblioteca.Core/Controllers` - Controladores
- `Biblioteca.Core/Interfaces` - Interfaces
- `Biblioteca.Core/Services` - Serviços de negócio
- `Biblioteca.Core/Repositories` - Repositórios de dados
- `Biblioteca.Core/DTOs` - Objetos de Transferência de Dados
- `Biblioteca.Core/Extensions` - Métodos de extensão
- `Biblioteca.Core/Helpers` - Classes auxiliares

### 3. Padrões de Projeto
- Repository Pattern
- Unit of Work
- Dependency Injection

### 4. Convenções de Código
- Nomes de classes em PascalCase
- Nomes de variáveis em camelCase
- Interfaces com prefixo "I" (ex: IRepository)
- Classes abstratas com sufixo "Base"
- Testes unitários com sufixo "Tests"

### 5. Configurações Recomendadas
- Usar C# 10.0 ou superior
- Habilitar Nullable Reference Types
- Usar File-scoped namespaces
- Configurar o editor para usar 4 espaços para indentação

### 6. Padrões de Commits
- feat: Nova funcionalidade
- fix: Correção de bug
- docs: Documentação
- style: Formatação
- refactor: Refatoração
- test: Testes
- chore: Tarefas de manutenção

Exemplo: `git commit -m "feat: Adiciona autenticação de usuário"`
