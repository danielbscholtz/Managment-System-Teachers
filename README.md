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
