# Managment-System-Teachers

A desktop application built with **C# (Windows Forms)** and **SQL Server** for academic management.

The system provides role-based authentication and management of:
- courses,
- teachers,
- teacher-course enrollments.

## 🎯 Purpose
Help the program coordinator keep academic data up to date and allow teachers to view their information and assigned courses.

## 👥 Access profiles

### Program Coordinator
- Create, edit, delete, list, and search **courses**.
- Create, edit, delete, list, and search **teachers**.
- Create, edit, delete, list, and search **teacher-course enrollments**.
- Business rule: each teacher can be assigned up to **4 courses**.

### Teacher
- View teacher details.
- Search and list courses.
- Search and list teacher-course enrollments.

## 🧰 Tech stack
- **C#**
- **.NET Framework 4.7.2**
- **Windows Forms**
- **Entity Framework 6** (Database-First with EDMX)
- **SQL Server**

## 📂 Project structure
Sistema desktop em **C# (Windows Forms)** com **SQL Server** para gestão acadêmica.

O projeto permite autenticação por perfil e gerenciamento de:
- cursos,
- professores,
- matrículas (relação professor-curso).

## 🎯 Objetivo
Ajudar a coordenação a manter dados acadêmicos atualizados e permitir que professores consultem suas informações e cursos.

## 👥 Perfis de acesso

### Program Coordinator
- Cadastrar, editar, excluir, listar e buscar **cursos**.
- Cadastrar, editar, excluir, listar e buscar **professores**.
- Cadastrar, editar, excluir, listar e buscar **matrículas professor-curso**.
- Regra de negócio: um professor pode ter no máximo **4 cursos** atribuídos.

### Teacher
- Consultar dados de professor.
- Consultar e listar cursos.
- Consultar e listar matrículas professor-curso.

## 🧰 Tecnologias
- **C#**
- **.NET Framework 4.7.2**
- **Windows Forms**
- **Entity Framework 6 (Database-First com EDMX)**
- **SQL Server**

## 📂 Estrutura do projeto

```text
FinalProject_DanielScholtz/
├── FinalProject_Part2_DanielScholtz.sln
└── FinalProject_Part2_DanielScholtz/
    ├── GUI/                 # Login, coordinator, and teacher screens
    ├── DAO/                 # EDMX model and entities
    ├── App.config           # EF configuration and connection string
    └── Program.cs           # Application entry point
```

## ▶️ How to run

### Prerequisites
- Windows + Visual Studio (Desktop development with .NET).
- SQL Server installed and accessible.

### Steps
1. Open the solution:
   `FinalProject_DanielScholtz/FinalProject_Part2_DanielScholtz.sln`
2. Configure the connection string in:
   `FinalProject_DanielScholtz/FinalProject_Part2_DanielScholtz/App.config`
3. Make sure the `TeacherCourseDB` database exists with the schema expected by `Model1.edmx`.
4. Restore NuGet packages.
5. Build and run `FinalProject_Part2_DanielScholtz`.

## 🗄️ Database notes
This project uses Entity Framework Database-First. In the current repository state, the default connection points to:
    ├── GUI/                 # Telas de login, coordenador e professor
    ├── DAO/                 # Modelo EDMX e entidades
    ├── App.config           # Connection string e configurações do EF
    └── Program.cs           # Inicialização da aplicação
```

## ▶️ Como executar

### Pré-requisitos
- Windows + Visual Studio (Desktop development with .NET).
- SQL Server instalado e acessível.

### Passo a passo
1. Abra a solução:
   `FinalProject_DanielScholtz/FinalProject_Part2_DanielScholtz.sln`
2. Configure a connection string em:
   `FinalProject_DanielScholtz/FinalProject_Part2_DanielScholtz/App.config`
3. Garanta que o banco `TeacherCourseDB` exista com o schema esperado pelo `Model1.edmx`.
4. Restaure os pacotes NuGet.
5. Compile e execute o projeto `FinalProject_Part2_DanielScholtz`.

## 🗄️ Banco de dados
O projeto usa Entity Framework Database-First. No estado atual do repositório, a conexão está apontando para:
- `data source=DANIEL`
- `initial catalog=TeacherCourseDB`
- `integrated security=True`

If you are running on a different machine, update `data source` to your SQL Server instance.

## 🔐 Login flow
The login screen validates `UserID` and `Password` from the `Users` table.
- `JobTitle = Program Coordinator` → opens the full management screen.
- Any other role → opens the teacher query screen.

## 📌 Suggested improvements
- Add SQL scripts for database setup and seed data.
- Add input validations (numeric fields and email).
- Add automated tests for business rules.
- Improve error handling and UI messages.
Se estiver executando em outra máquina, ajuste o `data source` para sua instância do SQL Server.

## 🔐 Fluxo de login
A tela de login valida `UserID` e `Password` na tabela `Users`.
- `JobTitle = Program Coordinator` → abre a tela completa de gestão.
- Outros perfis → abre a tela de consultas do professor.

## 📌 Melhorias recomendadas
- Adicionar script SQL de criação/população inicial do banco.
- Incluir validações de entrada (números e e-mail).
- Adicionar testes automatizados para regras de negócio.
- Melhorar tratamento de erros e mensagens da interface.
