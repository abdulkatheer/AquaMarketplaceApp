using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedValuesToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "Users",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "address", "area", "companyName", "companyType", "contactName", "country", "mobileCountryCode", "mobileNumber", "naupliiSupplier", "referralCode", "state" },
                values: new object[] { 1, "Paraipatty", "Dindigul", "IG", "IT", "Mohideen Abdul Katheer M", "India", "91", "8220644661", "None", "None", "Tamilnadu" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "address", "area", "companyName", "companyType", "contactName", "country", "mobileCountryCode", "mobileNumber", "naupliiSupplier", "referralCode", "state" },
                values: new object[] { 2, "TNagar", "Chennai", "Accenture", "IT", "Dhanalakshmi N", "India", "91", "9789161541", "None", "None", "Tamilnadu" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "address",
                table: "Users");
        }
    }
}
