# Consultorio Médico (Medical Clinic Management System)

## What it does
**Consultorio Médico** is a comprehensive Windows Desktop application designed to streamline the daily operations of a medical clinic. It provides an intuitive graphical user interface for medical and administrative staff to manage the complete patient lifecycle, from booking an appointment to issuing a prescription and generating a final invoice. 

Core functionalities include:
*   **Catalog Management:** Maintain detailed records for Pacientes (Patients), Médicos (Doctors), and Clientes (Billing Clients).
*   **Appointment Scheduling (Citas):** Schedule, track, and manage patient appointments with specific doctors.
*   **Medical Records (Expedientes):** Record vital signs (weight, height, temperature, blood pressure), symptoms, diagnoses, medical studies, and treatments during consultations.
*   **Prescriptions (Recetas):** Generate and manage medical prescriptions with specific dosages and instructions linked to patient medical records.
*   **Billing & Invoicing (Cobros y Facturas):** Process appointment payments (cash, card, transfer) and generate official invoices for registered clients.
*   **Reporting & Queries:** Access individual and general reports for medical prescriptions, processed payments, and generated invoices.

## Tech stack
*   **Language:** C#
*   **Framework:** .NET (Windows Forms / WinForms)
*   **Database:** Microsoft SQL Server (LocalDB)
*   **Data Access:** ADO.NET (`System.Data.SqlClient`)
*   **Architecture:** Monolithic Desktop Client

## How To Install/Run

### Prerequisites
1.  **Visual Studio** (2022 recommended) with the **.NET Desktop Development** workload installed.
2.  **SQL Server Express LocalDB** installed (usually included with Visual Studio data workloads).
3.  **SQL Server Management Studio (SSMS)** or Azure Data Studio (optional, but helpful for database setup).

### Installation Steps
1.  **Clone the repository:**
    ```bash
    git clone https://github.com/yourusername/consultorio-medico.git
    ```
2.  **Set up the Database:**
    *   Connect to `(LocalDb)\MSSQLLocalDB` using SSMS or Visual Studio's SQL Server Object Explorer.
    *   Create a new database named `Sistema`.
    *   Execute the necessary SQL scripts (schema and tables) to create the required tables: `Pacientes`, `Medicos`, `Clientes`, `Citas`, `Expedientes`, `Recetas`, `DetReceta`, `Cobros`, and `Facturas`. *(Note: Ensure the schema matches the exact column names referenced in the ADO.NET queries).*
3.  **Open the Solution:**
    *   Navigate to the cloned folder and open `ConsultorioMedico.sln` in Visual Studio.
4.  **Build and Run:**
    *   Restore NuGet packages if prompted.
    *   Press `F5` or click **Start** to compile and run the application.

## Deployment target (Vercel, Docker, AWS, etc.)
*   **Target:** Windows Desktop Client
*   **Method:** The application is designed to run locally on a Windows machine. It can be deployed via **ClickOnce deployment**, **MSIX packaging**, or compiled into a standalone Windows Executable (`.exe`) via Visual Studio's publish profile. It is not suitable for cloud web hosting (like Vercel or AWS ECS) as it is a WinForms desktop application.

## Any configs, env vars, or APIs
*   **APIs:** This application does not currently consume any external third-party REST APIs.
*   **Environment Variables:** No specific OS environment variables are required.
*   **Database Configuration:** The database connection string is currently **hardcoded** in the constructor or `Load` event of the form classes. 
    *   **Current configuration:** `Server=(LocalDb)\MSSQLLocalDB;Initial Catalog=Sistema;Integrated Security=True;TrustServerCertificate=True;`
    *   **Action required for production:** If you are migrating this out of a local development environment, you must update this connection string across the application (e.g., `frmCitas.cs`, `frmExpedientes.cs`, etc.) to point to your production SQL Server instance, or ideally, refactor it to read from an `App.config` or `appsettings.json` file.

## Licence: MIT
This project is licensed under the MIT License - see the LICENSE file for details.

~ Made with <3 by @RADWrld
