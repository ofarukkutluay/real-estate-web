using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace real_estate_web.Migrations
{
    public partial class propertyupdate2fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Streets_SokakId",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_SokakId",
                table: "Properties");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Properties_SokakId",
                table: "Properties",
                column: "SokakId");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Streets_SokakId",
                table: "Properties",
                column: "SokakId",
                principalTable: "Streets",
                principalColumn: "Id");
        }
    }
}
