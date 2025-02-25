using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment1_EFCore.FMigration
{
    /// <inheritdoc />
    public partial class Stud_Course : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stud_Course",
                columns: table => new
                {
                    stud_id = table.Column<int>(type: "int", nullable: false),
                    course_id = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stud_Course", x => new { x.stud_id, x.course_id });
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stud_Course");

            migrationBuilder.DropTable(
                name: "Topics");
        }
    }
}
