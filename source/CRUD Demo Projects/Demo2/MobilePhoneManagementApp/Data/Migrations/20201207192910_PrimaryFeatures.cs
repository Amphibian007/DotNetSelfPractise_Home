using Microsoft.EntityFrameworkCore.Migrations;

namespace MobilePhoneManagementApp.Data.Migrations
{
    public partial class PrimaryFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mobiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Battery = table.Column<string>(nullable: true),
                    Screen = table.Column<string>(nullable: true),
                    Processor = table.Column<string>(nullable: true),
                    RAM = table.Column<string>(nullable: true),
                    Storage = table.Column<string>(nullable: true),
                    OS = table.Column<string>(nullable: true),
                    Camera = table.Column<string>(nullable: true),
                    Selfie = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mobiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobilesCategorys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MobileId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobilesCategorys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MobilesCategorys_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MobilesCategorys_Mobiles_MobileId",
                        column: x => x.MobileId,
                        principalTable: "Mobiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MobilesCategorys_CategoryId",
                table: "MobilesCategorys",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MobilesCategorys_MobileId",
                table: "MobilesCategorys",
                column: "MobileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MobilesCategorys");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Mobiles");
        }
    }
}
