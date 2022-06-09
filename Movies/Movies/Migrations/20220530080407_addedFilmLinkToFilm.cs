using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies.Migrations
{
    public partial class addedFilmLinkToFilm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FilmLink",
                table: "Films",
                type: "nvarchar(max)",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilmLink",
                table: "Films");
        }
    }
}
