using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeTaskScheduler.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class added_course_to_theme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CourseId",
                table: "Themes",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Themes_CourseId",
                table: "Themes",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Themes_Courses_CourseId",
                table: "Themes",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Themes_Courses_CourseId",
                table: "Themes");

            migrationBuilder.DropIndex(
                name: "IX_Themes_CourseId",
                table: "Themes");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Themes");
        }
    }
}
