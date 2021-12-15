using Microsoft.EntityFrameworkCore.Migrations;

namespace KmuDolmus.Migrations
{
    public partial class hatlar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guns",
                columns: table => new
                {
                    GunId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GunAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guns", x => x.GunId);
                });

            migrationBuilder.CreateTable(
                name: "Hatlars",
                columns: table => new
                {
                    hat_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hat_Numara = table.Column<int>(type: "int", nullable: false),
                    hat_saat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GunId = table.Column<int>(type: "int", nullable: false),
                    yon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hatlars", x => x.hat_id);
                    table.ForeignKey(
                        name: "FK_Hatlars_Guns_GunId",
                        column: x => x.GunId,
                        principalTable: "Guns",
                        principalColumn: "GunId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hatlars_GunId",
                table: "Hatlars",
                column: "GunId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hatlars");

            migrationBuilder.DropTable(
                name: "Guns");
        }
    }
}
