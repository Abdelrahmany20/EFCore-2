using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_2.Migrations
{
    /// <inheritdoc />
    public partial class Onestudent2ManycoursesRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentsID",
                table: "Student_Course",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentsID",
                table: "courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_Course_StudentsID",
                table: "Student_Course",
                column: "StudentsID");

            migrationBuilder.CreateIndex(
                name: "IX_courses_StudentsID",
                table: "courses",
                column: "StudentsID");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_Students_StudentsID",
                table: "courses",
                column: "StudentsID",
                principalTable: "Students",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Course_Students_StudentsID",
                table: "Student_Course",
                column: "StudentsID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_Students_StudentsID",
                table: "courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Course_Students_StudentsID",
                table: "Student_Course");

            migrationBuilder.DropIndex(
                name: "IX_Student_Course_StudentsID",
                table: "Student_Course");

            migrationBuilder.DropIndex(
                name: "IX_courses_StudentsID",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "StudentsID",
                table: "Student_Course");

            migrationBuilder.DropColumn(
                name: "StudentsID",
                table: "courses");
        }
    }
}
