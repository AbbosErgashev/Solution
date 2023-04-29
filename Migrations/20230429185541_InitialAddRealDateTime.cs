using Microsoft.EntityFrameworkCore.Migrations;

namespace Solution.Migrations
{
    public partial class InitialAddRealDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Birthday",
                table: "Users",
                newName: "CreateDateTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateDateTime",
                table: "Users",
                newName: "Birthday");
        }
    }
}
