using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeTaskScheduler.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class comments_with_users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AbstractUserId",
                table: "Comments",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AbstractUserId",
                table: "Comments",
                column: "AbstractUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_AbstractUserId",
                table: "Comments",
                column: "AbstractUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_AbstractUserId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_AbstractUserId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "AbstractUserId",
                table: "Comments");
        }
    }
}
