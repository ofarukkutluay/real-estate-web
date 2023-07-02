using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace real_estate_web.Migrations
{
    /// <inheritdoc />
    public partial class allentityisactivatedisdeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "UseCases",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "UseCases",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Streets",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Streets",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Statuses",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Statuses",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "PropertyTypes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PropertyTypes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "PropertyPhotos",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PropertyPhotos",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Neighborhood",
                table: "PropertyListingDetails",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "District",
                table: "PropertyListingDetails",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "PropertyListingDetails",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Properties",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Properties",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Neighborhoods",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Neighborhoods",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "JobTitles",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "JobTitles",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "InternetTypes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "InternetTypes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "HeatingTypes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "HeatingTypes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Fronts",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Fronts",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Districts",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Districts",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "DeedStatuses",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "DeedStatuses",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Contact",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Contact",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Cities",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Cities",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Blogs",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Blogs",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Agents",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "About",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "About",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "About",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BodyContentA", "BodyContentB", "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { "Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a.\n         Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec,\n          egestas non nisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec velit neque, \n          auctor sit amet aliquam vel, ullamcorper sit amet ligula.", "Sed porttitor lectus nibh. Vivamus magna justo, lacinia eget consectetur sed, \n        convallis at tellus. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. \n        Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus.", new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(470), true, false });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(480), true, false });

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(360), true, false });

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(360), true, false });

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(360), true, false });

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(360), true, false });

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(290), true, false });

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(290), true, false });

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(290), true, false });

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(290), true, false });

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(300), true, false });

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(300), true, false });

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(300), true, false });

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(300), true, false });

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(300), true, false });

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(370), true, false });

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(380), true, false });

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(380), true, false });

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(380), true, false });

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(380), true, false });

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(380), true, false });

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(390), true, false });

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(390), true, false });

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(390), true, false });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(400), true, false });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(400), true, false });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(400), true, false });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(400), true, false });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(410), true, false });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(410), true, false });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(410), true, false });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(410), true, false });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(410), true, false });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(410), true, false });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(410), true, false });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(410), true, false });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(420), true, false });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(420), true, false });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(420), true, false });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(420), true, false });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(420), true, false });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(430), true, false });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(430), true, false });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(430), true, false });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(450), true, false });

            migrationBuilder.UpdateData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(460), true, false });

            migrationBuilder.UpdateData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(460), true, false });

            migrationBuilder.UpdateData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2023, 6, 30, 20, 31, 2, 621, DateTimeKind.Utc).AddTicks(460), true, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "UseCases");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "UseCases");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Streets");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Streets");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "PropertyTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PropertyTypes");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "PropertyPhotos");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PropertyPhotos");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Neighborhoods");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Neighborhoods");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "JobTitles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "JobTitles");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "InternetTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "InternetTypes");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "HeatingTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "HeatingTypes");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Fronts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Fronts");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "DeedStatuses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "DeedStatuses");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Agents");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "About");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "About");

            migrationBuilder.AlterColumn<string>(
                name: "Neighborhood",
                table: "PropertyListingDetails",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "District",
                table: "PropertyListingDetails",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "PropertyListingDetails",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "About",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BodyContentA", "BodyContentB", "CreatedDate" },
                values: new object[] { "Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a.\r\n         Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec,\r\n          egestas non nisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec velit neque, \r\n          auctor sit amet aliquam vel, ullamcorper sit amet ligula.", "Sed porttitor lectus nibh. Vivamus magna justo, lacinia eget consectetur sed, \r\n        convallis at tellus. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. \r\n        Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus.", new DateTime(2023, 5, 20, 18, 55, 40, 460, DateTimeKind.Utc).AddTicks(8231) });

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
    }
}
