﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MTWebApi.Migrations
{
    public partial class AddLectorsToDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LectorId",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Lectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lectors", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_Lectors_LectorId",
                table: "students");

            migrationBuilder.DropTable(
                name: "Lectors");

            migrationBuilder.DropIndex(
                name: "IX_students_LectorId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "LectorId",
                table: "students");
        }
    }
}
