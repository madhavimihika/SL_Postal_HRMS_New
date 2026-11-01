# SL_Postal_HRMS - Human Resource Management System

A comprehensive, desktop-based Human Resource Management System (HRMS) built with **C# (.NET Framework)** and **Windows Forms**, specifically designed for the **Central Mail Exchange, Sri Lanka** (Department of Posts). 

This system digitizes and automates the manual, paper-based HR processes currently used by the organization, improving efficiency, data security, and communication between departments.

## 🚀 Key Features

*   **Role-Based Access Control (RBAC):** Distinct dashboards and permissions for Superintendents, Assistant Registration Officers, Accountants, and Employees/Postal Assistants.
*   **Secure Authentication:** Login and Signup using NIC as the username, with SHA-256 password hashing. Includes a "Change Password" feature.
*   **Employee Management (Full CRUD):** 
    *   *Registration Officers* can add new employees, view all staff, update their details, and delete resigned/retired employees.
    *   **Export to Excel/CSV:** Export the entire employee database to a spreadsheet with one click.
    *   **Probation Tracking:** Set probation end dates, receive automated login reminders for upcoming probation completions (within 14 days), and convert employees to permanent status.
*   **Department Transfer Workflow:** 
    *   *Employees* can submit a transfer request to another department with a reason.
    *   *Employees* can track the real-time status of their request (Processing, Approved, Rejected).
    *   *Registration Officers* can view pending requests and Approve/Reject them. Approving a request automatically updates the employee's department in the system.
*   **Leave Management:** 
    *   *Employees* can apply for leave and track the status in real-time.
    *   *Superintendent* can approve or reject pending leave requests.
*   **Attendance Management:** Employees can digitally Clock In and Clock Out, and view their attendance history.
*   **Salary Management:** 
    *   *Accountants* can calculate and process monthly salaries (Basic + Allowances - Deductions).
    *   *Employees* can view their historical payslips.
*   **Feedback System:** Any user can submit system feedback or suggestions, which the Superintendent can review.

## 🛠️ Tech Stack
*   **Frontend:** C# (.NET Framework), Windows Forms (WinForms)
*   **Backend:** C# Object-Oriented Programming
*   **Database:** MySQL (MariaDB via XAMPP/phpMyAdmin)
*   **Libraries:** `MySql.Data` (NuGet Package)
*   **Security:** SHA-256 Password Hashing

---

## 💻 How to Setup and Run the Project

### 1. Database Setup
1. Open **phpMyAdmin** (or your MySQL client).
2. Create a new database named `sl_postal_hrms` (or `postal_hrms_db`).
3. Import the `sl_postal_hrms.sql` file (located in the root of this repository) into the database to create the tables and sample data.

### 2. Project Setup
1. Clone this repository to your local machine.
2. Open the solution file (`.sln`) in **Visual Studio**.
3. Ensure the **`MySql.Data`** NuGet package is installed (Right-click Solution -> Manage NuGet Packages -> Search for `MySql.Data` -> Install).
4. Open **`DbConnection.cs`** and update the connection string to match your local MySQL setup:
   ```csharp
   private static string connectionString = "Server=localhost;Database=sl_postal_hrms;Uid=root;Pwd=YOUR_PASSWORD_HERE;";
