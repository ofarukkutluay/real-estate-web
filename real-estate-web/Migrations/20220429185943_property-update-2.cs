using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace real_estate_web.Migrations
{
    public partial class propertyupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Streets_SokakId",
                table: "Properties");

            migrationBuilder.AlterColumn<int>(
                name: "SokakId",
                table: "Properties",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Streets_SokakId",
                table: "Properties",
                column: "SokakId",
                principalTable: "Streets",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Streets_SokakId",
                table: "Properties");

            migrationBuilder.AlterColumn<int>(
                name: "SokakId",
                table: "Properties",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Streets_SokakId",
                table: "Properties",
                column: "SokakId",
                principalTable: "Streets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
