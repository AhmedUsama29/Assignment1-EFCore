using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment1_EFCore.FMigration
{
    /// <inheritdoc />
    public partial class CourseTopic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Top_id",
                table: "Courses",
                newName: "Topicid");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Topicid",
                table: "Courses",
                column: "Topicid");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_Topicid",
                table: "Courses",
                column: "Topicid",
                principalTable: "Topics",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_Topicid",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Topicid",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "Topicid",
                table: "Courses",
                newName: "Top_id");
        }
    }
}
