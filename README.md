# CadastroClientes.Api

API REST desenvolvida em ASP.NET Core para aprendizado de criação de APIs com C# e SQL Server.

---

## Tecnologias utilizadas

- C#
- ASP.NET Core Web API (.NET 8)
- Entity Framework Core
- SQL Server Express
- SQL Server Management Studio (SSMS)
- Swagger / OpenAPI

---

## Estrutura do projeto

```text
CadastroClientes.Api
│
├── Controllers
├── Models
├── Data
├── Repositories
├── appsettings.json
└── Program.cs
```

---

## O que foi feito até agora

### 1. Configuração do ambiente

Instalação das ferramentas:

- Visual Studio Community
- .NET SDK 8
- SQL Server Express
- SQL Server Management Studio (SSMS)

---

### 2. Banco de dados

Criado banco:

```sql
CREATE DATABASE MinhaApiDb;
```

Criada tabela:

```sql
CREATE TABLE Clientes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nome NVARCHAR(100),
    Email NVARCHAR(100),
    Telefone NVARCHAR(20)
);
```

Inserido dado de teste:

```sql
INSERT INTO Clientes (Nome, Email, Telefone)
VALUES ('Raphaella', 'raphaella@email.com', '21999999999');
```

Consulta:

```sql
SELECT * FROM Clientes;
```

---

### 3. Estrutura inicial da API

Criadas pastas:

- Models
- Data
- Repositories

---

### 4. Model Cliente

Arquivo:

`Models/Cliente.cs`

Responsável por representar a entidade Cliente.

Campos:
- Id
- Nome
- Email
- Telefone

---

### 5. DbContext

Arquivo:

`Data/AppDbContext.cs`

Responsável pela conexão entre a API e o banco de dados usando Entity Framework.

---

### 6. Repository Pattern

Criados:

- `IClienteRepository.cs`
- `ClienteRepository.cs`

Objetivo:
- separar regra de acesso ao banco
- aplicar boas práticas

---

### 7. Configuração da conexão

Arquivo:

`appsettings.json`

Connection String:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=MinhaApiDb;Trusted_Connection=True;TrustServerCertificate=True"
}
```

---

### 8. Configuração do Program.cs

Adicionados:

- Entity Framework
- SQL Server
- Injeção de Dependência
- Swagger

---

## Próximos passos

- Criar `ClientesController`
- Criar endpoint GET `/api/clientes`
- Testar via Swagger
- Implementar POST
- Implementar PUT
- Implementar DELETE

---

## Autor

Raphaella Lopes
