using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopiVerse.Migrations
{
    /// <inheritdoc />
    public partial class SeedCustomerTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "District", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, "Beşiktaş Mahallesi, No:1", "İstanbul", "Beşiktaş", "Ali", "Yılmaz" },
                    { 2, "Çankaya Mahallesi, No:2", "Ankara", "Çankaya", "Ayşe", "Kaya" },
                    { 3, "Bornova Mahallesi, No:3", "İzmir", "Bornova", "Mehmet", "Öz" },
                    { 4, "Nilüfer Mahallesi, No:4", "Bursa", "Nilüfer", "Elif", "Demir" },
                    { 5, "Konyaaltı Mahallesi, No:5", "Antalya", "Konyaaltı", "Ahmet", "Can" },
                    { 6, "İlkadım Mahallesi, No:6", "Samsun", "İlkadım", "Zeynep", "Balcı" },
                    { 7, "Ortahisar Mahallesi, No:7", "Trabzon", "Ortahisar", "Kemal", "Yıldız" },
                    { 8, "Tepebaşı Mahallesi, No:8", "Eskişehir", "Tepebaşı", "Seda", "Akar" },
                    { 9, "İzmit Mahallesi, No:9", "Kocaeli", "İzmit", "Murat", "Tekin" },
                    { 10, "Şahinbey Mahallesi, No:10", "Gaziantep", "Şahinbey", "Esra", "Kurt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
