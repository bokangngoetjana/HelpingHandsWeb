using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HelpingHands.Data.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "City");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "City",
            //    columns: table => new
            //    {
            //        CityID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_City", x => x.CityID);
            //    });
        }
    }
}
