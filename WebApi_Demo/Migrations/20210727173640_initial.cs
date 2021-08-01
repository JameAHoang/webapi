using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi_Demo.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    MaSV = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    TenSV = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(3)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Addresss = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.MaSV);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
