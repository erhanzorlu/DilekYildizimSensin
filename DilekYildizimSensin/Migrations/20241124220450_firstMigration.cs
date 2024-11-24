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
                    EventDate = table.Column<DateOnly>(type: "date", nullable: false),
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
                    { new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"), "a61070c9-7f82-4c02-b675-3f760f8b0465", "Superadmin", "SUPERADMIN" },
                    { new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"), "5964823b-111a-4f37-bd96-5c2b0f32aa95", "Admin", "ADMIN" },
                    { new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"), "2d0d5da6-b52a-4bb9-8060-675424998336", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Gender", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Score", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0e3785ad-4dc5-4689-b76b-1a320b7060fd"), 0, 27, "db713c7f-92eb-4b75-85c6-5db487909312", "seyda.muftuoglu@gmail.com", true, "Şeyda", 1, "image29", "Müftüoğlu", false, null, "SEYDAMUFTUOGLU@GMAIL.COM", "SEYDAMUFTUOGLU@GMAIL.COM", null, "+905439999929", false, 0, "b315a76e-dcea-4071-b4aa-2069da66d11e", false, "Şeyda Müftüoğlu" },
                    { new Guid("0ebd4e19-b9ae-427f-9da9-9e596b51dba1"), 0, 21, "c8766509-be36-47d6-aa91-b7fb20e96f35", "yagmur.ay@gmail.com", true, "Yağmur", 1, "image8", "Ay", false, null, "YAĞMURAY@GMAIL.COM", "YAĞMURAY@GMAIL.COM", null, "+905439999908", false, 0, "9dc7dcaf-10da-489e-be27-7ff46984a121", false, "Yağmur Ay" },
                    { new Guid("11a9b59d-dc02-49a9-aa6a-2091367ca508"), 0, 24, "97b91c5a-5fc4-4831-b582-2e0edb05de65", "melike.ozdil@gmail.com", true, "Melike", 1, "image26", "Özdil", false, null, "MELIKEOZDIL@GMAIL.COM", "MELIKEOZDIL@GMAIL.COM", null, "+905439999926", true, 0, "6d1a384b-ebbd-439d-9b83-fb17c2e7057f", false, "Melike Özdil" },
                    { new Guid("12cc6796-f791-411a-a07b-f84d7d19fa87"), 0, 26, "e53bbfdf-d40d-4327-a87c-490ee2d1049c", "aysenur.cetin@gmail.com", true, "Ayşe Nur", 1, "image27", "Çetin", false, null, "AYSENURCETIN@GMAIL.COM", "AYSENURCETIN@GMAIL.COM", null, "+905439999927", true, 0, "87aaab08-23f0-4859-ac93-c20413eabf6b", false, "Ayşe Nur Çetin" },
                    { new Guid("19bcb5f7-f0a9-4afc-a7dc-84b0318ffe94"), 0, 23, "0356e0aa-ae9a-4389-920d-cb5b936b5e96", "saliha.canigur@gmail.com", false, "Saliha", 1, "image12", "Canıgür", false, null, "SALIHACANIGUR@GMAIL.COM", "SALIHACANIGUR@GMAIL.COM", null, "+905439999912", false, 0, "5df52349-ac70-4ad2-a51a-4a7e03ca23f1", false, "Saliha Canıgür" },
                    { new Guid("1f670144-4fe2-41e0-b1f9-08c57f236d12"), 0, 22, "d85904ad-addc-4a63-b839-e449e8e113e1", "cem.aksu@gmail.com", false, "Cem", 2, "image2", "Aksu", false, null, "CEMAKSU@GMAIL.COM", "CEMAKSU@GMAIL.COM", null, "+905439999902", true, 0, "b0a99837-733b-4453-9cbe-125129c6ec64", false, "Cem Aksu" },
                    { new Guid("22a6b6a7-378f-4ccd-98b5-4ff50c0eded4"), 0, 28, "e06af06f-2916-4f73-aff8-dfa667eca8cb", "goksu.gokcesu@gmail.com", false, "Göksu", 1, "image30", "Gökçesu", false, null, "GOKSUGOKCESU@GMAIL.COM", "GOKSUGOKCESU@GMAIL.COM", null, "+905439999930", true, 0, "520e3668-6d3c-40cb-9e99-631c48a88da8", false, "Göksu Gökçesu" },
                    { new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 0, 30, "97cbc730-ab8a-4092-b127-de9eec4eeec9", "admin@gmail.com", false, "Admin", 2, "https://img.freepik.com/premium-photo/graphic-designer-digital-avatar-generative-ai_934475-9292.jpg", "User", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEO9+WE9JJAeZVumaZBXzj6+/yGuxaxqlkwe/G9ghoBfxkI0tQ8fyjlvxPbLDISkcVw==", "+905439999988", false, 123, "31043d6e-91b3-4562-8709-06af506455a9", false, "umutyasar" },
                    { new Guid("3ec39a24-aeb2-4b25-a3d8-1ef22d7596ba"), 0, 24, "08c9c077-15be-42ea-8dce-e9b2f7572fd2", "nora.ipekci@gmail.com", false, "Nora", 1, "image9", "İpekçi", false, null, "NORAİPEKÇİ@GMAIL.COM", "NORAİPEKÇİ@GMAIL.COM", null, "+905439999909", true, 0, "ee30e737-1361-4627-9585-004cad013f9e", false, "Nora İpekçi" },
                    { new Guid("45af5a4b-9130-4a13-8d64-f77a4a448db6"), 0, 30, "d170ac74-4ec7-469d-9029-881fa2f4009c", "ali.ozdemir@gmail.com", true, "Ali", 2, "image6", "Özdemir", false, null, "ALIÖZDEMIR@GMAIL.COM", "ALIÖZDEMIR@GMAIL.COM", null, "+905439999906", true, 0, "71c5c3d2-6e08-4962-b53d-166c839e376f", false, "Ali Özdemir" },
                    { new Guid("49e82f4a-07fe-4e7a-bed7-301120608ab5"), 0, 27, "b6f5a16f-8b02-41df-a26e-5f4d490ead85", "nergis.aktas@gmail.com", false, "Nergis", 1, "image24", "Aktaş", false, null, "NERGISAKTAS@GMAIL.COM", "NERGISAKTAS@GMAIL.COM", null, "+905439999924", true, 0, "4c8780f6-679a-44f6-b5ad-46a8abe10e83", false, "Nergis Aktaş" },
                    { new Guid("5697e24a-c74e-4ae4-b42f-f3dd94026c97"), 0, 27, "c43d1187-e0e2-49b8-ba82-ddd0ebf0ca22", "yasemin.kocaman@gmail.com", false, "Yasemin", 1, "image27", "Kocaman", false, null, "YASEMINKOCAMAN@GMAIL.COM", "YASEMINKOCAMAN@GMAIL.COM", null, "+905439999927", true, 0, "66b43c42-24b7-4b72-86b7-8c438e5a50c1", false, "Yasemin Kocaman" },
                    { new Guid("582e6492-05a7-4d74-ab66-c62bf3707343"), 0, 29, "828be24b-d332-4a74-8f54-cf4d227dcde4", "gunsu.berber@gmail.com", true, "Günsu", 1, "image25", "Berber", false, null, "GUNSUBERBER@GMAIL.COM", "GUNSUBERBER@GMAIL.COM", null, "+905439999925", false, 0, "e2161567-dc36-4181-83c5-327ce9f1a5aa", false, "Günsu Berber" },
                    { new Guid("6150eeb3-6e48-4d3a-8498-d9cb9227cf82"), 0, 26, "450c3469-2dd3-48dd-9e3b-477ae5a7dd2e", "nergis@gmail.com", false, "Nergis", 1, "image15", "Gül", false, null, "NERGIS@GMAIL.COM", "NERGIS@GMAIL.COM", null, "+905439999915", true, 0, "2829b8ba-c057-48c0-94e8-b14f93d52d03", false, "Nergis Gül" },
                    { new Guid("65b51ce5-cbe6-4032-abdd-48f52f590a87"), 0, 27, "22e74a40-ca91-4ecf-b76c-815a7b62046b", "ferit.erden@gmail.com", false, "Ferit", 2, "image14", "Erden", false, null, "FERITERDEN@GMAIL.COM", "FERITERDEN@GMAIL.COM", null, "+905439999914", false, 0, "a243838d-b043-4cec-bd96-dd9c64785aeb", false, "Ferit Erden" },
                    { new Guid("6b826486-0d5e-4677-9047-29fcd921f4b6"), 0, 26, "659ad8ae-be4d-4d0d-a98b-19d5d15a6900", "hazal.serkaya@gmail.com", true, "Hazal", 1, "image4", "Serkaya", false, null, "HAZALSERKAYA@GMAIL.COM", "HAZALSERKAYA@GMAIL.COM", null, "+905439999904", true, 0, "27eecfb2-7ef0-4108-8d4e-c86ef534dec4", false, "Hazal Serkaya" },
                    { new Guid("6ff336d8-d9a1-4ab2-9a53-4dcf16ef3501"), 0, 26, "20d43f67-67e9-4bfe-8d0a-579f502ede45", "hande.eren@gmail.com", true, "Hande", 1, "image23", "Eren", false, null, "HANDEREN@GMAIL.COM", "HANDEREN@GMAIL.COM", null, "+905439999923", false, 0, "2bdc954b-9fde-4171-9fe4-eafa0f6f7aed", false, "Hande Eren" },
                    { new Guid("74d3affe-7ebf-44d9-9b4f-cc97553831a0"), 0, 28, "77d55a7e-fc00-4d0e-ae91-2495a2b7ded0", "melike.ozdil@gmail.com", true, "Melike", 1, "image10", "Özdil", false, null, "MELIKEÖZDIL@GMAIL.COM", "MELIKEÖZDIL@GMAIL.COM", null, "+905439999910", false, 0, "a2d309b8-73da-4735-b7e5-fef9ad6e16b3", false, "Melike Özdil" },
                    { new Guid("7bdf942e-1fb7-43eb-9f7c-3e7406b0fada"), 0, 26, "23fca892-6992-4d96-923e-07ab12023333", "ozge.akar@gmail.com", true, "Özge", 1, "image18", "Akar", false, null, "OZGEAKAR@GMAIL.COM", "OZGEAKAR@GMAIL.COM", null, "+905439999918", true, 0, "6b315082-aaab-454c-9aae-ea28a76267c6", false, "Özge Akar" },
                    { new Guid("7c071165-69c8-417a-bfa1-3a31564f3043"), 0, 29, "13ff5445-7c20-4646-b3a4-9d64f4d6f486", "meltem.erkmen.kandil@gmail.com", true, "Meltem", 1, "image33", "Erkmen Kandil", false, null, "MELTEMERKMENKANDIL@GMAIL.COM", "MELTEMERKMENKANDIL@GMAIL.COM", null, "+905439999933", false, 0, "1b6b5793-a36b-438c-bc1f-f26468897cef", false, "Meltem Erkmen Kandil" },
                    { new Guid("8408122a-242b-4bd9-ae55-e14119623c8f"), 0, 25, "07c3b0d4-681b-4938-9389-587dc6c3c549", "rabia.canigur@gmail.com", false, "Rabia", 1, "image32", "Canıgür", false, null, "RABIACANIGUR@GMAIL.COM", "RABIACANIGUR@GMAIL.COM", null, "+905439999932", true, 0, "a58753a4-03a6-438d-bf96-a80cd6f89d2a", false, "Rabia Canıgür" },
                    { new Guid("849745c9-6502-42c6-83d9-e01503087ce7"), 0, 24, "545f34b3-75b6-4189-af5a-07317880675f", "irem.keles@gmail.com", true, "İrem", 1, "image3", "Keleş", false, null, "IREMKELES@GMAIL.COM", "IREMKELES@GMAIL.COM", null, "+905439999903", true, 0, "16282c61-bb25-49a6-b3fb-59a9b440a968", false, "İrem Keleş" },
                    { new Guid("9375907f-a7a7-410d-8f6a-6daacefbe652"), 0, 30, "602b50e0-2f08-41ab-b469-cede37fd5ae5", "ahmet.deniz@gmail.com", true, "Ahmet", 2, "image34", "Deniz", false, null, "AHMETDENIZ@GMAIL.COM", "AHMETDENIZ@GMAIL.COM", null, "+905439999934", true, 0, "a31a2f28-a1f0-4fd3-af82-193eb101f8f1", false, "Ahmet Deniz" },
                    { new Guid("939ee55c-fc2e-4933-8962-6c3bb304bf85"), 0, 28, "abf24ecd-180d-4059-b357-f4618a8494ec", "gokhan.sahin@gmail.com", false, "Gökhan", 2, "image17", "Şahin", false, null, "GOKHANSHAHIN@GMAIL.COM", "GOKHANSHAHIN@GMAIL.COM", null, "+905439999917", false, 0, "bd2c3217-b311-4a59-b09b-18ff4b122897", false, "Gökhan Şahin" },
                    { new Guid("94c9b109-deb4-471e-b6ff-65d2d5e980da"), 0, 31, "cc54ef70-5a87-480a-a419-936b362ced2a", "huseyin.adas@gmail.com", true, "Hüseyin", 2, "image13", "Adaş", false, null, "HUSEYINADAS@GMAIL.COM", "HUSEYINADAS@GMAIL.COM", null, "+905439999913", true, 0, "f4402d98-f6b5-4ae3-b625-dfe0a5a5220e", false, "Hüseyin Adaş" },
                    { new Guid("9957b612-0b43-4ab5-a399-32f49c66d876"), 0, 22, "020f8c69-188c-4a9f-9f6f-ecfdb834859d", "melisa.ertan@gmail.com", true, "Melisa", 1, "image20", "Ertan", false, null, "MELISAERTAN@GMAIL.COM", "MELISAERTAN@GMAIL.COM", null, "+905439999920", false, 0, "f5dfb12e-8c8d-4445-a1a0-c590626b4511", false, "Melisa Ertan" },
                    { new Guid("a4d04fd8-7b8f-4220-bf72-60aa7f09a547"), 0, 29, "54bdd17a-fef7-4841-b4c3-01045a915914", "alper.goksel.yilmaz@gmail.com", true, "Alper Göksel", 2, "image11", "Yılmaz", false, null, "ALPERGOKSELYILMAZ@GMAIL.COM", "ALPERGOKSELYILMAZ@GMAIL.COM", null, "+905439999911", true, 0, "7ebf39b4-5a83-4a71-9f40-c176efc2b260", false, "Alper Göksel Yılmaz" },
                    { new Guid("a4dcd042-a5c7-495c-9efb-fc9dcef52a38"), 0, 27, "373f6f6c-b538-497a-969b-c981e88c172a", "erhan.zorlu@gmail.com", false, "Erhan", 2, "image7", "Zorlu", false, null, "ERHANZORLU@GMAIL.COM", "ERHANZORLU@GMAIL.COM", null, "+905439999907", true, 0, "ac6ef185-1c0e-4915-8f49-4e24a92cd5a3", false, "Erhan Zorlu" },
                    { new Guid("a93fcf02-abb6-424a-81bf-7d4ea1f51230"), 0, 23, "8c635889-7254-42c7-ba6b-052d18264450", "zeynep.sena.celik@gmail.com", true, "Zeynep Sena", 1, "image5", "Çelik", false, null, "ZEYNEPSENACELIK@GMAIL.COM", "ZEYNEPSENACELIK@GMAIL.COM", null, "+905439999905", false, 0, "e5b13bcc-b7e4-4c56-ac83-733588f2431b", false, "Zeynep Sena Çelik" },
                    { new Guid("aa795eb0-f881-4546-adef-4933362c2cc4"), 0, 26, "3fa7e360-13c2-413a-8e36-847d1022b404", "sevval.vural@gmail.com", true, "Şevval", 1, "image31", "Vural", false, null, "SEVVALVURAL@GMAIL.COM", "SEVVALVURAL@GMAIL.COM", null, "+905439999931", true, 0, "e3330a2c-9ce1-44fb-a34d-d0b752bb97ca", false, "Şevval Vural" },
                    { new Guid("ca728bbe-06d9-4348-896a-f1ce1f4a4426"), 0, 30, "102b6b11-673d-460b-8df7-db7ec117f222", "filiz.cetin.narsap@gmail.com", true, "Filiz", 1, "image22", "Çetin Narşap", false, null, "FILIZCETINNARSAP@GMAIL.COM", "FILIZCETINNARSAP@GMAIL.COM", null, "+905439999922", true, 0, "49f73c3b-903e-4f97-a572-e6a51e164cb6", false, "Filiz Çetin Narşap" },
                    { new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 0, 25, "3a46267e-6aa5-4e06-8782-7085402dde0f", "superadmin@gmail.com", true, "Admin", 2, "https://static.vecteezy.com/system/resources/previews/024/183/525/non_2x/avatar-of-a-man-portrait-of-a-young-guy-illustration-of-male-character-in-modern-color-style-vector.jpg", "Bey", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEDiOimDmXShE+zvW3VMREiCvUuYZFfU1poi41jWYkkp9cIAq9uyEvhbcp5HZ1T1x6w==", "+905439999999", true, 520, "a28208e1-6d7c-4022-94d1-1ef467a48055", false, "Admin" },
                    { new Guid("d90fdf18-0380-4b05-aca4-e13fa3b25b69"), 0, 28, "eaa09efa-f104-413e-99a8-710fdd77e2f5", "armagan.yagci@gmail.com", true, "Armağan", 2, "image21", "Yağcı", false, null, "ARMAGANYAGCI@GMAIL.COM", "ARMAGANYAGCI@GMAIL.COM", null, "+905439999921", true, 0, "ae218b0c-8958-443a-9213-b82316f89c96", false, "Armağan Yağcı" },
                    { new Guid("e0b6e331-7b6d-4136-9999-e838f4fbdaac"), 0, 25, "9625cc35-58e3-4676-aeb2-fbf0918702a7", "ruken.yavuz@gmail.com", true, "Ruken", 1, "image1", "Yavuz", false, null, "RUKENYAVUZ@GMAIL.COM", "RUKENYAVUZ@GMAIL.COM", null, "+905439999901", true, 0, "96daa1f0-5837-4b5f-b131-84e4f1d1aff0", false, "Ruken Yavuz" },
                    { new Guid("e8dfbd8d-8e31-4bed-81cb-97f4f33872f6"), 0, 31, "d7c547fd-058a-4cc2-b4fa-24f7fe67157d", "muhsin.cetinkaya@gmail.com", false, "Muhsin", 2, "image35", "Çetinkaya", false, null, "MUHSINCETINKAYA@GMAIL.COM", "MUHSINCETINKAYA@GMAIL.COM", null, "+905439999935", false, 0, "03f66acd-5a65-41e0-8bb0-e33b2a0250b5", false, "Muhsin Çetinkaya" },
                    { new Guid("e8f88afd-2af4-4663-927e-bbf95e60d384"), 0, 24, "a88b8c2e-34ef-4335-9688-fdfbd1b67d81", "ilayda.celebi@gmail.com", false, "İlayda", 1, "image16", "Çelebi", false, null, "ILAYDACELEBI@GMAIL.COM", "ILAYDACELEBI@GMAIL.COM", null, "+905439999916", true, 0, "b8d73203-6083-4105-abfd-dd906ca10a29", false, "İlayda Çelebi" },
                    { new Guid("e9bf81e4-d8ab-464c-9252-27d784cd7dae"), 0, 27, "ebbe9e2e-8982-46c6-9295-86e67e621202", "ipek.gurdamar@gmail.com", true, "İpek", 1, "image19", "Gürdamar", false, null, "IPEKGURDAMAR@GMAIL.COM", "IPEKGURDAMAR@GMAIL.COM", null, "+905439999919", true, 0, "94f47b6e-3cee-4db7-ad6b-2d4292486ff5", false, "İpek Gürdamar" }
                });

            migrationBuilder.InsertData(
                table: "Badges",
                columns: new[] { "Id", "BadgeIcon", "BadgeName", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("0299a520-25ca-49ec-9492-035ccf2ed5b8"), "https://w7.pngwing.com/pngs/423/1004/png-transparent-medal-gold-winner-badge-achievement-reward-army-champion-awards-icon.png", "Karda Yürüyen", "Undefined", new DateTime(2024, 11, 25, 1, 4, 48, 995, DateTimeKind.Local).AddTicks(4406), null, null, false, null, null },
                    { new Guid("5d706d85-8780-43eb-9f0b-21f6d6ae9a07"), "https://www.shutterstock.com/image-vector/transparent-winner-icon-png-vector-260nw-1945885621.jpg", "Yüce Gönüllü", "Undefined", new DateTime(2024, 11, 25, 1, 4, 48, 995, DateTimeKind.Local).AddTicks(4485), null, null, false, null, null },
                    { new Guid("6296d6f2-052e-40fb-bf0b-72eb2ac34a6d"), "https://static.vecteezy.com/system/resources/previews/014/606/031/original/golden-yellow-trophy-icon-for-the-winner-of-a-sports-event-png.png", "Sosyal Kelebek", "Undefined", new DateTime(2024, 11, 25, 1, 4, 48, 995, DateTimeKind.Local).AddTicks(4470), null, null, false, null, null },
                    { new Guid("820b74d4-c6f7-4823-a45e-6dbd41311212"), "https://e7.pngegg.com/pngimages/1002/183/png-clipart-smiley-smiley-miscellaneous-smiley.png", "Gülen Yüz", "Undefined", new DateTime(2024, 11, 25, 1, 4, 48, 995, DateTimeKind.Local).AddTicks(4478), null, null, false, null, null },
                    { new Guid("8bf1da2f-a48e-4ecf-94a0-3b85e3cb32d2"), "https://img.lovepik.com/png/20231009/Outstanding-color-male-employees-of-the-month-staff-the-company_136776_wh860.png", "Ayın Elemanı", "Undefined", new DateTime(2024, 11, 25, 1, 4, 48, 995, DateTimeKind.Local).AddTicks(4491), null, null, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "EventName", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("1328a6c8-9ebd-4b22-978a-453f0c31bbdf"), "Undefined", new DateTime(2024, 11, 24, 22, 4, 48, 995, DateTimeKind.Utc).AddTicks(6460), null, null, "Ofis Etkinliği", false, null, null },
                    { new Guid("1e7bc8e4-59a8-4f63-af21-c7697a727f64"), "Undefined", new DateTime(2024, 11, 24, 22, 4, 48, 995, DateTimeKind.Utc).AddTicks(6466), null, null, "Dilek Alma Etkinliği", false, null, null },
                    { new Guid("3c5b8e39-a8f8-4671-a573-2e1e5e8a6f85"), "Undefined", new DateTime(2024, 11, 24, 22, 4, 48, 995, DateTimeKind.Utc).AddTicks(6468), null, null, "Dilek Gerçekleştirme Etkinliği", false, null, null },
                    { new Guid("e6481d73-37e2-4b7e-a817-a7d0921797c6"), "Undefined", new DateTime(2024, 11, 24, 22, 4, 48, 995, DateTimeKind.Utc).AddTicks(6471), null, null, "Stant Etkinliği", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"), new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"), new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") }
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
