using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MTWebApi.Migrations
{
    public partial class LectorAndStudentManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_Lectors_LectorId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_LectorId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "LectorId",
                table: "students");

            migrationBuilder.CreateTable(
                name: "LectorStudent",
                columns: table => new
                {
                    LectorId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LectorStudent", x => new { x.LectorId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_LectorStudent_Lectors_LectorId",
                        column: x => x.LectorId,
                        principalTable: "Lectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LectorStudent_students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LectorStudent_StudentId",
                table: "LectorStudent",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LectorStudent");

            migrationBuilder.AddColumn<int>(
                name: "LectorId",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_students_LectorId",
                table: "students",
                column: "LectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_Lectors_LectorId",
                table: "students",
                column: "LectorId",
                principalTable: "Lectors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
