using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeTaskScheduler.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class added_thumbnailpath_to_downloadable_files : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "DurationInSeconds",
                table: "Attachments",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThumbnailPath",
                table: "Attachments",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoAttachment_ThumbnailPath",
                table: "Attachments",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThumbnailPath",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "VideoAttachment_ThumbnailPath",
                table: "Attachments");

            migrationBuilder.AlterColumn<long>(
                name: "DurationInSeconds",
                table: "Attachments",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);
        }
    }
}
