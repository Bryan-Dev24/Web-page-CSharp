# Guia do Desenvolvedor - Biblioteca em C#

## Estrutura de Pastas

```
Biblioteca em C#
├── Biblioteca.Core/          # Biblioteca compartilhada
│   ├── Models/              # Modelos de dados
│   ├── Services/            # Serviços compartilhados
│   └── Interfaces/          # Interfaces compartilhadas
├── Biblioteca.Web/          # Aplicação Web MVC
│   ├── Controllers/        # Controladores
│   ├── Models/            # Modelos específicos da Web
│   ├── Views/             # Páginas Razor
│   ├── wwwroot/           # Arquivos estáticos
│   └── Controllers/       # Controladores
└── Biblioteca.Desktop/     # Aplicação Desktop
    ├── Forms/             # Formulários Windows Forms
    ├── Models/            # Modelos específicos do Desktop
    └── Services/          # Serviços específicos do Desktop
```

## Referências de Projeto

- `Biblioteca.Core` é referenciado por ambos `Biblioteca.Web` e `Biblioteca.Desktop`
- `Biblioteca.Web` e `Biblioteca.Desktop` são projetos independentes

## Padrões de Desenvolvimento

1. **Nomenclatura**
   - Classes: PascalCase
   - Métodos: PascalCase
   - Variáveis: camelCase
   - Arquivos: PascalCase

2. **Organização de Código**
   - Separação clara de responsabilidades
   - Código compartilhado na `Biblioteca.Core`
   - Código específico em cada projeto

3. **Gerenciamento de Dependências**
   - Use o NuGet Package Manager
   - Mantenha as dependências atualizadas
   - Documente dependências externas

## Dependências Principais

- Entity Framework Core
- ASP.NET Core MVC
- Windows Forms
- Bootstrap (para Web)
- FontAwesome (para ícones)

## Boas Práticas

1. **Testes**
   - Implemente testes unitários
   - Use mocks para testes de integração
   - Mantenha cobertura mínima de 70%

2. **Documentação**
   - Documente classes e métodos públicos
   - Mantenha README atualizado
   - Use XML comments

3. **Segurança**
   - Valide todas as entradas
   - Implemente autenticação
   - Use HTTPS para Web
   - Proteja dados sensíveis

4. **Performance**
   - Use lazy loading quando apropriado
   - Implemente caching
   - Otimizar consultas ao banco
