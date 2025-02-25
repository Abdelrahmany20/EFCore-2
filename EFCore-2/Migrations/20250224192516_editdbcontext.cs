using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_2.Migrations
{
    /// <inheritdoc />
    public partial class editdbcontext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "course_instractor");

            migrationBuilder.DropTable(
                name: "Student_Course");

            migrationBuilder.DropTable(
                name: "Studentscourses");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "course_instractor",
                columns: table => new
                {
                    course_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstractorsId = table.Column<int>(type: "int", nullable: false),
                    evaluate = table.Column<int>(type: "int", nullable: false),
                    instractor_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_course_instractor", x => x.course_id);
                    table.ForeignKey(
                        name: "FK_course_instractor_Instractors_InstractorsId",
                        column: x => x.InstractorsId,
                        principalTable: "Instractors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student_Course",
                columns: table => new
                {
                    Student_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    coursesid = table.Column<int>(type: "int", nullable: false),
                    StudentsID = table.Column<int>(type: "int", nullable: false),
                    Course_ID = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Course", x => x.Student_ID);
                    table.ForeignKey(
                        name: "FK_Student_Course_Students_StudentsID",
                        column: x => x.StudentsID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_Course_courses_coursesid",
                        column: x => x.coursesid,
                        principalTable: "courses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_course_instractor_InstractorsId",
                table: "course_instractor",
                column: "InstractorsId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Course_coursesid",
                table: "Student_Course",
                column: "coursesid");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Course_StudentsID",
                table: "Student_Course",
                column: "StudentsID");

            migrationBuilder.CreateIndex(
                name: "IX_Studentscourses_coursesid",
                table: "Studentscourses",
                column: "coursesid");
        }
    }
}
