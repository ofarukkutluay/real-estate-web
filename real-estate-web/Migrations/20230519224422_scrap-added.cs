using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace real_estate_web.Migrations
{
    /// <inheritdoc />
    public partial class scrapadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.AddColumn<string>(
                name: "PropertyListingDetailId",
                table: "PropertyPhotos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SortIndex",
                table: "PropertyPhotos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "LocationLon",
                table: "Properties",
                type: "text",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LocationLat",
                table: "Properties",
                type: "text",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "PropertyListingDetails",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true),
                    ListingStoreName = table.Column<string>(type: "text", nullable: true),
                    ListingUserName = table.Column<string>(type: "text", nullable: true),
                    ListingPhoneNumbers = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DescriptionHtml = table.Column<string>(type: "text", nullable: true),
                    ListingDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    District = table.Column<string>(type: "text", nullable: true),
                    Neighborhood = table.Column<string>(type: "text", nullable: true),
                    LocationLat = table.Column<string>(type: "text", nullable: true),
                    LocationLon = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    Currency = table.Column<string>(type: "text", nullable: true),
                    Category = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    ReconstructionStatus = table.Column<string>(type: "text", nullable: true),
                    StructureType = table.Column<string>(type: "text", nullable: true),
                    GrossSquareMeter = table.Column<int>(type: "integer", nullable: false),
                    UsableSquareMeter = table.Column<int>(type: "integer", nullable: false),
                    PricePerSquareMeter = table.Column<double>(type: "double precision", nullable: false),
                    IndoorAreaSquareMeter = table.Column<int>(type: "integer", nullable: false),
                    OutdoorAreaSquareMeter = table.Column<int>(type: "integer", nullable: false),
                    BlockNo = table.Column<string>(type: "text", nullable: true),
                    PlotNo = table.Column<string>(type: "text", nullable: true),
                    LayoutNo = table.Column<string>(type: "text", nullable: true),
                    FloorAreaRatio = table.Column<string>(type: "text", nullable: true),
                    Gabari = table.Column<string>(type: "text", nullable: true),
                    RoomCount = table.Column<double>(type: "double precision", nullable: false),
                    LivingRoomCount = table.Column<short>(type: "smallint", nullable: false),
                    BuildingAge = table.Column<string>(type: "text", nullable: true),
                    Floor = table.Column<string>(type: "text", nullable: true),
                    BuildingTotalFloor = table.Column<string>(type: "text", nullable: true),
                    ElevatorCount = table.Column<string>(type: "text", nullable: true),
                    InletHeight = table.Column<string>(type: "text", nullable: true),
                    HeatingType = table.Column<string>(type: "text", nullable: true),
                    BathroomCount = table.Column<short>(type: "smallint", nullable: false),
                    IsThereBalcony = table.Column<bool>(type: "boolean", nullable: false),
                    IsFurnished = table.Column<bool>(type: "boolean", nullable: false),
                    UsingStatus = table.Column<string>(type: "text", nullable: true),
                    IsOnSite = table.Column<bool>(type: "boolean", nullable: false),
                    SiteName = table.Column<string>(type: "text", nullable: true),
                    Fees = table.Column<double>(type: "double precision", nullable: false),
                    IsAvailableLoan = table.Column<bool>(type: "boolean", nullable: false),
                    DeedStatus = table.Column<string>(type: "text", nullable: true),
                    FromProfile = table.Column<string>(type: "text", nullable: true),
                    IsBarter = table.Column<bool>(type: "boolean", nullable: false),
                    AlcoholLicense = table.Column<bool>(type: "boolean", nullable: false),
                    SoilSurvey = table.Column<bool>(type: "boolean", nullable: false),
                    Listinglink = table.Column<string>(type: "text", nullable: true),
                    PhotoLinks = table.Column<string>(type: "text", nullable: false),
                    PhotoPaths = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyListingDetails", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PropertyListingDetails");

            migrationBuilder.DropColumn(
                name: "PropertyListingDetailId",
                table: "PropertyPhotos");

            migrationBuilder.DropColumn(
                name: "SortIndex",
                table: "PropertyPhotos");

            migrationBuilder.AlterColumn<double>(
                name: "LocationLon",
                table: "Properties",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "LocationLat",
                table: "Properties",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LogType = table.Column<string>(type: "text", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });
        }
    }
}
