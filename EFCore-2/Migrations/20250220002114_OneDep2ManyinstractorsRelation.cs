using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_2.Migrations
{
    /// <inheritdoc />
    public partial class OneDep2ManyinstractorsRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "Instractors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Instractors_DepartmentID",
                table: "Instractors",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Instractors_Department_DepartmentID",
                table: "Instractors",
                column: "DepartmentID",
                principalTable: "Department",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instractors_Department_DepartmentID",
                table: "Instractors");

            migrationBuilder.DropIndex(
                name: "IX_Instractors_DepartmentID",
                table: "Instractors");

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "Instractors");
        }
    }
}
