using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment1_EFCore.FMigration
{
    /// <inheritdoc />
    public partial class final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course");

            migrationBuilder.RenameTable(
                name: "Stud_Course",
                newName: "Stud_Courses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Courses",
                table: "Stud_Courses",
                columns: new[] { "stud_id", "course_id" });

            migrationBuilder.CreateTable(
                name: "Course_Insts",
                columns: table => new
                {
                    inst_id = table.Column<int>(type: "int", nullable: false),
                    course_id = table.Column<int>(type: "int", nullable: false),
                    evaluate = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course_Insts", x => new { x.inst_id, x.course_id });
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HourRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Dept_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course_Insts");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Courses",
                table: "Stud_Courses");

            migrationBuilder.RenameTable(
                name: "Stud_Courses",
                newName: "Stud_Course");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course",
                columns: new[] { "stud_id", "course_id" });
        }
    }
}
