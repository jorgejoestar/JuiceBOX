using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Webshop.Migrations
{
    public partial class DbSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    UserID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
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
                name: "Carts",
                columns: table => new
                {
                    CartID = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(nullable: true),
                    ProductAmount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CartID);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false),
                    Imagepath = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Stock = table.Column<int>(nullable: false),
                    CartID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Carts_CartID",
                        column: x => x.CartID,
                        principalTable: "Carts",
                        principalColumn: "CartID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserID" },
                values: new object[] { "4db2520a-1c51-4b2f-bec4-925a75c6843f", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 10L });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserID" },
                values: new object[] { "01e4e618-d176-49e2-aa96-2444895b8980", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 8L });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserID" },
                values: new object[] { "ee90d9ba-8dd3-4dc7-b87d-8985829e88d7", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 7L });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserID" },
                values: new object[] { "54916c64-a5da-4367-95c9-faa2db5bbe9b", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 6L });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserID" },
                values: new object[] { "4776f2a5-5d25-41d1-a902-946973106ebb", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 5L });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserID" },
                values: new object[] { "53624c26-bc14-45a8-a80c-1474aec2f0db", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 4L });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserID" },
                values: new object[] { "80c724bc-80a4-4834-8e6e-43dc15111f13", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 3L });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserID" },
                values: new object[] { "29b1f971-639f-4d24-8d81-ac2b64125502", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 2L });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserID" },
                values: new object[] { "374f4644-8ec9-468a-92b8-fe7a8b1ea95b", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 1L });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserID" },
                values: new object[] { "83b480dc-dac3-4dcd-9bf5-9b821f938db0", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 9L });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CartID", "Description", "Imagepath", "Name", "Price", "Stock" },
                values: new object[] { 10L, null, "dignissimos", "http://lorempixel.com/640/480/cats", "Generic Granite Salad", 159.48981031053225, 574 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CartID", "Description", "Imagepath", "Name", "Price", "Stock" },
                values: new object[] { 8L, null, "Facere voluptatem totam provident magnam autem quae eum earum maxime.", "http://lorempixel.com/640/480/nature", "Refined Wooden Gloves", 25.029448359752745, 91 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CartID", "Description", "Imagepath", "Name", "Price", "Stock" },
                values: new object[] { 7L, null, @"Veniam ut non voluptatem qui officia illo.
Quisquam illo ipsum.
Enim tenetur repellat maiores libero non dolorem optio incidunt omnis.
Ad excepturi voluptatem quia occaecati accusamus nisi consequatur laboriosam aut.
Vero et similique voluptas consequatur ut ullam.
Laboriosam dicta ut dignissimos id omnis eius qui.", "http://lorempixel.com/640/480/city", "Intelligent Rubber Table", 190.06299128060368, 385 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CartID", "Description", "Imagepath", "Name", "Price", "Stock" },
                values: new object[] { 6L, null, "Officia tenetur qui aliquid eum veritatis eos odio qui.", "http://lorempixel.com/640/480/animals", "Small Fresh Computer", 12.204744549563502, 733 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CartID", "Description", "Imagepath", "Name", "Price", "Stock" },
                values: new object[] { 5L, null, "Soluta adipisci nemo vero officia. Autem molestiae dolorem hic dignissimos temporibus natus dolores consequatur ipsum. Ea aspernatur magnam voluptas aliquam aut est quae veritatis. Accusantium porro et commodi at id odio.", "http://lorempixel.com/640/480/food", "Sleek Rubber Mouse", 193.13963273639774, 317 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CartID", "Description", "Imagepath", "Name", "Price", "Stock" },
                values: new object[] { 4L, null, "Nobis eaque et nihil possimus ut ut eos.", "http://lorempixel.com/640/480/nightlife", "Intelligent Soft Table", 97.950680721993876, 556 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CartID", "Description", "Imagepath", "Name", "Price", "Stock" },
                values: new object[] { 3L, null, @"Odit ut sapiente repellat distinctio reprehenderit magni est.
Iure explicabo et sed delectus ut consequatur.
Aut modi quae eaque et repudiandae aliquam labore.
Consequuntur asperiores suscipit hic debitis deleniti ducimus dicta dolores.
Rem perferendis dolor repudiandae amet ducimus ipsum sed voluptas quasi.", "http://lorempixel.com/640/480/nightlife", "Awesome Rubber Keyboard", 203.51949980553218, 683 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CartID", "Description", "Imagepath", "Name", "Price", "Stock" },
                values: new object[] { 2L, null, "Tempore molestiae quam est.", "http://lorempixel.com/640/480/cats", "Practical Steel Table", 88.180290637156133, 649 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CartID", "Description", "Imagepath", "Name", "Price", "Stock" },
                values: new object[] { 9L, null, "Non quibusdam aut et qui nisi ullam.", "http://lorempixel.com/640/480/fashion", "Practical Plastic Towels", 71.474695451313025, 587 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CartID", "Description", "Imagepath", "Name", "Price", "Stock" },
                values: new object[] { 1L, null, "consequatur", "http://lorempixel.com/640/480/abstract", "Unbranded Wooden Pants", 61.2659352963166, 423 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CartID",
                table: "Products",
                column: "CartID");
        }

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
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
