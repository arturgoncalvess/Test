using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InternalErpProject.WebAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    IdPerson = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Rg = table.Column<int>(nullable: false),
                    Cpf = table.Column<int>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    NitPisNit = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Telephone = table.Column<int>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Hired = table.Column<bool>(nullable: false),
                    EmergencyContactName = table.Column<string>(nullable: true),
                    EmergencyContact = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.IdPerson);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "IdPerson", "BirthDate", "City", "Cpf", "Email", "EmergencyContact", "EmergencyContactName", "Hired", "Name", "NitPisNit", "Rg", "State", "Telephone" },
                values: new object[] { 1, new DateTime(2001, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fortaleza", 89371897, "artur@gmail.com", 392139739, "Maria", false, "Artur Gonçalves", 186867, 21787938, "Ceará", 263846234 });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "IdPerson", "BirthDate", "City", "Cpf", "Email", "EmergencyContact", "EmergencyContactName", "Hired", "Name", "NitPisNit", "Rg", "State", "Telephone" },
                values: new object[] { 2, new DateTime(2004, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fortaleza", 123123217, "arturP@gmail.com", 323354354, "Max", true, "Artur Pereira", 434237, 8324238, "Ceará", 213136234 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
