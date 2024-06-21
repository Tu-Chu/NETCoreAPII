using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KLKLKL.Migrations
{
    /// <inheritdoc />
    public partial class table_Student : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cau2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Sonha = table.Column<int>(type: "INTEGER", nullable: false),
                    Diachi = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cau2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cau2_cau1_Id",
                        column: x => x.Id,
                        principalTable: "cau1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cau2");
        }
    }
}
