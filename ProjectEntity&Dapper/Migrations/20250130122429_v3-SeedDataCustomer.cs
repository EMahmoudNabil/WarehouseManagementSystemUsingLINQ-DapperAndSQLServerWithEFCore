using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectEntity_Dapper.Migrations
{
    /// <inheritdoc />
    public partial class v3SeedDataCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Address", "City", "Country", "CustomerName", "Email", "Notes", "PhoneNumber", "isActive" },
                values: new object[,]
                {
                    { 1, "123 Main St", "New York", "USA", "John Doe", "johndoe@example.com", "Regular customer", "1234567890", true },
                    { 2, "456 Elm St", "Los Angeles", "USA", "Jane Smith", "janesmith@example.com", "VIP customer", "0987654321", true },
                    { 3, "15 Nile St", "Cairo", "Egypt", "Ali Hassan", "alihassan@example.com", "Inactive account", "01011223344", false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
