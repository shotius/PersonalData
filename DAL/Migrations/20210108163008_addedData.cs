using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class addedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dictionaries",
                columns: new[] { "Id", "HasGender", "HasPhoneType", "HasPosition", "Title" },
                values: new object[,]
                {
                    { 1, false, false, true, "manager" },
                    { 2, false, false, true, "CEO" },
                    { 3, false, false, true, "shveicar" },
                    { 4, true, false, false, "Male" },
                    { 5, true, false, false, "Female" },
                    { 6, false, true, false, "mobile" },
                    { 7, false, true, false, "work" },
                    { 8, false, true, false, "Home" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "BirthDate", "FirstName", "GenderId", "LastName", "Mail", "PositionId" },
                values: new object[] { 1, new DateTime(1999, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "name1", 5, "LastName1", "test@mail.com", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dictionaries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dictionaries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dictionaries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dictionaries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dictionaries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dictionaries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dictionaries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dictionaries",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
