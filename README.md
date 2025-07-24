# PoC3Con - Backend

Este é o backend do projeto **PoC3Con**, desenvolvido em .NET com foco em arquitetura limpa, DDD (Domain-Driven Design) e uso do padrão Command/Handler. A aplicação foi construída pensando em escalabilidade, separação de responsabilidades e testes.

---

## Como configurar e executar o backend

### Pré-requisitos

- [.NET SDK 8.0+](https://dotnet.microsoft.com/en-us/download)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) 
- [Visual Studio 2022+](https://visualstudio.microsoft.com/pt-br/) 
- Git

### Decisões de design e arquitetura
- Clean Architecture: Separação clara entre camadas: API, Application, Domain e Infrastructure.

- DDD (Domain-Driven Design): Organização centrada em entidades e casos de uso.

- Repository Pattern: Abstração da camada de persistência com interfaces no domínio.

- Command/Handler Pattern: Implementação dos casos de uso via comandos e manipuladores.

### 🧱 Camadas da aplicação

#### 1. Domain
Responsável pelas regras de negócio puras.

**Contém:**
- Entidades (ex: `Cliente`, `Pedido`)
- Interfaces (ex: `IClienteRepository`)
- Abstrações
- Validators (ex: `CpfValidator`)

#### 2. Application
Responsável pelos casos de uso da aplicação.

**Contém:**
- Commands, Handlers e Responses
- DTOs

#### 3. Infrastructure
Responsável pelas implementações concretas de repositórios e serviços externos.

**Contém:**
- Repositórios concretos (ex: `ClienteRepository`)
- `AppDbContext`

#### 4. API
Exposição dos endpoints usando **Minimal APIs** e documentação SWAGGER.

**Contém:**
- `Program.cs`
- Pasta `Routes/` (endpoints agrupados)
- `Migrations/`
- `appsettings.json`
   
### 📦 Clonar o repositório

```bash

git clone https://github.com/VictorCMoro/PoC3ConBack.git

