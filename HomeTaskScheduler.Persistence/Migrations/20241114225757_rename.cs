using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeTaskScheduler.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class rename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Answer",
                table: "TaskConfigurations",
                newName: "Question");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Question",
                table: "TaskConfigurations",
                newName: "Answer");
        }
    }
}
