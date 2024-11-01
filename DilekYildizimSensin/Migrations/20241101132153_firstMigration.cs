using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DilekYildizimSensin.Migrations
{
    /// <inheritdoc />
    public partial class firstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Badges",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BadgeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BadgeIcon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Badges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VolunteerScores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolunteerScores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VolunteerScores_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserBadges",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BadgeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBadges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserBadges_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserBadges_Badges_BadgeId",
                        column: x => x.BadgeId,
                        principalTable: "Badges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserEvents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEvents_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEvents_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"), "1347112e-35ef-4755-a20e-26afa666cae8", "Superadmin", "SUPERADMIN" },
                    { new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"), "a6fedf89-4dd6-4eb0-8c20-fde2dc7bf69f", "Admin", "ADMIN" },
                    { new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"), "46c061a7-3a3d-4546-a8a0-d0c6dc2a1f99", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Gender", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Score", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 0, 30, "458c2473-23cc-425d-93b1-6277c12081a6", "admin@gmail.com", false, "Admin", 2, "https://img.freepik.com/premium-photo/graphic-designer-digital-avatar-generative-ai_934475-9292.jpg", "User", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEIzFGgQcxrlLbUpxmooMHWPAmPto1gqQIH1fpn71sPc0wTwWtfjYNBzAIFTYRR5/wQ==", "+905439999988", false, 123, "d81f158f-101d-4bdb-bf5a-9afa5cc73b6a", false, "umutyasar" },
                    { new Guid("5bdf3b72-62af-4d30-8bc8-0b6cf723ae57"), 0, 22, "56cb57d1-d07a-4417-8a93-a04c7c4eb783", "ahmetyildiz@gmail.com", false, "Ahmet", 2, "image", "Yildiz", false, null, "AHMETYILDIZ@GMAIL.COM", "AHMETYILDIZ@GMAIL.COM", null, "+905439999987", false, 320, "f5e8d43c-8c59-4406-84f5-1b23e839cc78", false, "ahmetyildiz" },
                    { new Guid("99f21431-f75d-4b53-b0bc-c46a5a8db1a9"), 0, 29, "2ce8f44f-3bf9-44af-af21-a757a4240818", "elifdemir@gmail.com", false, "Elif", 1, "image", "Demir", false, null, "ELIFDEMIR@GMAIL.COM", "ELIFDEMIR@GMAIL.COM", null, "+905439999983", false, 340, "7916ae57-1d4a-448d-abbe-336c71e49201", false, "elifdemir" },
                    { new Guid("a5b6d3ea-7baa-49b8-808c-2d7d72f9c0d1"), 0, 35, "b140f918-56f6-4ced-91d0-74140c848bb5", "cemakyildiz@gmail.com", false, "Cem", 2, "image", "Akyildiz", false, null, "CEMAKYILDIZ@GMAIL.COM", "CEMAKYILDIZ@GMAIL.COM", null, "+905439999985", false, 30, "56d1683e-3fdb-466c-9162-1350d6bb3680", false, "cemakyildiz" },
                    { new Guid("c9a80a3a-f3af-439b-a4a3-985e65272a22"), 0, 19, "a93b9764-45f9-48b8-bb1d-4274076e0d7e", "melisekinci@gmail.com", false, "Melis", 1, "image", "Ekinci", false, null, "MELISEKINCI@GMAIL.COM", "MELISEKINCI@GMAIL.COM", null, "+905439999986", false, 450, "73f46d41-4d14-4c6b-bde0-caa4ffa5517d", false, "melisekinci" },
                    { new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 0, 25, "2f9c987d-0dba-472b-8199-dd005cd9730c", "superadmin@gmail.com", true, "Erhan", 2, "https://static.vecteezy.com/system/resources/previews/024/183/525/non_2x/avatar-of-a-man-portrait-of-a-young-guy-illustration-of-male-character-in-modern-color-style-vector.jpg", "Zorlu", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEH/uGZkPKmZlWa6ZgRtijLOVfJSU+vs6MRuMAyMjY5D2aP2/IggLQXy2d82xFbTsRA==", "+905439999999", true, 520, "1243dba8-5d3c-4e97-8130-eb7cb65769e3", false, "erhanzorlu" },
                    { new Guid("e48db928-a5fc-4a9c-b72e-6373a453c6c7"), 0, 23, "381abd04-5e62-4536-bd70-f84cd6a3d981", "serdarkaya@gmail.com", false, "Serdar", 1, "image", "Kaya", false, null, "SERDARKAYA@GMAIL.COM", "SERDARKAYA@GMAIL.COM", null, "+905439999984", false, 390, "ee9b2005-b24d-4052-a550-3811bfbd0245", false, "serdarkaya" }
                });

            migrationBuilder.InsertData(
                table: "Badges",
                columns: new[] { "Id", "BadgeIcon", "BadgeName", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("0299a520-25ca-49ec-9492-035ccf2ed5b8"), "https://w7.pngwing.com/pngs/423/1004/png-transparent-medal-gold-winner-badge-achievement-reward-army-champion-awards-icon.png", "Karda Yürüyen", "Undefined", new DateTime(2024, 11, 1, 16, 21, 52, 482, DateTimeKind.Local).AddTicks(8920), null, null, false, null, null },
                    { new Guid("5d706d85-8780-43eb-9f0b-21f6d6ae9a07"), "https://www.shutterstock.com/image-vector/transparent-winner-icon-png-vector-260nw-1945885621.jpg", "Yüce Gönüllü", "Undefined", new DateTime(2024, 11, 1, 16, 21, 52, 482, DateTimeKind.Local).AddTicks(9003), null, null, false, null, null },
                    { new Guid("6296d6f2-052e-40fb-bf0b-72eb2ac34a6d"), "https://static.vecteezy.com/system/resources/previews/014/606/031/original/golden-yellow-trophy-icon-for-the-winner-of-a-sports-event-png.png", "Sosyal Kelebek", "Undefined", new DateTime(2024, 11, 1, 16, 21, 52, 482, DateTimeKind.Local).AddTicks(8988), null, null, false, null, null },
                    { new Guid("820b74d4-c6f7-4823-a45e-6dbd41311212"), "https://e7.pngegg.com/pngimages/1002/183/png-clipart-smiley-smiley-miscellaneous-smiley.png", "Gülen Yüz", "Undefined", new DateTime(2024, 11, 1, 16, 21, 52, 482, DateTimeKind.Local).AddTicks(8996), null, null, false, null, null },
                    { new Guid("8bf1da2f-a48e-4ecf-94a0-3b85e3cb32d2"), "https://img.lovepik.com/png/20231009/Outstanding-color-male-employees-of-the-month-staff-the-company_136776_wh860.png", "Ayın Elemanı", "Undefined", new DateTime(2024, 11, 1, 16, 21, 52, 482, DateTimeKind.Local).AddTicks(9010), null, null, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "EventName", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("1328a6c8-9ebd-4b22-978a-453f0c31bbdf"), "Undefined", new DateTime(2024, 11, 1, 13, 21, 52, 483, DateTimeKind.Utc).AddTicks(805), null, null, "Ofis Etkinliği", false, null, null },
                    { new Guid("1e7bc8e4-59a8-4f63-af21-c7697a727f64"), "Undefined", new DateTime(2024, 11, 1, 13, 21, 52, 483, DateTimeKind.Utc).AddTicks(824), null, null, "Dilek Alma Etkinliği", false, null, null },
                    { new Guid("3c5b8e39-a8f8-4671-a573-2e1e5e8a6f85"), "Undefined", new DateTime(2024, 11, 1, 13, 21, 52, 483, DateTimeKind.Utc).AddTicks(827), null, null, "Dilek Gerçekleştirme Etkinliği", false, null, null },
                    { new Guid("e6481d73-37e2-4b7e-a817-a7d0921797c6"), "Undefined", new DateTime(2024, 11, 1, 13, 21, 52, 483, DateTimeKind.Utc).AddTicks(830), null, null, "Stant Etkinliği", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"), new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"), new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserBadges_AppUserId",
                table: "UserBadges",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBadges_BadgeId",
                table: "UserBadges",
                column: "BadgeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvents_AppUserId",
                table: "UserEvents",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvents_EventId",
                table: "UserEvents",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerScores_AppUserId",
                table: "VolunteerScores",
                column: "AppUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "UserBadges");

            migrationBuilder.DropTable(
                name: "UserEvents");

            migrationBuilder.DropTable(
                name: "VolunteerScores");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Badges");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
