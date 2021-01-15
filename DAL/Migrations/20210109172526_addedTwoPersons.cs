using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class addedTwoPersons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "BirthDate", "FirstName", "GenderId", "LastName", "Mail", "PositionId" },
                values: new object[] { 2, new DateTime(1999, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "name2", 5, "LastName2", "test@mail.com", 1 });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "BirthDate", "FirstName", "GenderId", "LastName", "Mail", "PositionId" },
                values: new object[] { 3, new DateTime(1999, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "name3", 5, "LastName3", "test@mail.com", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
