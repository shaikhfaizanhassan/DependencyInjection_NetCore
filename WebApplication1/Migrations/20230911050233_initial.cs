using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    Sid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Semail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.Sid);
                });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "Sid", "Semail", "Sname" },
                values: new object[] { 1, "Faizan@gmail.com", "Faizan" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "Sid", "Semail", "Sname" },
                values: new object[] { 2, "Faizan@gmail.com", "Faizan" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "Sid", "Semail", "Sname" },
                values: new object[] { 3, "Faizan@gmail.com", "Faizan" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "students");
        }
    }
}
