using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorMoviesApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "ImageUrl", "Review", "Title" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent non tellus vel orci gravida imperdiet.", "/images/movies/Highlander.png", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent non tellus vel orci gravida imperdiet. Aenean in pellentesque erat, at pretium nulla. Ut dui sem, viverra in porta vel, molestie nec mi.", "Highlander" },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent non tellus vel orci gravida imperdiet.", "/images/movies/Godfather.png", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent non tellus vel orci gravida imperdiet. Aenean in pellentesque erat, at pretium nulla. Ut dui sem, viverra in porta vel, molestie nec mi.", "Godfather" },
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent non tellus vel orci gravida imperdiet.", "/images/movies/LastOfTheMohicans.png", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent non tellus vel orci gravida imperdiet. Aenean in pellentesque erat, at pretium nulla. Ut dui sem, viverra in porta vel, molestie nec mi.", "Last of the Mohicans" },
                    { 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent non tellus vel orci gravida imperdiet.", "/images/movies/RearWindow.png", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent non tellus vel orci gravida imperdiet. Aenean in pellentesque erat, at pretium nulla. Ut dui sem, viverra in porta vel, molestie nec mi.", "Rear Window" },
                    { 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent non tellus vel orci gravida imperdiet.", "/images/movies/RoadHouse.png", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent non tellus vel orci gravida imperdiet. Aenean in pellentesque erat, at pretium nulla. Ut dui sem, viverra in porta vel, molestie nec mi.", "Road House" },
                    { 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent non tellus vel orci gravida imperdiet.", "/images/movies/StarTreck4.png", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent non tellus vel orci gravida imperdiet. Aenean in pellentesque erat, at pretium nulla. Ut dui sem, viverra in porta vel, molestie nec mi.", "Star Treck IV" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
