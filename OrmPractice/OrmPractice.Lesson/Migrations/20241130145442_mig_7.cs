using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrmPractice.Lesson.Migrations
{
    /// <inheritdoc />
    public partial class mig_7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Details",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Details_StudentId",
                table: "Details",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Details_Students_StudentId",
                table: "Details",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Details_Students_StudentId",
                table: "Details");

            migrationBuilder.DropIndex(
                name: "IX_Details_StudentId",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Details");
        }
    }
}
