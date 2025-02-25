using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_2.Migrations
{
    /// <inheritdoc />
    public partial class courseinstractorRelationM2M : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courseinstractor",
                columns: table => new
                {
                    courseID = table.Column<int>(type: "int", nullable: false),
                    instractorID = table.Column<int>(type: "int", nullable: false),
                    evaluate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseinstractor", x => new { x.courseID, x.instractorID });
                    table.ForeignKey(
                        name: "FK_courseinstractor_Instractors_instractorID",
                        column: x => x.instractorID,
                        principalTable: "Instractors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_courseinstractor_courses_courseID",
                        column: x => x.courseID,
                        principalTable: "courses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_courseinstractor_instractorID",
                table: "courseinstractor",
                column: "instractorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "courseinstractor");
        }
    }
}
