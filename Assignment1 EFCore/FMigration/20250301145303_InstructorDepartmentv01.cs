using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment1_EFCore.FMigration
{
    /// <inheritdoc />
    public partial class InstructorDepartmentv01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ins_id",
                table: "Departments");

            migrationBuilder.AddColumn<int>(
                name: "Instructorid",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Dept_id",
                table: "Instructors",
                column: "Dept_id");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Instructorid",
                table: "Departments",
                column: "Instructorid",
                unique: true,
                filter: "[Instructorid] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Instructorid",
                table: "Departments",
                column: "Instructorid",
                principalTable: "Instructors",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Dept_id",
                table: "Instructors",
                column: "Dept_id",
                principalTable: "Departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_Instructorid",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dept_id",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_Dept_id",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Instructorid",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Instructorid",
                table: "Departments");

            migrationBuilder.AddColumn<int>(
                name: "ins_id",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
