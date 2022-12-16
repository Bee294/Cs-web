using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication13.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropColumn(
                name: "classroom",
                table: "Exam");

            migrationBuilder.DropColumn(
                name: "exam_date",
                table: "Exam");

            migrationBuilder.DropColumn(
                name: "exam_duration",
                table: "Exam");

            migrationBuilder.DropColumn(
                name: "faculty",
                table: "Exam");

            migrationBuilder.DropColumn(
                name: "start_time",
                table: "Exam");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Exam",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "subject",
                table: "Exam",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Exam",
                newName: "GroupName");

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "Exam",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "HireDate",
                table: "Exam",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Exam",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Exam");

            migrationBuilder.DropColumn(
                name: "HireDate",
                table: "Exam");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Exam");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Exam",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Exam",
                newName: "subject");

            migrationBuilder.RenameColumn(
                name: "GroupName",
                table: "Exam",
                newName: "status");

            migrationBuilder.AddColumn<string>(
                name: "classroom",
                table: "Exam",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "exam_date",
                table: "Exam",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "exam_duration",
                table: "Exam",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "faculty",
                table: "Exam",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "start_time",
                table: "Exam",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "CompanyName", "Designation", "Name", "Salary" },
                values: new object[] { 1, "New York", "XYZ Inc", "Developer", "John", 30000f });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "CompanyName", "Designation", "Name", "Salary" },
                values: new object[] { 2, "New York", "ABC Inc", "Manager", "Chris", 50000f });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "CompanyName", "Designation", "Name", "Salary" },
                values: new object[] { 3, "New Delhi", "XYZ Inc", "Consultant", "Mukesh", 20000f });
        }
    }
}
