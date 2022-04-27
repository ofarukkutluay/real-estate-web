using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace real_estate_web.Migrations
{
    public partial class propertyupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KonumIFrame",
                table: "Properties",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KonumIFrame",
                table: "Properties");
        }
    }
}
