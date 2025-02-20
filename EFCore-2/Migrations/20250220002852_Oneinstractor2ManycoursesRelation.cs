using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_2.Migrations
{
    /// <inheritdoc />
    public partial class Oneinstractor2ManycoursesRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InstractorsId",
                table: "course_instractor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_course_instractor_InstractorsId",
                table: "course_instractor",
                column: "InstractorsId");

            migrationBuilder.AddForeignKey(
                name: "FK_course_instractor_Instractors_InstractorsId",
                table: "course_instractor",
                column: "InstractorsId",
                principalTable: "Instractors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_course_instractor_Instractors_InstractorsId",
                table: "course_instractor");

            migrationBuilder.DropIndex(
                name: "IX_course_instractor_InstractorsId",
                table: "course_instractor");

            migrationBuilder.DropColumn(
                name: "InstractorsId",
                table: "course_instractor");
        }
    }
}
