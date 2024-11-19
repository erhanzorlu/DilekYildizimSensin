using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DilekYildizimSensin.Migrations
{
    /// <inheritdoc />
    public partial class deneme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"),
                column: "ConcurrencyStamp",
                value: "c65896ba-ab0b-4300-97e5-bf12c9cab97f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"),
                column: "ConcurrencyStamp",
                value: "c189722d-58dd-4283-9cc8-bd61ee3b0d74");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"),
                column: "ConcurrencyStamp",
                value: "8aab8acf-9f70-410e-b8d6-ee981b6faef3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e08d421e-2c12-4178-9b1f-f604a3cdc38f", "AQAAAAIAAYagAAAAECvcMJXhC8e24LLiZ85jQWgrYK6q5P+tXefPWDATfKyXEeF2nahKbVSZBB71J1KBZw==", "7da7b1f0-d798-4fef-acd4-5fe2b668e677" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5bdf3b72-62af-4d30-8bc8-0b6cf723ae57"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "de761018-44c6-49b1-8420-6887ca0a89f0", "8908c953-f479-42d5-9cba-c5f03999c956" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("99f21431-f75d-4b53-b0bc-c46a5a8db1a9"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a42c3226-0038-4ca0-951e-10863e21962e", "45ceffb3-582a-44ca-99ca-8ca0ac2763cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a5b6d3ea-7baa-49b8-808c-2d7d72f9c0d1"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4db3549b-fa60-4c06-bc81-e985f22f723a", "e72f1f51-8b61-4b8a-a0e0-74162e8c92fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c9a80a3a-f3af-439b-a4a3-985e65272a22"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1fefa080-01ff-47e0-9d6c-b885548ba6b2", "217a5218-e539-49e8-b206-213871b76559" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4cff066b-dc2f-4455-a192-3b1606c4d3f6", "AQAAAAIAAYagAAAAEPddRJvXpqxmqktt1vLbkDSyVCzH6ju6vBLNSN4ZcmaswyVCaFvNrLezeiEz83IPow==", "84f92292-76a9-4ddc-a3d4-ccb70dd9957c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e48db928-a5fc-4a9c-b72e-6373a453c6c7"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4753fad8-da55-4ba2-8fa7-b02a8e86804d", "37191ebb-5399-47ca-b245-e6b89d7d6ffc" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Gender", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Score", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("71216b21-b5dd-417f-96d5-e6bee5b33f6d"), 0, 26, "e9fa04ea-2c52-42d9-b198-39d62229662c", "zeynepkara@gmail.com", true, "Zeynep", 1, "image", "Kara", false, null, "ZEYNEPKARA@GMAIL.COM", "ZEYNEPKARA@GMAIL.COM", null, "+905439999987", false, 280, "a713e8f0-8db7-4abd-a9d0-9c634e61ca84", false, "zeynepkara" },
                    { new Guid("8515f6a5-2f62-4cc9-a084-9ac934553cbc"), 0, 32, "05ea50a4-0e2a-4478-adc6-18a856981359", "mehmetcan@gmail.com", true, "Mehmet", 2, "image", "Can", false, null, "MEHMETCAN@GMAIL.COM", "MEHMETCAN@GMAIL.COM", null, "+905439999986", true, 500, "7e0a96d0-a6a7-4e9f-8b0f-96cc423969df", false, "mehmetcan" },
                    { new Guid("8c01427b-4877-4513-b4bf-b5fa9093a279"), 0, 30, "7d608577-d0ae-49e7-acf1-28d45b1b4197", "mertturan@gmail.com", false, "Mert", 2, "image", "Turan", false, null, "MERTTURAN@GMAIL.COM", "MERTTURAN@GMAIL.COM", null, "+905439999988", true, 380, "09e1d221-443d-4922-b24b-a7bdbc94309b", false, "mertturan" },
                    { new Guid("c60543d1-ed62-495b-ae86-7038fcce59f1"), 0, 35, "51c50f3d-0792-4ff4-b5f0-1e3a3ee66f1e", "ahmetyilmaz@gmail.com", true, "Ahmet", 2, "image", "Yılmaz", false, null, "AHMETYILMAZ@GMAIL.COM", "AHMETYILMAZ@GMAIL.COM", null, "+905439999984", true, 420, "06be67b5-77b9-4777-8d60-f24cebd0fd79", false, "ahmetyilmaz" },
                    { new Guid("d2e3b435-8c7f-4905-bcde-223344556677"), 0, 28, "13d122a6-004a-48bd-b178-2f6408113a00", "aysegunes@gmail.com", false, "Ayşe", 1, "image", "Güneş", false, null, "AYSEGUNES@GMAIL.COM", "AYSEGUNES@GMAIL.COM", null, "+905439999985", false, 310, "6cabaa65-ebd0-44f2-b690-94f7b33c79af", false, "aysegunes" }
                });

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: new Guid("0299a520-25ca-49ec-9492-035ccf2ed5b8"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 19, 14, 43, 21, 86, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: new Guid("5d706d85-8780-43eb-9f0b-21f6d6ae9a07"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 19, 14, 43, 21, 86, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: new Guid("6296d6f2-052e-40fb-bf0b-72eb2ac34a6d"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 19, 14, 43, 21, 86, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: new Guid("820b74d4-c6f7-4823-a45e-6dbd41311212"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 19, 14, 43, 21, 86, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "Badges",
                keyColumn: "Id",
                keyValue: new Guid("8bf1da2f-a48e-4ecf-94a0-3b85e3cb32d2"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 19, 14, 43, 21, 86, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("1328a6c8-9ebd-4b22-978a-453f0c31bbdf"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 19, 11, 43, 21, 86, DateTimeKind.Utc).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("1e7bc8e4-59a8-4f63-af21-c7697a727f64"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 19, 11, 43, 21, 86, DateTimeKind.Utc).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("3c5b8e39-a8f8-4671-a573-2e1e5e8a6f85"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 19, 11, 43, 21, 86, DateTimeKind.Utc).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e6481d73-37e2-4b7e-a817-a7d0921797c6"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 19, 11, 43, 21, 86, DateTimeKind.Utc).AddTicks(3347));

            migrationBuilder.InsertData(
                table: "UserBadges",
                columns: new[] { "Id", "AppUserId", "BadgeId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("22cbb93f-305f-40ef-8a7f-fab91f0e1cfd"), new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), new Guid("0299a520-25ca-49ec-9492-035ccf2ed5b8"), "Undefined", new DateTime(2024, 11, 19, 14, 43, 21, 87, DateTimeKind.Local).AddTicks(3285), null, null, false, null, null },
                    { new Guid("2b2faa33-34c5-4d8e-99ee-69995946afe2"), new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), new Guid("0299a520-25ca-49ec-9492-035ccf2ed5b8"), "Undefined", new DateTime(2024, 11, 19, 14, 43, 21, 87, DateTimeKind.Local).AddTicks(3242), null, null, false, null, null },
                    { new Guid("443dff9c-e57a-4620-958a-22cee19ceca4"), new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), new Guid("820b74d4-c6f7-4823-a45e-6dbd41311212"), "Undefined", new DateTime(2024, 11, 19, 14, 43, 21, 87, DateTimeKind.Local).AddTicks(3276), null, null, false, null, null },
                    { new Guid("45b1b0d9-0f56-4dbc-848e-01e0bf1e6eb8"), new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), new Guid("5d706d85-8780-43eb-9f0b-21f6d6ae9a07"), "Undefined", new DateTime(2024, 11, 19, 14, 43, 21, 87, DateTimeKind.Local).AddTicks(3272), null, null, false, null, null },
                    { new Guid("fe9f94fb-2e73-4286-9c96-8a1a779c860a"), new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), new Guid("8bf1da2f-a48e-4ecf-94a0-3b85e3cb32d2"), "Undefined", new DateTime(2024, 11, 19, 14, 43, 21, 87, DateTimeKind.Local).AddTicks(3267), null, null, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "UserEvents",
                columns: new[] { "Id", "AppUserId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "EventDate", "EventId", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("0ff211cf-7b9d-4586-a28b-469cd66a9de1"), new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), "Undefined", new DateTime(2024, 11, 19, 11, 43, 21, 87, DateTimeKind.Utc).AddTicks(7020), null, null, new DateOnly(1, 1, 1), new Guid("1328a6c8-9ebd-4b22-978a-453f0c31bbdf"), false, null, null },
                    { new Guid("557e4039-f0e0-45d3-91e2-ca8ca4eff40d"), new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), "Undefined", new DateTime(2024, 11, 19, 11, 43, 21, 87, DateTimeKind.Utc).AddTicks(7045), null, null, new DateOnly(1, 1, 1), new Guid("e6481d73-37e2-4b7e-a817-a7d0921797c6"), false, null, null },
                    { new Guid("8b0439c6-767e-493a-8989-02de018a160e"), new Guid("5bdf3b72-62af-4d30-8bc8-0b6cf723ae57"), "Undefined", new DateTime(2024, 11, 19, 11, 43, 21, 87, DateTimeKind.Utc).AddTicks(7034), null, null, new DateOnly(1, 1, 1), new Guid("3c5b8e39-a8f8-4671-a573-2e1e5e8a6f85"), false, null, null },
                    { new Guid("b166f8af-5b20-4ae4-bfdb-312ebbfe4c12"), new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), "Undefined", new DateTime(2024, 11, 19, 11, 43, 21, 87, DateTimeKind.Utc).AddTicks(7027), null, null, new DateOnly(1, 1, 1), new Guid("1e7bc8e4-59a8-4f63-af21-c7697a727f64"), false, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("71216b21-b5dd-417f-96d5-e6bee5b33f6d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8515f6a5-2f62-4cc9-a084-9ac934553cbc"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8c01427b-4877-4513-b4bf-b5fa9093a279"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c60543d1-ed62-495b-ae86-7038fcce59f1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d2e3b435-8c7f-4905-bcde-223344556677"));

            migrationBuilder.DeleteData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: new Guid("22cbb93f-305f-40ef-8a7f-fab91f0e1cfd"));

            migrationBuilder.DeleteData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: new Guid("2b2faa33-34c5-4d8e-99ee-69995946afe2"));

            migrationBuilder.DeleteData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: new Guid("443dff9c-e57a-4620-958a-22cee19ceca4"));

            migrationBuilder.DeleteData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: new Guid("45b1b0d9-0f56-4dbc-848e-01e0bf1e6eb8"));

            migrationBuilder.DeleteData(
                table: "UserBadges",
                keyColumn: "Id",
                keyValue: new Guid("fe9f94fb-2e73-4286-9c96-8a1a779c860a"));

            migrationBuilder.DeleteData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: new Guid("0ff211cf-7b9d-4586-a28b-469cd66a9de1"));

            migrationBuilder.DeleteData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: new Guid("557e4039-f0e0-45d3-91e2-ca8ca4eff40d"));

            migrationBuilder.DeleteData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: new Guid("8b0439c6-767e-493a-8989-02de018a160e"));

            migrationBuilder.DeleteData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: new Guid("b166f8af-5b20-4ae4-bfdb-312ebbfe4c12"));

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
    }
}
