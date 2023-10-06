using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Optimal.Com.Web.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<string>(type: "nvarchar(5)", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Gender = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BranchCode = table.Column<string>(type: "nvarchar(5)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false) 
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EmployeeID",
                table: "Employee",
                column: "EmployeeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
