using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KGT.Data.Migrations
{
    public partial class ChangeIdColumnNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GuideId",
                table: "Guides",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DogId",
                table: "Dogs",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Guides",
                newName: "GuideId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Dogs",
                newName: "DogId");
        }
    }
}
