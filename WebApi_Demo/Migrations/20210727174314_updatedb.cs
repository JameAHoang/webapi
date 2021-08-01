using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi_Demo.Migrations
{
    public partial class updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TenSV",
                table: "Students",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "MaSV",
                table: "Students",
                newName: "Id");

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(3)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Addresss = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Salary = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Students",
                newName: "TenSV");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Students",
                newName: "MaSV");
        }
    }
}
