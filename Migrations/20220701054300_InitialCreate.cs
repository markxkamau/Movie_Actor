using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMovie.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Genre = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rating = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Actor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Genre = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    YearsExperience = table.Column<string>(type: "TEXT", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Actor_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actor_MovieId",
                table: "Actor",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
