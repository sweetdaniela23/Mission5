using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission4.Migrations
{
    public partial class thisone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "MovieID", "Category", "DirectorFirstName", "DirectorLastName", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Action", "Stephen", "Spielberg", false, "Britti", "MY FAVORITE", "PG", "The Count of Monte Cristo", "1986" });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "MovieID", "Category", "DirectorFirstName", "DirectorLastName", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Drama", "Johnny", "Appleseed", false, "Jonah", "Don't cry.", "PG-13", "Titanic", "1990" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "MovieID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "MovieID",
                keyValue: 3);
        }
    }
}
