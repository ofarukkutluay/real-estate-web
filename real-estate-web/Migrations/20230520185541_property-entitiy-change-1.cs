using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace real_estate_web.Migrations
{
    /// <inheritdoc />
    public partial class propertyentitiychange1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SortIndex",
                table: "PropertyPhotos",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "PropertyListingDetailId",
                table: "PropertyPhotos",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "About",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8208));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SortIndex",
                table: "PropertyPhotos",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PropertyListingDetailId",
                table: "PropertyPhotos",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "About",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(8022));
        }
    }
}
