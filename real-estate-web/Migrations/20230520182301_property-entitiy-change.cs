using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace real_estate_web.Migrations
{
    /// <inheritdoc />
    public partial class propertyentitiychange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_DeedStatuses_TapuDurumuId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Fronts_CepheId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_HeatingTypes_IsitmaTipiId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_InternetTypes_InternetTipiId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_PropertyTypes_PropertyTypeId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Statuses_StatusId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_UseCases_KullanimDurumuId",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_CepheId",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_InternetTipiId",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_IsitmaTipiId",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_KullanimDurumuId",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_PropertyTypeId",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_StatusId",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_TapuDurumuId",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "CepheId",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "InternetTipiId",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "IsitmaTipiId",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "KullanimDurumuId",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "PropertyTypeId",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "TapuDurumuId",
                table: "Properties");

            migrationBuilder.AlterColumn<string>(
                name: "ToplamKat",
                table: "Properties",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "BulunduguKat",
                table: "Properties",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "BinaYasi",
                table: "Properties",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "Cephe",
                table: "Properties",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InternetTipi",
                table: "Properties",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IsitmaTipi",
                table: "Properties",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KullanimDurumu",
                table: "Properties",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PropertyType",
                table: "Properties",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Properties",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TapuDurumu",
                table: "Properties",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "Id", "BodyContentA", "BodyContentB", "BodyTitle", "CreatedDate", "Title", "UpdatedDate" },
                values: new object[] { 1, "Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a.\r\n         Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec,\r\n          egestas non nisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec velit neque, \r\n          auctor sit amet aliquam vel, ullamcorper sit amet ligula.", "Sed porttitor lectus nibh. Vivamus magna justo, lacinia eget consectetur sed, \r\n        convallis at tellus. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. \r\n        Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus.", "Neden biz?", new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(8035), "Birlikte mutlu anılar biriktirebileceğiniz mülkler buluyoruz", null });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "Id", "Address", "CreatedDate", "Email", "FacebookUrl", "GoogleIFrameUrl", "HeaderDescription", "InstagramUrl", "LinkedInUrl", "PhoneNumber", "TwitterUrl", "UpdatedDate" },
                values: new object[] { 1, "Üsküdar/İstanbul", new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(8049), "contact@example.com", null, "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3009.665346984029!2d29.08746581564773!3d41.03257692587779!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cac8566285c3d7%3A0x60da11ebc95f76ce!2sTantavi%2C%20Estergon%20Cd.%20No%3A43%2C%2034764%20%C3%9Cmraniye%2F%C4%B0stanbul!5e0!3m2!1str!2str!4v1649872532554!5m2!1str!2str", "Aut voluptas consequatur unde sed omnis ex placeat quis eos. Aut natus officia corrupti qui autem fugit consectetur quo. Et ipsum eveniet laboriosam voluptas beatae possimus qui ducimus. Et voluptatem deleniti. Voluptatum voluptatibus amet. Et esse sed omnis inventore hic culpa.", null, null, "+54 356 945234", null, null });

            migrationBuilder.InsertData(
                table: "DeedStatuses",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7917), "Kat Mülkiyetli", null },
                    { 2, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7918), "Kat İrtifaklı", null },
                    { 3, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7919), "Arsa", null },
                    { 4, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7919), "Tarla", null }
                });

            migrationBuilder.InsertData(
                table: "Fronts",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7694), "Kuzey", null },
                    { 2, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7698), "Kuzey Doğu", null },
                    { 3, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7699), "Doğu", null },
                    { 4, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7700), "Güney Doğu", null },
                    { 5, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7700), "Güney", null },
                    { 6, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7701), "Güney Batı", null },
                    { 7, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7749), "Batı", null },
                    { 8, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7750), "Kuzey Batı", null },
                    { 9, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7751), "Bilinmiyor", null }
                });

            migrationBuilder.InsertData(
                table: "HeatingTypes",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7936), "Doğalgaz Sobalı", null },
                    { 2, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7937), "Sobalı", null },
                    { 3, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7937), "Yerden Isıtma", null },
                    { 4, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7938), "Kombili", null },
                    { 5, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7938), "Merkezi Sistem", null },
                    { 6, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7939), "FuelOil", null }
                });

            migrationBuilder.InsertData(
                table: "InternetTypes",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7953), "ADSL/VDSL", null },
                    { 2, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7954), "Fiber", null },
                    { 3, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7955), "Bilinmiyor", null }
                });

            migrationBuilder.InsertData(
                table: "JobTitles",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7969), null, "Broker", null },
                    { 2, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7970), null, "Danışman", null },
                    { 3, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7970), null, "Müdür", null },
                    { 4, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7971), null, "Asistan", null }
                });

            migrationBuilder.InsertData(
                table: "PropertyTypes",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7983), "Daire", null },
                    { 2, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7984), "Rezidence", null },
                    { 3, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7985), "Müstakil Ev", null },
                    { 4, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7985), "Villa", null },
                    { 5, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7986), "Çiftlik Evi", null },
                    { 6, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7986), "Yazlık", null },
                    { 7, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7987), "Büro/Ofis", null },
                    { 8, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7987), "Depo/Antrepo", null },
                    { 9, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7988), "Dükkan/Mağaza", null },
                    { 10, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7988), "Plaza", null },
                    { 11, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7989), "Palaza Katı", null },
                    { 12, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7989), "Sağlık Merkezi", null },
                    { 13, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(7990), "Spor Tesisi", null }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(8007), "Satılık", null },
                    { 2, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(8008), "Kiralık", null },
                    { 3, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(8008), "Devren Satılık", null },
                    { 4, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(8009), "Devren Kiralık", null }
                });

            migrationBuilder.InsertData(
                table: "UseCases",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(8021), "Boş", null },
                    { 2, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(8022), "Mülk Sahibi", null },
                    { 3, new DateTime(2023, 5, 20, 18, 23, 1, 559, DateTimeKind.Utc).AddTicks(8022), "Kiracılı", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "About",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Cephe",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "InternetTipi",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "IsitmaTipi",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "KullanimDurumu",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "PropertyType",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "TapuDurumu",
                table: "Properties");

            migrationBuilder.AlterColumn<int>(
                name: "ToplamKat",
                table: "Properties",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BulunduguKat",
                table: "Properties",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BinaYasi",
                table: "Properties",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CepheId",
                table: "Properties",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InternetTipiId",
                table: "Properties",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IsitmaTipiId",
                table: "Properties",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KullanimDurumuId",
                table: "Properties",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PropertyTypeId",
                table: "Properties",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Properties",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TapuDurumuId",
                table: "Properties",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Properties_CepheId",
                table: "Properties",
                column: "CepheId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_InternetTipiId",
                table: "Properties",
                column: "InternetTipiId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_IsitmaTipiId",
                table: "Properties",
                column: "IsitmaTipiId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_KullanimDurumuId",
                table: "Properties",
                column: "KullanimDurumuId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_PropertyTypeId",
                table: "Properties",
                column: "PropertyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_StatusId",
                table: "Properties",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_TapuDurumuId",
                table: "Properties",
                column: "TapuDurumuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_DeedStatuses_TapuDurumuId",
                table: "Properties",
                column: "TapuDurumuId",
                principalTable: "DeedStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Fronts_CepheId",
                table: "Properties",
                column: "CepheId",
                principalTable: "Fronts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_HeatingTypes_IsitmaTipiId",
                table: "Properties",
                column: "IsitmaTipiId",
                principalTable: "HeatingTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_InternetTypes_InternetTipiId",
                table: "Properties",
                column: "InternetTipiId",
                principalTable: "InternetTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_PropertyTypes_PropertyTypeId",
                table: "Properties",
                column: "PropertyTypeId",
                principalTable: "PropertyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Statuses_StatusId",
                table: "Properties",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_UseCases_KullanimDurumuId",
                table: "Properties",
                column: "KullanimDurumuId",
                principalTable: "UseCases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
