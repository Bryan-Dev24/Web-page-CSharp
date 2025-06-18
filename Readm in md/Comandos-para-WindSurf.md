# Comandos para WindSurf - Sistema de Biblioteca

## 1. Comandos Básicos

### 1.1 Criar Novo Controller
```
create controller [NomeDoController] with CRUD operations
```

### 1.2 Criar Novo Modelo
```
create model [NomeDoModelo] with properties
```

### 1.3 Executar Migrações
```
update-database
```

### 1.4 Iniciar Aplicação
```
dotnet run
```

## 2. Comandos de Desenvolvimento

### 2.1 Instalar Pacotes
```
dotnet add package [NomeDoPacote]
```

### 2.2 Adicionar Migração
```
add-migration [NomeDaMigracao]
```

### 2.3 Remover Migração
```
remove-migration
```

## 3. Comandos de Teste

### 3.1 Executar Testes
```
dotnet test
```

### 3.2 Executar Testes com Cobertura
```
dotnet test --collect:"XPlat Code Coverage"
```
