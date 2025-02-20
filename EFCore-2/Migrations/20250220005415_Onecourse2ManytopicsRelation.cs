using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_2.Migrations
{
    /// <inheritdoc />
    public partial class Onecourse2ManytopicsRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "top_id",
                table: "courses");

            migrationBuilder.AddColumn<int>(
                name: "coursesid",
                table: "topics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_topics_coursesid",
                table: "topics",
                column: "coursesid");

            migrationBuilder.AddForeignKey(
                name: "FK_topics_courses_coursesid",
                table: "topics",
                column: "coursesid",
                principalTable: "courses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_topics_courses_coursesid",
                table: "topics");

            migrationBuilder.DropIndex(
                name: "IX_topics_coursesid",
                table: "topics");

            migrationBuilder.DropColumn(
                name: "coursesid",
                table: "topics");

            migrationBuilder.AddColumn<int>(
                name: "top_id",
                table: "courses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
