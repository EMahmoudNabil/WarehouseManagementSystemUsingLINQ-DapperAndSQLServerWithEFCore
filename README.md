# Warehouse Management System

A Windows Forms application for managing warehouse operations, built with C#, Entity Framework Core, Dapper, and SQL Server.

## Features

- User authentication (Admin/User roles)
- Product management (CRUD)
- Customer management
- Invoice management
- LINQ and Dapper data access
- Role-based access control

## Technologies Used

- .NET Framework (WinForms)
- C#
- Entity Framework Core
- Dapper
- SQL Server
- Windows Forms

## Prerequisites

- Visual Studio 2019 or later
- .NET Framework (version as per your .csproj)
- SQL Server (Express or higher)
- `warehousedb.bak` database backup

## Setup & Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/EMahmoudNabil/WarehouseManagementSystem.git
   ```

2. **Open the solution in Visual Studio.**

3. **Restore NuGet packages:**
   - Visual Studio will prompt you to restore missing packages on open.

4. **Configure the database:**
   - Restore the `warehousedb.bak` backup to your SQL Server instance.
   - Update the connection string in `App.config` or the relevant configuration file to point to your SQL Server.

5. **Build and run the application.**

## Usage

- Launch the application.
- Log in as Admin or User.
- Use the navigation to manage products, customers, and invoices.

## Database Setup

- The project uses a SQL Server database.
- Restore the provided `warehousedb.bak` file using SQL Server Management Studio (SSMS).
- Update the connection string in your configuration file as needed.

## Project Structure

- `Models/` - Entity and data models
- `Migrations/` - Entity Framework Core migrations
- `Invoices/` - Invoice management forms and logic
- `Products Form/` - Product management forms
- `Customer/` - Customer management forms
- `user/` - User management forms
- `Resources/` - Application resources
- `Program.cs` - Application entry point
- 
## 📚 Documentation
- [Project Demo Video](https://youtu.be/F8JWEz7xVCQ)
  
## Contributing

Contributions are welcome! Please open issues or submit pull requests for improvements and bug fixes.

## License

This project is licensed under the MIT License.
