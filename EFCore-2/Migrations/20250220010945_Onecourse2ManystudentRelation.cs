using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_2.Migrations
{
    /// <inheritdoc />
    public partial class Onecourse2ManystudentRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_Students_StudentsID",
                table: "courses");

            migrationBuilder.DropIndex(
                name: "IX_courses_StudentsID",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "StudentsID",
                table: "courses");

            migrationBuilder.AddColumn<int>(
                name: "coursesid",
                table: "Student_Course",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Studentscourses",
                columns: table => new
                {
                    StudentsID = table.Column<int>(type: "int", nullable: false),
                    coursesid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studentscourses", x => new { x.StudentsID, x.coursesid });
                    table.ForeignKey(
                        name: "FK_Studentscourses_Students_StudentsID",
                        column: x => x.StudentsID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Studentscourses_courses_coursesid",
                        column: x => x.coursesid,
                        principalTable: "courses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_Course_coursesid",
                table: "Student_Course",
                column: "coursesid");

            migrationBuilder.CreateIndex(
                name: "IX_Studentscourses_coursesid",
                table: "Studentscourses",
                column: "coursesid");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Course_courses_coursesid",
                table: "Student_Course",
                column: "coursesid",
                principalTable: "courses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Course_courses_coursesid",
                table: "Student_Course");

            migrationBuilder.DropTable(
                name: "Studentscourses");

            migrationBuilder.DropIndex(
                name: "IX_Student_Course_coursesid",
                table: "Student_Course");

            migrationBuilder.DropColumn(
                name: "coursesid",
                table: "Student_Course");

            migrationBuilder.AddColumn<int>(
                name: "StudentsID",
                table: "courses",
                type: "int",
                nullable: true);

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
        }
    }
}
