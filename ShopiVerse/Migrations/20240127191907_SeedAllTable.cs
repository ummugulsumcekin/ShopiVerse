using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopiVerse.Migrations
{
    /// <inheritdoc />
    public partial class SeedAllTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "OrderDate", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500.00m },
                    { 2, 2, new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 400.00m },
                    { 3, 3, new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 300.00m },
                    { 4, 4, new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.00m },
                    { 5, 5, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.00m },
                    { 6, 6, new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 600.00m },
                    { 7, 7, new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 700.00m },
                    { 8, 8, new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 800.00m },
                    { 9, 9, new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 900.00m },
                    { 10, 10, new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000.00m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { 1, "Ürün 1", 100.00m, 50 },
                    { 2, "Ürün 2", 150.00m, 40 },
                    { 3, "Ürün 3", 200.00m, 30 },
                    { 4, "Ürün 4", 250.00m, 20 },
                    { 5, "Ürün 5", 300.00m, 10 },
                    { 6, "Ürün 6", 350.00m, 5 },
                    { 7, "Ürün 7", 400.00m, 15 },
                    { 8, "Ürün 8", 450.00m, 25 },
                    { 9, "Ürün 9", 500.00m, 35 },
                    { 10, "Ürün 10", 550.00m, 45 }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CustomerId", "Price", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 100.00m, 1, 2 },
                    { 2, 1, 150.00m, 2, 3 },
                    { 3, 2, 200.00m, 3, 1 },
                    { 4, 2, 250.00m, 4, 2 },
                    { 5, 3, 300.00m, 5, 1 },
                    { 6, 3, 350.00m, 6, 1 },
                    { 7, 4, 400.00m, 7, 1 },
                    { 8, 4, 450.00m, 8, 1 },
                    { 9, 5, 500.00m, 9, 2 },
                    { 10, 5, 550.00m, 10, 3 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, 1, 2, 100.00m },
                    { 2, 1, 2, 1, 150.00m },
                    { 3, 2, 3, 3, 200.00m },
                    { 4, 2, 4, 2, 250.00m },
                    { 5, 3, 5, 1, 300.00m },
                    { 6, 3, 6, 2, 350.00m },
                    { 7, 4, 7, 1, 400.00m },
                    { 8, 4, 8, 1, 450.00m },
                    { 9, 5, 9, 3, 500.00m },
                    { 10, 5, 10, 2, 550.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

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
        }
    }
}
