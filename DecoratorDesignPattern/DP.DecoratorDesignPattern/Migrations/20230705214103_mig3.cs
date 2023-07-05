using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DP.DecoratorDesignPattern.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifiers",
                columns: table => new
                {
                    NotifierID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotifierCreator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotifierSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotifierType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotifierChannel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifiers", x => x.NotifierID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifiers");
        }
    }
}
