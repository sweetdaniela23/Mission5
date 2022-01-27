using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission4.Migrations
{
    public partial class eneteal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "MovieID", "Category", "DirectorFirstName", "DirectorLastName", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Fantasy", "Marbalble", "Nonito", false, "Josh", "This is a great movie!", "PG", "Encanto", "2022" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "MovieID",
                keyValue: 1);
        }
    }
}
