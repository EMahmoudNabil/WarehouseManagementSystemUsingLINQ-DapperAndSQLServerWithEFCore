using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectEntity_Dapper.Migrations
{
    /// <inheritdoc />
    public partial class v2SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Electronics" },
                    { 2, "Clothing" },
                    { 3, "Furniture" },
                    { 4, "Books" },
                    { 5, "Home Appliances" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Code", "Image", "Name", "Note", "Price", "Quatity", "catid" },
                values: new object[,]
                {
                    { 1, "P001", null, "Product 1", "Description for product 1", 15.0m, 99, 2 },
                    { 2, "P002", null, "Product 2", "Description for product 2", 20.0m, 98, 3 },
                    { 3, "P003", null, "Product 3", "Description for product 3", 25.0m, 97, 4 },
                    { 4, "P004", null, "Product 4", "Description for product 4", 30.0m, 96, 5 },
                    { 5, "P005", null, "Product 5", "Description for product 5", 35.0m, 95, 1 },
                    { 6, "P006", null, "Product 6", "Description for product 6", 40.0m, 94, 2 },
                    { 7, "P007", null, "Product 7", "Description for product 7", 45.0m, 93, 3 },
                    { 8, "P008", null, "Product 8", "Description for product 8", 50.0m, 92, 4 },
                    { 9, "P009", null, "Product 9", "Description for product 9", 55.0m, 91, 5 },
                    { 10, "P010", null, "Product 10", "Description for product 10", 60.0m, 90, 1 },
                    { 11, "P011", null, "Product 11", "Description for product 11", 65.0m, 89, 2 },
                    { 12, "P012", null, "Product 12", "Description for product 12", 70.0m, 88, 3 },
                    { 13, "P013", null, "Product 13", "Description for product 13", 75.0m, 87, 4 },
                    { 14, "P014", null, "Product 14", "Description for product 14", 80.0m, 86, 5 },
                    { 15, "P015", null, "Product 15", "Description for product 15", 85.0m, 85, 1 },
                    { 16, "P016", null, "Product 16", "Description for product 16", 90.0m, 84, 2 },
                    { 17, "P017", null, "Product 17", "Description for product 17", 95.0m, 83, 3 },
                    { 18, "P018", null, "Product 18", "Description for product 18", 100.0m, 82, 4 },
                    { 19, "P019", null, "Product 19", "Description for product 19", 105.0m, 81, 5 },
                    { 20, "P020", null, "Product 20", "Description for product 20", 110.0m, 80, 1 },
                    { 21, "P021", null, "Product 21", "Description for product 21", 115.0m, 79, 2 },
                    { 22, "P022", null, "Product 22", "Description for product 22", 120.0m, 78, 3 },
                    { 23, "P023", null, "Product 23", "Description for product 23", 125.0m, 77, 4 },
                    { 24, "P024", null, "Product 24", "Description for product 24", 130.0m, 76, 5 },
                    { 25, "P025", null, "Product 25", "Description for product 25", 135.0m, 75, 1 },
                    { 26, "P026", null, "Product 26", "Description for product 26", 140.0m, 74, 2 },
                    { 27, "P027", null, "Product 27", "Description for product 27", 145.0m, 73, 3 },
                    { 28, "P028", null, "Product 28", "Description for product 28", 150.0m, 72, 4 },
                    { 29, "P029", null, "Product 29", "Description for product 29", 155.0m, 71, 5 },
                    { 30, "P030", null, "Product 30", "Description for product 30", 160.0m, 70, 1 },
                    { 31, "P031", null, "Product 31", "Description for product 31", 165.0m, 69, 2 },
                    { 32, "P032", null, "Product 32", "Description for product 32", 170.0m, 68, 3 },
                    { 33, "P033", null, "Product 33", "Description for product 33", 175.0m, 67, 4 },
                    { 34, "P034", null, "Product 34", "Description for product 34", 180.0m, 66, 5 },
                    { 35, "P035", null, "Product 35", "Description for product 35", 185.0m, 65, 1 },
                    { 36, "P036", null, "Product 36", "Description for product 36", 190.0m, 64, 2 },
                    { 37, "P037", null, "Product 37", "Description for product 37", 195.0m, 63, 3 },
                    { 38, "P038", null, "Product 38", "Description for product 38", 200.0m, 62, 4 },
                    { 39, "P039", null, "Product 39", "Description for product 39", 205.0m, 61, 5 },
                    { 40, "P040", null, "Product 40", "Description for product 40", 210.0m, 60, 1 },
                    { 41, "P041", null, "Product 41", "Description for product 41", 215.0m, 59, 2 },
                    { 42, "P042", null, "Product 42", "Description for product 42", 220.0m, 58, 3 },
                    { 43, "P043", null, "Product 43", "Description for product 43", 225.0m, 57, 4 },
                    { 44, "P044", null, "Product 44", "Description for product 44", 230.0m, 56, 5 },
                    { 45, "P045", null, "Product 45", "Description for product 45", 235.0m, 55, 1 },
                    { 46, "P046", null, "Product 46", "Description for product 46", 240.0m, 54, 2 },
                    { 47, "P047", null, "Product 47", "Description for product 47", 245.0m, 53, 3 },
                    { 48, "P048", null, "Product 48", "Description for product 48", 250.0m, 52, 4 },
                    { 49, "P049", null, "Product 49", "Description for product 49", 255.0m, 51, 5 },
                    { 50, "P050", null, "Product 50", "Description for product 50", 260.0m, 50, 1 },
                    { 51, "P051", null, "Product 51", "Description for product 51", 265.0m, 49, 2 },
                    { 52, "P052", null, "Product 52", "Description for product 52", 270.0m, 48, 3 },
                    { 53, "P053", null, "Product 53", "Description for product 53", 275.0m, 47, 4 },
                    { 54, "P054", null, "Product 54", "Description for product 54", 280.0m, 46, 5 },
                    { 55, "P055", null, "Product 55", "Description for product 55", 285.0m, 45, 1 },
                    { 56, "P056", null, "Product 56", "Description for product 56", 290.0m, 44, 2 },
                    { 57, "P057", null, "Product 57", "Description for product 57", 295.0m, 43, 3 },
                    { 58, "P058", null, "Product 58", "Description for product 58", 300.0m, 42, 4 },
                    { 59, "P059", null, "Product 59", "Description for product 59", 305.0m, 41, 5 },
                    { 60, "P060", null, "Product 60", "Description for product 60", 310.0m, 40, 1 },
                    { 61, "P061", null, "Product 61", "Description for product 61", 315.0m, 39, 2 },
                    { 62, "P062", null, "Product 62", "Description for product 62", 320.0m, 38, 3 },
                    { 63, "P063", null, "Product 63", "Description for product 63", 325.0m, 37, 4 },
                    { 64, "P064", null, "Product 64", "Description for product 64", 330.0m, 36, 5 },
                    { 65, "P065", null, "Product 65", "Description for product 65", 335.0m, 35, 1 },
                    { 66, "P066", null, "Product 66", "Description for product 66", 340.0m, 34, 2 },
                    { 67, "P067", null, "Product 67", "Description for product 67", 345.0m, 33, 3 },
                    { 68, "P068", null, "Product 68", "Description for product 68", 350.0m, 32, 4 },
                    { 69, "P069", null, "Product 69", "Description for product 69", 355.0m, 31, 5 },
                    { 70, "P070", null, "Product 70", "Description for product 70", 360.0m, 30, 1 },
                    { 71, "P071", null, "Product 71", "Description for product 71", 365.0m, 29, 2 },
                    { 72, "P072", null, "Product 72", "Description for product 72", 370.0m, 28, 3 },
                    { 73, "P073", null, "Product 73", "Description for product 73", 375.0m, 27, 4 },
                    { 74, "P074", null, "Product 74", "Description for product 74", 380.0m, 26, 5 },
                    { 75, "P075", null, "Product 75", "Description for product 75", 385.0m, 25, 1 },
                    { 76, "P076", null, "Product 76", "Description for product 76", 390.0m, 24, 2 },
                    { 77, "P077", null, "Product 77", "Description for product 77", 395.0m, 23, 3 },
                    { 78, "P078", null, "Product 78", "Description for product 78", 400.0m, 22, 4 },
                    { 79, "P079", null, "Product 79", "Description for product 79", 405.0m, 21, 5 },
                    { 80, "P080", null, "Product 80", "Description for product 80", 410.0m, 20, 1 },
                    { 81, "P081", null, "Product 81", "Description for product 81", 415.0m, 19, 2 },
                    { 82, "P082", null, "Product 82", "Description for product 82", 420.0m, 18, 3 },
                    { 83, "P083", null, "Product 83", "Description for product 83", 425.0m, 17, 4 },
                    { 84, "P084", null, "Product 84", "Description for product 84", 430.0m, 16, 5 },
                    { 85, "P085", null, "Product 85", "Description for product 85", 435.0m, 15, 1 },
                    { 86, "P086", null, "Product 86", "Description for product 86", 440.0m, 14, 2 },
                    { 87, "P087", null, "Product 87", "Description for product 87", 445.0m, 13, 3 },
                    { 88, "P088", null, "Product 88", "Description for product 88", 450.0m, 12, 4 },
                    { 89, "P089", null, "Product 89", "Description for product 89", 455.0m, 11, 5 },
                    { 90, "P090", null, "Product 90", "Description for product 90", 460.0m, 10, 1 },
                    { 91, "P091", null, "Product 91", "Description for product 91", 465.0m, 9, 2 },
                    { 92, "P092", null, "Product 92", "Description for product 92", 470.0m, 8, 3 },
                    { 93, "P093", null, "Product 93", "Description for product 93", 475.0m, 7, 4 },
                    { 94, "P094", null, "Product 94", "Description for product 94", 480.0m, 6, 5 },
                    { 95, "P095", null, "Product 95", "Description for product 95", 485.0m, 5, 1 },
                    { 96, "P096", null, "Product 96", "Description for product 96", 490.0m, 4, 2 },
                    { 97, "P097", null, "Product 97", "Description for product 97", 495.0m, 3, 3 },
                    { 98, "P098", null, "Product 98", "Description for product 98", 500.0m, 2, 4 },
                    { 99, "P099", null, "Product 99", "Description for product 99", 505.0m, 1, 5 },
                    { 100, "P100", null, "Product 100", "Description for product 100", 510.0m, 0, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
