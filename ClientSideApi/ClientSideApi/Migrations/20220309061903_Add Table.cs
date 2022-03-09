using Microsoft.EntityFrameworkCore.Migrations;

namespace ClientSideApi.Migrations
{
    public partial class AddTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "EmployeeInfo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeInfo",
                table: "EmployeeInfo",
                column: "EmpId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeInfo",
                table: "EmployeeInfo");

            migrationBuilder.RenameTable(
                name: "EmployeeInfo",
                newName: "Employees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmpId");
        }
    }
}
