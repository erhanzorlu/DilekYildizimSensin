using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DilekYildizimSensin.Migrations
{
    /// <inheritdoc />
    public partial class secondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: new Guid("0c632c45-0e23-4445-8d7e-0be8f775ccaa"));

            migrationBuilder.DeleteData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: new Guid("8efc3530-6112-4463-b68e-8e39ce91167e"));

            migrationBuilder.DeleteData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: new Guid("b0091448-7fb7-4574-8a32-ecb16e2f548d"));

            migrationBuilder.DeleteData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: new Guid("b90322a6-d3fa-4665-9d39-ffef9bee1b83"));

            migrationBuilder.DeleteData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: new Guid("f41171d1-090b-4716-af01-82163c403320"));

            migrationBuilder.DeleteData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: new Guid("1a3cc996-9d61-43d8-816c-b9471159f9e5"));

            migrationBuilder.DeleteData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: new Guid("d0ce9ee2-44bd-4d7e-b9eb-c76584e5d71f"));

            migrationBuilder.DeleteData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: new Guid("ec24b9f6-6bd3-42f9-bf42-41c77caa36bb"));

            migrationBuilder.DeleteData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: new Guid("fc8e85b1-7f89-47ee-9d72-03877626e305"));

            migrationBuilder.AddColumn<DateOnly>(
                name: "EventDate",
                table: "UserEvents",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"),
                column: "ConcurrencyStamp",
                value: "c5a19039-4be1-4f01-863e-e643500d5f39");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"),
                column: "ConcurrencyStamp",
                value: "0bb9151a-0eb1-4316-884d-5c626c3c7b69");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"),
                column: "ConcurrencyStamp",
                value: "b87c545e-441b-484c-ae35-d5c037e9af48");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccc5ba7b-0deb-49fb-8140-88feea4c74bc", "AQAAAAIAAYagAAAAEJkSsEurBeY6pCaFq0VhV7/+hr6RvOif8TWsWOEoS/fD5bI1Ovq3KT35NSMzKhv5JQ==", "4eb6a33c-740b-404f-a00c-ff612d44eab1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5bdf3b72-62af-4d30-8bc8-0b6cf723ae57"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c8a11971-c2d2-4965-97cd-49fed7d4f846", "4163a942-f0aa-4707-b739-5a26e3bf2945" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("99f21431-f75d-4b53-b0bc-c46a5a8db1a9"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0050cd9c-ad57-415e-8d10-7dd620e4d303", "88c00f91-c788-4676-be84-2bee779d7957" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a5b6d3ea-7baa-49b8-808c-2d7d72f9c0d1"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b7fe68b2-c270-403a-a288-907dc4b5af70", "f0b8714a-0438-4b4e-9ac1-200a2af405c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c9a80a3a-f3af-439b-a4a3-985e65272a22"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "269b3487-72f6-4986-9790-d4b405cf20a8", "1f0ec048-6acd-478d-8792-aa55eb51cd18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4af2165d-4845-4473-bdea-d4d391cf81e1", "AQAAAAIAAYagAAAAEM02htHXEONNyjqrUdd4FiiaGvLQl7YKP/GJFzFaeEszerrdbtqIrME2KWAVpQxfqg==", "753c67eb-34c2-42b2-84bf-9b23a1a9bfae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e48db928-a5fc-4a9c-b72e-6373a453c6c7"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5f9b1d60-9dad-4e13-832d-4eb0c48a8256", "4a267e1f-bb2f-475c-8da9-019d3c113cf5" });

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: new Guid("0299a520-25ca-49ec-9492-035ccf2ed5b8"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 1, 21, 41, 3, 378, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: new Guid("5d706d85-8780-43eb-9f0b-21f6d6ae9a07"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 1, 21, 41, 3, 378, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: new Guid("6296d6f2-052e-40fb-bf0b-72eb2ac34a6d"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 1, 21, 41, 3, 378, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: new Guid("820b74d4-c6f7-4823-a45e-6dbd41311212"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 1, 21, 41, 3, 378, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: new Guid("8bf1da2f-a48e-4ecf-94a0-3b85e3cb32d2"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 1, 21, 41, 3, 378, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("1328a6c8-9ebd-4b22-978a-453f0c31bbdf"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 1, 18, 41, 3, 378, DateTimeKind.Utc).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("1e7bc8e4-59a8-4f63-af21-c7697a727f64"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 1, 18, 41, 3, 378, DateTimeKind.Utc).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("3c5b8e39-a8f8-4671-a573-2e1e5e8a6f85"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 1, 18, 41, 3, 378, DateTimeKind.Utc).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e6481d73-37e2-4b7e-a817-a7d0921797c6"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 1, 18, 41, 3, 378, DateTimeKind.Utc).AddTicks(2650));

            migrationBuilder.InsertData(
                table: "UserBadges",
                columns: new[] { "Id", "AppUserId", "BadgeId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("1cf0a5b4-ef09-41fc-88c6-a5db6821042e"), new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), new Guid("8bf1da2f-a48e-4ecf-94a0-3b85e3cb32d2"), "Undefined", new DateTime(2024, 11, 1, 21, 41, 3, 379, DateTimeKind.Local).AddTicks(2996), null, null, false, null, null },
                    { new Guid("53445d2c-7b02-4caa-b09c-00248a2cea7f"), new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), new Guid("0299a520-25ca-49ec-9492-035ccf2ed5b8"), "Undefined", new DateTime(2024, 11, 1, 21, 41, 3, 379, DateTimeKind.Local).AddTicks(2967), null, null, false, null, null },
                    { new Guid("87277119-826b-486b-9055-8a26c443ce57"), new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), new Guid("820b74d4-c6f7-4823-a45e-6dbd41311212"), "Undefined", new DateTime(2024, 11, 1, 21, 41, 3, 379, DateTimeKind.Local).AddTicks(3005), null, null, false, null, null },
                    { new Guid("bdbdc92b-7c80-4b41-9c74-ba0e8a766f12"), new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), new Guid("5d706d85-8780-43eb-9f0b-21f6d6ae9a07"), "Undefined", new DateTime(2024, 11, 1, 21, 41, 3, 379, DateTimeKind.Local).AddTicks(3001), null, null, false, null, null },
                    { new Guid("fe445a87-bf6c-49f8-a3d5-e8cc3737d896"), new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), new Guid("0299a520-25ca-49ec-9492-035ccf2ed5b8"), "Undefined", new DateTime(2024, 11, 1, 21, 41, 3, 379, DateTimeKind.Local).AddTicks(3009), null, null, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "UserEvents",
                columns: new[] { "Id", "AppUserId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "EventDate", "EventId", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("2a99c490-b17c-47f8-a6e8-a820cd955212"), new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), "Undefined", new DateTime(2024, 11, 1, 18, 41, 3, 379, DateTimeKind.Utc).AddTicks(5198), null, null, new DateOnly(1, 1, 1), new Guid("1328a6c8-9ebd-4b22-978a-453f0c31bbdf"), false, null, null },
                    { new Guid("9d4d3874-b413-43d3-96b1-bb04a2dd21dd"), new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), "Undefined", new DateTime(2024, 11, 1, 18, 41, 3, 379, DateTimeKind.Utc).AddTicks(5209), null, null, new DateOnly(1, 1, 1), new Guid("e6481d73-37e2-4b7e-a817-a7d0921797c6"), false, null, null },
                    { new Guid("ca77e4ed-63ed-4b82-9395-c2c76d299c7d"), new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), "Undefined", new DateTime(2024, 11, 1, 18, 41, 3, 379, DateTimeKind.Utc).AddTicks(5203), null, null, new DateOnly(1, 1, 1), new Guid("1e7bc8e4-59a8-4f63-af21-c7697a727f64"), false, null, null },
                    { new Guid("d8d288bd-cd09-4d8a-993a-1b1d531fd83a"), new Guid("5bdf3b72-62af-4d30-8bc8-0b6cf723ae57"), "Undefined", new DateTime(2024, 11, 1, 18, 41, 3, 379, DateTimeKind.Utc).AddTicks(5206), null, null, new DateOnly(1, 1, 1), new Guid("3c5b8e39-a8f8-4671-a573-2e1e5e8a6f85"), false, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: new Guid("1cf0a5b4-ef09-41fc-88c6-a5db6821042e"));

            migrationBuilder.DeleteData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: new Guid("53445d2c-7b02-4caa-b09c-00248a2cea7f"));

            migrationBuilder.DeleteData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: new Guid("87277119-826b-486b-9055-8a26c443ce57"));

            migrationBuilder.DeleteData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: new Guid("bdbdc92b-7c80-4b41-9c74-ba0e8a766f12"));

            migrationBuilder.DeleteData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: new Guid("fe445a87-bf6c-49f8-a3d5-e8cc3737d896"));

            migrationBuilder.DeleteData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: new Guid("2a99c490-b17c-47f8-a6e8-a820cd955212"));

            migrationBuilder.DeleteData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: new Guid("9d4d3874-b413-43d3-96b1-bb04a2dd21dd"));

            migrationBuilder.DeleteData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: new Guid("ca77e4ed-63ed-4b82-9395-c2c76d299c7d"));

            migrationBuilder.DeleteData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: new Guid("d8d288bd-cd09-4d8a-993a-1b1d531fd83a"));

            migrationBuilder.DropColumn(
                name: "EventDate",
                table: "UserEvents");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"),
                column: "ConcurrencyStamp",
                value: "1347112e-35ef-4755-a20e-26afa666cae8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"),
                column: "ConcurrencyStamp",
                value: "a6fedf89-4dd6-4eb0-8c20-fde2dc7bf69f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"),
                column: "ConcurrencyStamp",
                value: "46c061a7-3a3d-4546-a8a0-d0c6dc2a1f99");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "458c2473-23cc-425d-93b1-6277c12081a6", "AQAAAAIAAYagAAAAEIzFGgQcxrlLbUpxmooMHWPAmPto1gqQIH1fpn71sPc0wTwWtfjYNBzAIFTYRR5/wQ==", "d81f158f-101d-4bdb-bf5a-9afa5cc73b6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5bdf3b72-62af-4d30-8bc8-0b6cf723ae57"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "56cb57d1-d07a-4417-8a93-a04c7c4eb783", "f5e8d43c-8c59-4406-84f5-1b23e839cc78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("99f21431-f75d-4b53-b0bc-c46a5a8db1a9"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2ce8f44f-3bf9-44af-af21-a757a4240818", "7916ae57-1d4a-448d-abbe-336c71e49201" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a5b6d3ea-7baa-49b8-808c-2d7d72f9c0d1"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b140f918-56f6-4ced-91d0-74140c848bb5", "56d1683e-3fdb-466c-9162-1350d6bb3680" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c9a80a3a-f3af-439b-a4a3-985e65272a22"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a93b9764-45f9-48b8-bb1d-4274076e0d7e", "73f46d41-4d14-4c6b-bde0-caa4ffa5517d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f9c987d-0dba-472b-8199-dd005cd9730c", "AQAAAAIAAYagAAAAEH/uGZkPKmZlWa6ZgRtijLOVfJSU+vs6MRuMAyMjY5D2aP2/IggLQXy2d82xFbTsRA==", "1243dba8-5d3c-4e97-8130-eb7cb65769e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e48db928-a5fc-4a9c-b72e-6373a453c6c7"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "381abd04-5e62-4536-bd70-f84cd6a3d981", "ee9b2005-b24d-4052-a550-3811bfbd0245" });

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: new Guid("0299a520-25ca-49ec-9492-035ccf2ed5b8"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 1, 16, 21, 52, 482, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: new Guid("5d706d85-8780-43eb-9f0b-21f6d6ae9a07"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 1, 16, 21, 52, 482, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: new Guid("6296d6f2-052e-40fb-bf0b-72eb2ac34a6d"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 1, 16, 21, 52, 482, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: new Guid("820b74d4-c6f7-4823-a45e-6dbd41311212"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 1, 16, 21, 52, 482, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: new Guid("8bf1da2f-a48e-4ecf-94a0-3b85e3cb32d2"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 1, 16, 21, 52, 482, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("1328a6c8-9ebd-4b22-978a-453f0c31bbdf"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 1, 13, 21, 52, 483, DateTimeKind.Utc).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("1e7bc8e4-59a8-4f63-af21-c7697a727f64"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 1, 13, 21, 52, 483, DateTimeKind.Utc).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("3c5b8e39-a8f8-4671-a573-2e1e5e8a6f85"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 1, 13, 21, 52, 483, DateTimeKind.Utc).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e6481d73-37e2-4b7e-a817-a7d0921797c6"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 1, 13, 21, 52, 483, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.InsertData(
                table: "UserBadges",
                columns: new[] { "Id", "AppUserId", "BadgeId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("0c632c45-0e23-4445-8d7e-0be8f775ccaa"), new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), new Guid("8bf1da2f-a48e-4ecf-94a0-3b85e3cb32d2"), "Undefined", new DateTime(2024, 11, 1, 16, 21, 52, 485, DateTimeKind.Local).AddTicks(1587), null, null, false, null, null },
                    { new Guid("8efc3530-6112-4463-b68e-8e39ce91167e"), new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), new Guid("820b74d4-c6f7-4823-a45e-6dbd41311212"), "Undefined", new DateTime(2024, 11, 1, 16, 21, 52, 485, DateTimeKind.Local).AddTicks(1615), null, null, false, null, null },
                    { new Guid("b0091448-7fb7-4574-8a32-ecb16e2f548d"), new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), new Guid("0299a520-25ca-49ec-9492-035ccf2ed5b8"), "Undefined", new DateTime(2024, 11, 1, 16, 21, 52, 485, DateTimeKind.Local).AddTicks(1540), null, null, false, null, null },
                    { new Guid("b90322a6-d3fa-4665-9d39-ffef9bee1b83"), new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), new Guid("0299a520-25ca-49ec-9492-035ccf2ed5b8"), "Undefined", new DateTime(2024, 11, 1, 16, 21, 52, 485, DateTimeKind.Local).AddTicks(1621), null, null, false, null, null },
                    { new Guid("f41171d1-090b-4716-af01-82163c403320"), new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), new Guid("5d706d85-8780-43eb-9f0b-21f6d6ae9a07"), "Undefined", new DateTime(2024, 11, 1, 16, 21, 52, 485, DateTimeKind.Local).AddTicks(1607), null, null, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "UserEvents",
                columns: new[] { "Id", "AppUserId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "EventId", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("1a3cc996-9d61-43d8-816c-b9471159f9e5"), new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), "Undefined", new DateTime(2024, 11, 1, 13, 21, 52, 485, DateTimeKind.Utc).AddTicks(5148), null, null, new Guid("1e7bc8e4-59a8-4f63-af21-c7697a727f64"), false, null, null },
                    { new Guid("d0ce9ee2-44bd-4d7e-b9eb-c76584e5d71f"), new Guid("5bdf3b72-62af-4d30-8bc8-0b6cf723ae57"), "Undefined", new DateTime(2024, 11, 1, 13, 21, 52, 485, DateTimeKind.Utc).AddTicks(5160), null, null, new Guid("3c5b8e39-a8f8-4671-a573-2e1e5e8a6f85"), false, null, null },
                    { new Guid("ec24b9f6-6bd3-42f9-bf42-41c77caa36bb"), new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), "Undefined", new DateTime(2024, 11, 1, 13, 21, 52, 485, DateTimeKind.Utc).AddTicks(5140), null, null, new Guid("1328a6c8-9ebd-4b22-978a-453f0c31bbdf"), false, null, null },
                    { new Guid("fc8e85b1-7f89-47ee-9d72-03877626e305"), new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), "Undefined", new DateTime(2024, 11, 1, 13, 21, 52, 485, DateTimeKind.Utc).AddTicks(5165), null, null, new Guid("e6481d73-37e2-4b7e-a817-a7d0921797c6"), false, null, null }
                });
        }
    }
}
