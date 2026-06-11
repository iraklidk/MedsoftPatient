# 🏥 MedsoftPatient

> A desktop patient registry for clinics — fast search, clean editing, one-click printing and Excel export. Built with VB.NET WinForms and DevExpress, backed by SQL Server.

![Platform](https://img.shields.io/badge/platform-Windows-0078D6?logo=windows&logoColor=white)
![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-512BD4?logo=dotnet&logoColor=white)
![Language](https://img.shields.io/badge/language-VB.NET-945DB7)
![UI](https://img.shields.io/badge/UI-DevExpress%2021.2-FF7200)
![Database](https://img.shields.io/badge/database-SQL%20Server-CC2927?logo=microsoftsqlserver&logoColor=white)

---

## ✨ Features

- **🔍 Powerful patient search** — filter by ID, full name, personal number, address, gender, and active status, all in one click
- **📋 Rich data grid** — DevExpress `XtraGrid` with grouping, multi-row selection, and auto-fit columns
- **➕ Add / ✏️ Edit patients** — modal form with gender and insurance lookups loaded straight from the database
- **🗑️ Bulk delete** — select multiple rows and delete them in a single round-trip using a table-valued parameter (`dbo.IDList`)
- **🖨️ Print-ready reports** — per-patient printout via DevExpress `XtraReports` with ribbon print preview
- **📊 Excel export** — export the current grid view to `.xlsx` and open it immediately
- **🇬🇪 Georgian-language UI** — all messages and labels localized for Georgian-speaking staff

## 🗂️ Project structure

```
MedsoftPatient/
├── MedsoftPatient.slnx                  # Solution file
└── MedsoftPatient/
    ├── DataConnection/
    │   └── Db.vb                        # SQL Server connection factory
    └── Patients/
        ├── Models/
        │   └── PatientsModel.vb         # Patient entity (POCO)
        ├── Handlers/
        │   └── PatientsHandler.vb       # Data access layer (stored-procedure calls)
        ├── Forms/
        │   ├── frmPatients.vb           # Main grid: search, delete, export, print
        │   └── frmPatientAddEdit.vb     # Add / edit patient dialog
        ├── Print/
        │   └── XtraPatientPrint.vb      # DevExpress report layout
        └── Dataset/
            └── dsPatientData.xsd        # Typed dataset for the print report
```

The app follows a simple layered design: **Forms → Handler → Stored Procedures**. All database work goes through `PatientsHandler`, which calls stored procedures only — no inline SQL.

## 🧱 Tech stack

| Layer | Technology |
|---|---|
| UI | Windows Forms + DevExpress 21.2 (XtraGrid, XtraEditors, XtraReports) |
| Language / Runtime | VB.NET on .NET Framework 4.8 |
| Data access | ADO.NET (`SqlDataAdapter`, `SqlCommand`) over stored procedures |
| Database | SQL Server (Express) — `MedsoftDB` |

## 🗄️ Database

The app expects a local SQL Server instance with a `MedsoftDB` database:

```
Server=localhost\SQLEXPRESS;Database=MedsoftDB;Trusted_Connection=True;
```

(Configured in `DataConnection/Db.vb`.)

Required stored procedures and types:

| Object | Purpose |
|---|---|
| `dbo.PatientListGet` | Filtered patient list (ID, status, name, personal number, address, gender) |
| `dbo.PatientGetById` | Load a single patient for editing |
| `dbo.PatientGetByIdPrint` | Load patient data shaped for the print report |
| `dbo.UpdatePatient` | Insert/update a patient (returns `@StatusCode` output param) |
| `dbo.PatientDelete` | Bulk delete by ID list |
| `dbo.GetGenderList` | Gender lookup |
| `dbo.GetInsuranceList` | Insurance provider lookup |
| `dbo.PatientStatusGet` | Patient status lookup |
| `dbo.IDList` (table type) | Table-valued parameter for bulk delete |

## 🚀 Getting started

### Prerequisites

- Windows with **.NET Framework 4.8**
- **Visual Studio 2022** (or newer)
- **DevExpress WinForms 21.2** components installed (licensed)
- **SQL Server Express** (or any SQL Server) with the `MedsoftDB` database and the stored procedures listed above

### Run it

1. Clone the repository:
   ```powershell
   git clone <repo-url>
   ```
2. Open `MedsoftPatient.slnx` in Visual Studio.
3. Make sure SQL Server is running and `MedsoftDB` exists (adjust the connection string in `DataConnection/Db.vb` if your instance name differs).
4. Press **F5** — the patient list opens, ready to search. 🎉
