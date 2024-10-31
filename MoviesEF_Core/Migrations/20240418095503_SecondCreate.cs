using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesEF_Core.Migrations
{
    /// <inheritdoc />
    public partial class SecondCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SubtitleLanguage",
                table: "Subtitless",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MovieName",
                table: "Moviess",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Moviess",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "DirectorId",
                table: "Moviess",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "MoviesImdbDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Directorss",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "MovieSubtitles",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    SubtitleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieSubtitles", x => new { x.SubtitleId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_MovieSubtitles_Moviess_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Moviess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieSubtitles_Subtitless_SubtitleId",
                        column: x => x.SubtitleId,
                        principalTable: "Subtitless",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Moviess_DirectorId",
                table: "Moviess",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_MoviesImdbDetails_MovieId",
                table: "MoviesImdbDetails",
                column: "MovieId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MovieSubtitles_MovieId",
                table: "MovieSubtitles",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_MoviesImdbDetails_Moviess_MovieId",
                table: "MoviesImdbDetails",
                column: "MovieId",
                principalTable: "Moviess",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Moviess_Directorss_DirectorId",
                table: "Moviess",
                column: "DirectorId",
                principalTable: "Directorss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MoviesImdbDetails_Moviess_MovieId",
                table: "MoviesImdbDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Moviess_Directorss_DirectorId",
                table: "Moviess");

            migrationBuilder.DropTable(
                name: "MovieSubtitles");

            migrationBuilder.DropIndex(
                name: "IX_Moviess_DirectorId",
                table: "Moviess");

            migrationBuilder.DropIndex(
                name: "IX_MoviesImdbDetails_MovieId",
                table: "MoviesImdbDetails");

            migrationBuilder.DropColumn(
                name: "DirectorId",
                table: "Moviess");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "MoviesImdbDetails");

            migrationBuilder.AlterColumn<string>(
                name: "SubtitleLanguage",
                table: "Subtitless",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "MovieName",
                table: "Moviess",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Moviess",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Directorss",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
