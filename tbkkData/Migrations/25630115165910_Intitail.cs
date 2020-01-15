using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace tbkkData.Migrations
{
    public partial class Intitail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DepartmentName = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeType",
                columns: table => new
                {
                    EmployeeTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeType", x => x.EmployeeTypeID);
                });

            migrationBuilder.CreateTable(
                name: "GradeHistory",
                columns: table => new
                {
                    GradeHistoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GrahAllPoint = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    GrahRound1 = table.Column<int>(nullable: false),
                    GrahRound2 = table.Column<int>(nullable: false),
                    GrahRound3 = table.Column<int>(nullable: false),
                    GrahYear = table.Column<string>(nullable: true),
                    GrahBonusUp = table.Column<int>(nullable: false),
                    GrahSalaryUp = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradeHistory", x => x.GradeHistoryID);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    PositionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PositionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.PositionID);
                });

            migrationBuilder.CreateTable(
                name: "Evaluation",
                columns: table => new
                {
                    EvaluationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EvaDetail = table.Column<string>(nullable: true),
                    EvaSumPoint = table.Column<int>(nullable: false),
                    EvaDate = table.Column<DateTime>(nullable: false),
                    EvaStatus = table.Column<int>(nullable: false),
                    Evatype = table.Column<string>(nullable: true),
                    EvaluatorID = table.Column<int>(nullable: false),
                    Eva_GradeHistoryID = table.Column<int>(nullable: false),
                    GradeHistoryID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluation", x => x.EvaluationID);
                    table.ForeignKey(
                        name: "FK_Evaluation_GradeHistory_GradeHistoryID1",
                        column: x => x.GradeHistoryID1,
                        principalTable: "GradeHistory",
                        principalColumn: "GradeHistoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Salary = table.Column<double>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Date_of_employment = table.Column<DateTime>(nullable: false),
                    Employee_CompanyID = table.Column<int>(nullable: false),
                    CompanyID1 = table.Column<int>(nullable: true),
                    Employee_DepartmentID = table.Column<int>(nullable: false),
                    DepartmentID1 = table.Column<int>(nullable: true),
                    Employee_EmployeeTypeID = table.Column<int>(nullable: false),
                    EmployeeTypeID1 = table.Column<int>(nullable: true),
                    Employee_PositionID = table.Column<int>(nullable: false),
                    PositionID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employee_Company_CompanyID1",
                        column: x => x.CompanyID1,
                        principalTable: "Company",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Department_DepartmentID1",
                        column: x => x.DepartmentID1,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_EmployeeType_EmployeeTypeID1",
                        column: x => x.EmployeeTypeID1,
                        principalTable: "EmployeeType",
                        principalColumn: "EmployeeTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Position_PositionID1",
                        column: x => x.PositionID1,
                        principalTable: "Position",
                        principalColumn: "PositionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    LoginID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Login_EmployeeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.LoginID);
                    table.ForeignKey(
                        name: "FK_Login_Employee_Login_EmployeeID",
                        column: x => x.Login_EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_CompanyID1",
                table: "Employee",
                column: "CompanyID1");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentID1",
                table: "Employee",
                column: "DepartmentID1");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EmployeeTypeID1",
                table: "Employee",
                column: "EmployeeTypeID1");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PositionID1",
                table: "Employee",
                column: "PositionID1");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_GradeHistoryID1",
                table: "Evaluation",
                column: "GradeHistoryID1");

            migrationBuilder.CreateIndex(
                name: "IX_Login_Login_EmployeeID",
                table: "Login",
                column: "Login_EmployeeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evaluation");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "GradeHistory");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "EmployeeType");

            migrationBuilder.DropTable(
                name: "Position");
        }
    }
}
