using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeTaskScheduler.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class attachemnt_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContentType",
                table: "Attachments",
                type: "character varying(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DurationInSeconds",
                table: "Attachments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Extension",
                table: "Attachments",
                type: "character varying(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FileSize",
                table: "Attachments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "Attachments",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Attachments",
                type: "character varying(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Attachments",
                type: "character varying(1024)",
                maxLength: 1024,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoAttachment_ContentType",
                table: "Attachments",
                type: "character varying(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoAttachment_Extension",
                table: "Attachments",
                type: "character varying(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "VideoAttachment_FileSize",
                table: "Attachments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VideoAttachment_Height",
                table: "Attachments",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoAttachment_Path",
                table: "Attachments",
                type: "character varying(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VideoAttachment_Width",
                table: "Attachments",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Width",
                table: "Attachments",
                type: "integer",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentType",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "DurationInSeconds",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "Extension",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "FileSize",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "Path",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "VideoAttachment_ContentType",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "VideoAttachment_Extension",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "VideoAttachment_FileSize",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "VideoAttachment_Height",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "VideoAttachment_Path",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "VideoAttachment_Width",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Attachments");
        }
    }
}
