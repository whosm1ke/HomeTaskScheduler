using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeTaskScheduler.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class multi_answers_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestSubmission_AnswerId",
                table: "Submissions");

            migrationBuilder.AddColumn<string>(
                name: "AnswerIds",
                table: "Submissions",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnswerIds",
                table: "Submissions");

            migrationBuilder.AddColumn<long>(
                name: "TestSubmission_AnswerId",
                table: "Submissions",
                type: "bigint",
                nullable: true);
        }
    }
}
