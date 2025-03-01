using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment1_EFCore.FMigration
{
    /// <inheritdoc />
    public partial class StudentToDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Dep_id",
                table: "Students",
                newName: "Departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Departmentid",
                table: "Students",
                column: "Departmentid");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_Departmentid",
                table: "Students",
                column: "Departmentid",
                principalTable: "Departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_Departmentid",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_Departmentid",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "Departmentid",
                table: "Students",
                newName: "Dep_id");
        }
    }
}
