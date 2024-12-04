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
                    Year = table.Column<int>(type: "int", nullable: true),
                    Month = table.Column<int>(type: "int", nullable: true),
                    Score = table.Column<int>(type: "int", nullable: true),
                    EventId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EventDate = table.Column<DateOnly>(type: "date", nullable: true),
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
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"), "41b3c4d4-ad03-4b59-b3ce-ecffdfba8e3c", "Superadmin", "SUPERADMIN" },
                    { new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"), "3b8bbb35-1b51-40a9-812b-f86f82354ee0", "Admin", "ADMIN" },
                    { new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"), "1d09c78b-ec20-4bda-b0f2-ad9b4f3a660c", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Gender", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Score", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("09f35bdb-09d8-42c5-8473-e86bb8adfedc"), 0, 30, "3e7901f8-4e00-4be8-9e55-6daf0c600830", "ali.ozdemir@gmail.com", true, "Ali", 2, "image6", "Özdemir", false, null, "ALIÖZDEMIR@GMAIL.COM", "ALIÖZDEMIR@GMAIL.COM", null, "+905439999906", true, 0, "9568d76f-c2a2-4a87-9aa8-5721eddd6067", false, "Ali Özdemir" },
                    { new Guid("0b9dfd38-9960-4ec1-8245-7165692527e5"), 0, 25, "e32d776f-d3e4-4020-bfd7-68edec4ccb74", "ruken.yavuz@gmail.com", true, "Ruken", 1, "image1", "Yavuz", false, null, "RUKENYAVUZ@GMAIL.COM", "RUKENYAVUZ@GMAIL.COM", null, "+905439999901", true, 0, "135ed3e5-81a9-4966-b19c-6a29f395c8c4", false, "Ruken Yavuz" },
                    { new Guid("277c3b4a-0e6a-4444-aa0f-2808bb42a812"), 0, 23, "02966bbe-e05d-4fbf-8ff3-03ea5e544d0e", "zeynep.sena.celik@gmail.com", true, "Zeynep Sena", 1, "image5", "Çelik", false, null, "ZEYNEPSENACELIK@GMAIL.COM", "ZEYNEPSENACELIK@GMAIL.COM", null, "+905439999905", false, 0, "700d58b1-65a1-4cb7-bc85-b656b9274630", false, "Zeynep Sena Çelik" },
                    { new Guid("29a11b04-e0f8-4889-b95a-dd0057c1af00"), 0, 22, "44cad055-d920-4dfb-85d5-e64b0240732f", "melisa.ertan@gmail.com", true, "Melisa", 1, "image20", "Ertan", false, null, "MELISAERTAN@GMAIL.COM", "MELISAERTAN@GMAIL.COM", null, "+905439999920", false, 0, "ece65c9f-c207-4c34-8763-1f2cf2473bb7", false, "Melisa Ertan" },
                    { new Guid("2eba054d-66ff-40ec-bffe-c0b6e8e6ad4e"), 0, 24, "3a485475-89c8-41ec-9b7d-2ccb847892df", "ilayda.celebi@gmail.com", false, "İlayda", 1, "image16", "Çelebi", false, null, "ILAYDACELEBI@GMAIL.COM", "ILAYDACELEBI@GMAIL.COM", null, "+905439999916", true, 0, "3d61e6bc-f711-44b6-97af-52484b0cd5da", false, "İlayda Çelebi" },
                    { new Guid("31213e0b-3533-4005-93c1-5d757e4f2449"), 0, 26, "325afce6-6bc7-4267-9d46-fd71320ad7a7", "nergis@gmail.com", false, "Nergis", 1, "image15", "Gül", false, null, "NERGIS@GMAIL.COM", "NERGIS@GMAIL.COM", null, "+905439999915", true, 0, "43b4c408-f905-4ffc-9a54-3a24460cdf82", false, "Nergis Gül" },
                    { new Guid("341e9302-2bc2-42fe-8bb9-43bf87b4ee9a"), 0, 27, "b5993f54-533e-4061-97d0-4d410b8dbe65", "ipek.gurdamar@gmail.com", true, "İpek", 1, "image19", "Gürdamar", false, null, "IPEKGURDAMAR@GMAIL.COM", "IPEKGURDAMAR@GMAIL.COM", null, "+905439999919", true, 0, "1eeb2970-1cd8-4b5b-9977-30e2dae19560", false, "İpek Gürdamar" },
                    { new Guid("38aadb5e-ae48-4767-860c-fc588ebe9cbf"), 0, 29, "0d48f187-8197-46b7-975d-362404faef1c", "gunsu.berber@gmail.com", true, "Günsu", 1, "image25", "Berber", false, null, "GUNSUBERBER@GMAIL.COM", "GUNSUBERBER@GMAIL.COM", null, "+905439999925", false, 0, "3416458e-74c2-4089-83d2-17dad7fa7481", false, "Günsu Berber" },
                    { new Guid("38f0a05c-47a7-42f7-b164-252b0113a1d7"), 0, 26, "00b516df-384a-4e00-b5ce-67d3bf95bd98", "sevval.vural@gmail.com", true, "Şevval", 1, "image31", "Vural", false, null, "SEVVALVURAL@GMAIL.COM", "SEVVALVURAL@GMAIL.COM", null, "+905439999931", true, 0, "ae29b0ee-0d61-4a2a-8a18-9df3b2aca8b7", false, "Şevval Vural" },
                    { new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 0, 30, "73ee2cc9-bc7c-442b-b685-dd4ac3f8e94e", "admin@gmail.com", false, "Admin", 2, "https://img.freepik.com/premium-photo/graphic-designer-digital-avatar-generative-ai_934475-9292.jpg", "User", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAECRGfBhDxmMk4Q+XDpGG4SjdgjoqZTkWWgmuwUgokvM2Rp37k9G6hUvpgfmdPv7ZgA==", "+905439999988", false, 123, "17d70f2d-dbc7-4fbe-99c3-5592372021fd", false, "umutyasar" },
                    { new Guid("4f6110c3-66f6-4d55-acd6-02d4023b8245"), 0, 28, "304684fb-34ed-4af6-81b5-089201a339e5", "gokhan.sahin@gmail.com", false, "Gökhan", 2, "image17", "Şahin", false, null, "GOKHANSHAHIN@GMAIL.COM", "GOKHANSHAHIN@GMAIL.COM", null, "+905439999917", false, 0, "586fe7b1-56e4-4f58-a290-c170b5670e9a", false, "Gökhan Şahin" },
                    { new Guid("64e2f360-dfcd-4cd7-9ac0-3215e94a9ca6"), 0, 21, "51fe7f2c-b724-40ab-857a-6cb4f8d1fa78", "yagmur.ay@gmail.com", true, "Yağmur", 1, "image8", "Ay", false, null, "YAĞMURAY@GMAIL.COM", "YAĞMURAY@GMAIL.COM", null, "+905439999908", false, 0, "41848046-ed2e-4cd3-8b3c-a0f07bda16f2", false, "Yağmur Ay" },
                    { new Guid("6b78a99d-08a8-4b51-8c19-f6d2ffeca8a2"), 0, 25, "dad5a302-db85-43b0-99ad-564d9ea911f4", "rabia.canigur@gmail.com", false, "Rabia", 1, "image32", "Canıgür", false, null, "RABIACANIGUR@GMAIL.COM", "RABIACANIGUR@GMAIL.COM", null, "+905439999932", true, 0, "c28e1547-a134-48d7-83ac-48520d245e38", false, "Rabia Canıgür" },
                    { new Guid("6ea93f14-eb3d-4e4c-bcd9-e000fdebdc36"), 0, 27, "6e9f604c-34e0-4d1a-84a2-6da3064c9a75", "ferit.erden@gmail.com", false, "Ferit", 2, "image14", "Erden", false, null, "FERITERDEN@GMAIL.COM", "FERITERDEN@GMAIL.COM", null, "+905439999914", false, 0, "290e4b45-e234-4fac-8398-cff306e0024a", false, "Ferit Erden" },
                    { new Guid("82190efd-135e-429a-b06f-b2f38aeaa967"), 0, 24, "2d283a9d-041e-41aa-a3d4-1dc1866dac18", "irem.keles@gmail.com", true, "İrem", 1, "image3", "Keleş", false, null, "IREMKELES@GMAIL.COM", "IREMKELES@GMAIL.COM", null, "+905439999903", true, 0, "b72d486f-be34-4f5a-9c67-17d39aaa1dd6", false, "İrem Keleş" },
                    { new Guid("8ea6301f-beab-4d38-bbc4-fd7ae6f9ade9"), 0, 26, "054b2584-8cbd-4d7a-9aef-047972b7b081", "aysenur.cetin@gmail.com", true, "Ayşe Nur", 1, "image27", "Çetin", false, null, "AYSENURCETIN@GMAIL.COM", "AYSENURCETIN@GMAIL.COM", null, "+905439999927", true, 0, "922e3145-d0dd-4812-8d45-510245b61499", false, "Ayşe Nur Çetin" },
                    { new Guid("9858145e-80cf-4f6c-b8c8-985fbda5e0e9"), 0, 22, "21f628e2-4c49-469d-8f8b-a2dcc876a808", "cem.aksu@gmail.com", false, "Cem", 2, "image2", "Aksu", false, null, "CEMAKSU@GMAIL.COM", "CEMAKSU@GMAIL.COM", null, "+905439999902", true, 0, "b20fc5f6-a98a-40b0-b9e4-3562f610dc1d", false, "Cem Aksu" },
                    { new Guid("9a2b8d91-d4fb-4ab0-9d16-9b6685c587f3"), 0, 24, "74737df6-f5dc-4e07-b735-83a6e6b8a459", "nora.ipekci@gmail.com", false, "Nora", 1, "image9", "İpekçi", false, null, "NORAİPEKÇİ@GMAIL.COM", "NORAİPEKÇİ@GMAIL.COM", null, "+905439999909", true, 0, "4b12a521-73d5-4880-9d7f-2fec93eeaf7f", false, "Nora İpekçi" },
                    { new Guid("9ba2bf72-337a-405f-b394-e8c58e50944e"), 0, 31, "1160e345-7788-4a51-a786-4364332e7676", "huseyin.adas@gmail.com", true, "Hüseyin", 2, "image13", "Adaş", false, null, "HUSEYINADAS@GMAIL.COM", "HUSEYINADAS@GMAIL.COM", null, "+905439999913", true, 0, "eb2ec9ad-072c-4017-bb2e-c156c334ec70", false, "Hüseyin Adaş" },
                    { new Guid("a71c8d7f-0e8b-4caf-bdb9-a3544aa29632"), 0, 30, "9e2a70bb-95d9-4526-916f-6ab611d0875f", "ahmet.deniz@gmail.com", true, "Ahmet", 2, "image34", "Deniz", false, null, "AHMETDENIZ@GMAIL.COM", "AHMETDENIZ@GMAIL.COM", null, "+905439999934", true, 0, "79f8c7ef-e34a-4d38-ac58-1f2c8e3d59b0", false, "Ahmet Deniz" },
                    { new Guid("b3a59855-0881-426d-87d8-55a7bb58e1ea"), 0, 26, "000c1560-511a-4d85-9571-e471f58ba645", "ozge.akar@gmail.com", true, "Özge", 1, "image18", "Akar", false, null, "OZGEAKAR@GMAIL.COM", "OZGEAKAR@GMAIL.COM", null, "+905439999918", true, 0, "7651473f-a781-4acf-b7c0-f145fe928c61", false, "Özge Akar" },
                    { new Guid("bc550a9d-ba43-4f0f-ad63-e98af815f60b"), 0, 27, "51df646b-4992-4cce-926c-7b786e315056", "yasemin.kocaman@gmail.com", false, "Yasemin", 1, "image27", "Kocaman", false, null, "YASEMINKOCAMAN@GMAIL.COM", "YASEMINKOCAMAN@GMAIL.COM", null, "+905439999927", true, 0, "ecb92b47-2aa2-420a-b28b-9cd8430b3cc6", false, "Yasemin Kocaman" },
                    { new Guid("bdbb92b8-b209-474b-a7bf-ecdc97c6af1f"), 0, 27, "9f914d3f-9184-4b90-843f-aee132095007", "nergis.aktas@gmail.com", false, "Nergis", 1, "image24", "Aktaş", false, null, "NERGISAKTAS@GMAIL.COM", "NERGISAKTAS@GMAIL.COM", null, "+905439999924", true, 0, "d1f0ec5d-bcb9-42fa-8491-425142373be7", false, "Nergis Aktaş" },
                    { new Guid("c0760813-3564-4ef6-9717-e58b6cbefe60"), 0, 28, "fc714ee9-6798-4c77-a2d6-1e90011a92f8", "armagan.yagci@gmail.com", true, "Armağan", 2, "image21", "Yağcı", false, null, "ARMAGANYAGCI@GMAIL.COM", "ARMAGANYAGCI@GMAIL.COM", null, "+905439999921", true, 0, "6f939787-eb60-4168-8122-2930276ed91b", false, "Armağan Yağcı" },
                    { new Guid("c2ab9e99-41ce-4018-9a61-0cf96fa9fd0b"), 0, 23, "5da8490c-19be-4dd1-b924-d9376ddee9df", "saliha.canigur@gmail.com", false, "Saliha", 1, "image12", "Canıgür", false, null, "SALIHACANIGUR@GMAIL.COM", "SALIHACANIGUR@GMAIL.COM", null, "+905439999912", false, 0, "2c121931-8887-43d8-b83e-9b33c6be0c7d", false, "Saliha Canıgür" },
                    { new Guid("c4b121e3-a9b1-45b2-9e5c-de28c8384d3f"), 0, 29, "aa55da65-23fa-4766-9356-d67dab3b6644", "meltem.erkmen.kandil@gmail.com", true, "Meltem", 1, "image33", "Erkmen Kandil", false, null, "MELTEMERKMENKANDIL@GMAIL.COM", "MELTEMERKMENKANDIL@GMAIL.COM", null, "+905439999933", false, 0, "e5c89ca4-6afb-4cee-9bbe-cf7d17dbe165", false, "Meltem Erkmen Kandil" },
                    { new Guid("c5270761-cdb3-4602-8370-23c0233c65aa"), 0, 27, "87d17ef4-7c37-4a18-bbb7-72ee397e4bf4", "seyda.muftuoglu@gmail.com", true, "Şeyda", 1, "image29", "Müftüoğlu", false, null, "SEYDAMUFTUOGLU@GMAIL.COM", "SEYDAMUFTUOGLU@GMAIL.COM", null, "+905439999929", false, 0, "aae857e4-59c1-45c9-81e4-60f1cfcb6370", false, "Şeyda Müftüoğlu" },
                    { new Guid("c5d42623-4ecf-462f-aa2d-6196832f4865"), 0, 28, "e321709d-c3ff-40c0-b84e-a4bfaf302605", "melike.ozdil@gmail.com", true, "Melike", 1, "image10", "Özdil", false, null, "MELIKEÖZDIL@GMAIL.COM", "MELIKEÖZDIL@GMAIL.COM", null, "+905439999910", false, 0, "bbab8ac7-39e8-4a7a-a163-a01f1d1d44a2", false, "Melike Özdil" },
                    { new Guid("c82cf8c0-0c18-4659-98b7-a7e059a6e441"), 0, 28, "db952bc7-2d6e-42c8-ac8f-df1c2f87ea83", "goksu.gokcesu@gmail.com", false, "Göksu", 1, "image30", "Gökçesu", false, null, "GOKSUGOKCESU@GMAIL.COM", "GOKSUGOKCESU@GMAIL.COM", null, "+905439999930", true, 0, "517d6402-b931-4128-97af-235a31a142a4", false, "Göksu Gökçesu" },
                    { new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 0, 25, "43844c42-1af9-4948-8ba5-018a921cec19", "superadmin@gmail.com", true, "Admin", 2, "https://static.vecteezy.com/system/resources/previews/024/183/525/non_2x/avatar-of-a-man-portrait-of-a-young-guy-illustration-of-male-character-in-modern-color-style-vector.jpg", "Bey", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEFmJ/zIqVROhzzJsYbYcjomPlXN9IgEmtEKckHneDQpLN6KxjkFTM+Gk5hzl45cSJg==", "+905439999999", true, 520, "aad4ab39-cf7f-4467-9701-8f143e4d2718", false, "Admin" },
                    { new Guid("d0038ff3-5561-4cc6-b52a-3ecc63473559"), 0, 24, "354f1c57-a12c-49a6-986d-ff2ff3180487", "melike.ozdil@gmail.com", true, "Melike", 1, "image26", "Özdil", false, null, "MELIKEOZDIL@GMAIL.COM", "MELIKEOZDIL@GMAIL.COM", null, "+905439999926", true, 0, "56025c75-b619-4f6c-9e43-0e8a926d7758", false, "Melike Özdil" },
                    { new Guid("d1d13f11-21da-4754-8c22-6df3ab22424a"), 0, 29, "d7362dec-bbbe-4770-a68d-413a00fdf2ea", "alper.goksel.yilmaz@gmail.com", true, "Alper Göksel", 2, "image11", "Yılmaz", false, null, "ALPERGOKSELYILMAZ@GMAIL.COM", "ALPERGOKSELYILMAZ@GMAIL.COM", null, "+905439999911", true, 0, "c3da8a0c-f483-4fcd-8383-7ac262b39169", false, "Alper Göksel Yılmaz" },
                    { new Guid("d88c8518-9dc8-4901-97c8-0b386a090862"), 0, 30, "b124ebc5-6f59-489f-b23f-f63ee176120e", "filiz.cetin.narsap@gmail.com", true, "Filiz", 1, "image22", "Çetin Narşap", false, null, "FILIZCETINNARSAP@GMAIL.COM", "FILIZCETINNARSAP@GMAIL.COM", null, "+905439999922", true, 0, "c5b1af17-1a6d-4e63-8808-2935ef170917", false, "Filiz Çetin Narşap" },
                    { new Guid("e025ca3f-c35b-44fd-a919-e6343a29a09a"), 0, 27, "451cd7d8-600a-4a7e-8a90-4586d2f047d4", "erhan.zorlu@gmail.com", false, "Erhan", 2, "image7", "Zorlu", false, null, "ERHANZORLU@GMAIL.COM", "ERHANZORLU@GMAIL.COM", null, "+905439999907", true, 0, "a6bdba6e-fb3e-4518-b58f-c49ade77f2c7", false, "Erhan Zorlu" },
                    { new Guid("e079e4f6-0d09-41c2-abf4-843930bf97f4"), 0, 26, "e7c699be-cda4-478d-a043-e7ee1f894855", "hande.eren@gmail.com", true, "Hande", 1, "image23", "Eren", false, null, "HANDEREN@GMAIL.COM", "HANDEREN@GMAIL.COM", null, "+905439999923", false, 0, "cb3b2284-76db-495e-9133-3acf88e64502", false, "Hande Eren" },
                    { new Guid("eb44645f-cba2-4f98-bf3d-22d3ae8a9b81"), 0, 26, "08666c64-867f-4e72-9eb5-256efeef4ed5", "hazal.serkaya@gmail.com", true, "Hazal", 1, "image4", "Serkaya", false, null, "HAZALSERKAYA@GMAIL.COM", "HAZALSERKAYA@GMAIL.COM", null, "+905439999904", true, 0, "a3a1ae6f-ec7c-440d-ab87-38216910c627", false, "Hazal Serkaya" },
                    { new Guid("eb4de0de-0006-43d5-aae6-314297436220"), 0, 31, "ebe9eee6-5f96-4215-aa67-062735fa9abf", "muhsin.cetinkaya@gmail.com", false, "Muhsin", 2, "image35", "Çetinkaya", false, null, "MUHSINCETINKAYA@GMAIL.COM", "MUHSINCETINKAYA@GMAIL.COM", null, "+905439999935", false, 0, "df8e0510-b280-4260-a7d3-d31b144b07d0", false, "Muhsin Çetinkaya" }
                });

            migrationBuilder.InsertData(
                table: "Badges",
                columns: new[] { "Id", "BadgeIcon", "BadgeName", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("0299a520-25ca-49ec-9492-035ccf2ed5b8"), "https://w7.pngwing.com/pngs/423/1004/png-transparent-medal-gold-winner-badge-achievement-reward-army-champion-awards-icon.png", "Dilek Perisi", "Undefined", new DateTime(2024, 11, 30, 14, 19, 24, 24, DateTimeKind.Local).AddTicks(1135), null, null, false, null, null },
                    { new Guid("6296d6f2-052e-40fb-bf0b-72eb2ac34a6d"), "https://static.vecteezy.com/system/resources/previews/014/606/031/original/golden-yellow-trophy-icon-for-the-winner-of-a-sports-event-png.png", "Dilek Yıldızı", "Undefined", new DateTime(2024, 11, 30, 14, 19, 24, 24, DateTimeKind.Local).AddTicks(1175), null, null, false, null, null },
                    { new Guid("820b74d4-c6f7-4823-a45e-6dbd41311212"), "https://e7.pngegg.com/pngimages/1002/183/png-clipart-smiley-smiley-miscellaneous-smiley.png", "Gülen Yüz", "Undefined", new DateTime(2024, 11, 30, 14, 19, 24, 24, DateTimeKind.Local).AddTicks(1182), null, null, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "EventName", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("1328a6c8-9ebd-4b22-978a-453f0c31bbdf"), "Undefined", new DateTime(2024, 11, 30, 11, 19, 24, 24, DateTimeKind.Utc).AddTicks(3021), null, null, "Diğer Gönüllü Faaliyetleri", false, null, null },
                    { new Guid("1e7bc8e4-59a8-4f63-af21-c7697a727f64"), "Undefined", new DateTime(2024, 11, 30, 11, 19, 24, 24, DateTimeKind.Utc).AddTicks(3025), null, null, "Dilek Alma Etkinliği", false, null, null },
                    { new Guid("3c5b8e39-a8f8-4671-a573-2e1e5e8a6f85"), "Undefined", new DateTime(2024, 11, 30, 11, 19, 24, 24, DateTimeKind.Utc).AddTicks(3027), null, null, "Dilek Gerçekleştirme Etkinliği", false, null, null }
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Badges");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
