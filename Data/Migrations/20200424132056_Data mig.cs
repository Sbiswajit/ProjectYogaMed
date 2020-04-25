using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectYogaMed.Data.Migrations
{
    public partial class Datamig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "data",
                table: "UserDisease",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "data",
                table: "UserDisease");
        }
    }
}
