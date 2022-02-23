using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day_10.Migrations
{
    public partial class initialCreat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "ntext", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "ntext", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "ntext", maxLength: 30, nullable: false),
                    State = table.Column<string>(type: "ntext", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
