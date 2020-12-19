using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ADSL20N4.AbstractProduction.Migrations
{
    public partial class TphToTpt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Productions");

            migrationBuilder.DropColumn(
                name: "DurationInMinutes",
                table: "Productions");

            migrationBuilder.DropColumn(
                name: "NumberOfEpisodes",
                table: "Productions");

            migrationBuilder.DropColumn(
                name: "WorldwideBoxOfficeGross",
                table: "Productions");

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    DurationInMinutes = table.Column<int>(type: "int", nullable: false),
                    WorldwideBoxOfficeGross = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Productions_Id",
                        column: x => x.Id,
                        principalTable: "Productions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NumberOfEpisodes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Series_Productions_Id",
                        column: x => x.Id,
                        principalTable: "Productions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DurationInMinutes", "WorldwideBoxOfficeGross" },
                values: new object[] { 1, 181, 2797800564.0 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DurationInMinutes", "WorldwideBoxOfficeGross" },
                values: new object[] { 2, 118, 1654791102.0 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DurationInMinutes", "WorldwideBoxOfficeGross" },
                values: new object[] { 3, 105, 192617891.0 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DurationInMinutes", "WorldwideBoxOfficeGross" },
                values: new object[] { 4, 116, 166623705.0 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DurationInMinutes", "WorldwideBoxOfficeGross" },
                values: new object[] { 5, 120, 194051302.0 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 12,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 15,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 17,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 20,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 23,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 24,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 29,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 32,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 33,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 37,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 39,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 46,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 47,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 50,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 51,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 52,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 53,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 55,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 56,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 58,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 61,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 68,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 73,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 75,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 84,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 88,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 93,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 97,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 109,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 115,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 118,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 119,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 122,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 123,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 127,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 132,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 135,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 137,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 139,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 143,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 144,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 148,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 151,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 157,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 158,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 159,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 161,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 162,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 164,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 169,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 172,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 174,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 178,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 179,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 180,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 182,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 185,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 186,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 187,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 188,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 189,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 192,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 193,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 194,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 197,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 204,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 210,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 215,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 218,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 219,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 220,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 224,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 226,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 231,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 232,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 233,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 234,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 235,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 237,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 241,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 242,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 244,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 248,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 253,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 254,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 255,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 258,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 259,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 265,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 271,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 273,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 274,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 282,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 285,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 286,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 287,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 288,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 289,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 291,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 295,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 296,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 298,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 301,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 302,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 304,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 305,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 307,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 308,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 312,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 328,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 333,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 335,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 336,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 337,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 339,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 341,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 344,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 345,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 349,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 356,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 363,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 366,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 368,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 369,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 373,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 374,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 375,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 376,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 378,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 379,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 380,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 382,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 385,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 389,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 393,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 398,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 399,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 402,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 403,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 404,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 405,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 413,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 420,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 424,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 425,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 427,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 428,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 434,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 435,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 436,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 439,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 441,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 442,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 451,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 452,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 453,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 455,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 456,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 459,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 460,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 462,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 464,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 466,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 472,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 473,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 477,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 479,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 480,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 482,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 484,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 485,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 486,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 489,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 491,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 492,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 493,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 494,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 496,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 501,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 505,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 507,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 509,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 510,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 511,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 517,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 518,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 522,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 523,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 524,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 528,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 532,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 538,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 543,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 544,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 549,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 552,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 556,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 557,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 567,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 569,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 570,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 572,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 575,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 578,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 580,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 581,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 582,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 584,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 586,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 587,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 588,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 595,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 602,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 603,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 608,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 610,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 611,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 618,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 620,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 621,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 626,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 633,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 635,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 639,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 644,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 648,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 653,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 654,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 657,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 658,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 660,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 662,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 664,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 667,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 670,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 671,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 672,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 675,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 677,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 679,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 680,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 686,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 688,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 692,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 693,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 697,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 699,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 701,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 703,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 704,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 705,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 708,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 713,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 714,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 716,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 717,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 720,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 725,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 728,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 729,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 730,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 731,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 735,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 738,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 741,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 743,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 747,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 748,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 749,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 750,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 751,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 754,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 758,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 763,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 765,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 769,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 770,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 771,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 773,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 774,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 781,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 784,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 785,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 786,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 788,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 792,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 793,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 794,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 799,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 802,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 804,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 806,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 807,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 809,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 811,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 814,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 815,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 820,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 827,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 831,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 835,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 838,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 840,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 843,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 844,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 846,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 848,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 857,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 860,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 864,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 873,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 875,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 880,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 885,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 886,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 889,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 890,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 891,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 892,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 893,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 899,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 903,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 904,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 905,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 907,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 908,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 909,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 911,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 912,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 913,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 914,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 915,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 916,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 921,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 924,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 925,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 930,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 931,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 933,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 934,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 937,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 938,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 942,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 946,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 950,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 953,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 957,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 958,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 960,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 961,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 964,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 965,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 967,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 971,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 972,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 973,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 975,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 978,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 981,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 982,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 984,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 988,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 989,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 991,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 992,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 996,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 997,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "Id", "NumberOfEpisodes" },
                values: new object[] { 6, 148 });

            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "Id", "NumberOfEpisodes" },
                values: new object[] { 7, 52 });

            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "Id", "NumberOfEpisodes" },
                values: new object[] { 8, 34 });

            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "Id", "NumberOfEpisodes" },
                values: new object[] { 9, 12 });

            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "Id", "NumberOfEpisodes" },
                values: new object[] { 10, 177 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DeleteData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Productions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DurationInMinutes",
                table: "Productions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfEpisodes",
                table: "Productions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "WorldwideBoxOfficeGross",
                table: "Productions",
                type: "float",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Productions",
                columns: new[] { "Id", "Discriminator", "Name", "NumberOfEpisodes", "Release" },
                values: new object[,]
                {
                    { 10, "SeriesEntity", "The Walking Dead", 177, new DateTime(2010, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "SeriesEntity", "Kantaro: The Sweet Tooth Salaryman", 12, new DateTime(2017, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "SeriesEntity", "Stranger Things", 34, new DateTime(2016, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "SeriesEntity", "Downton Abbey", 52, new DateTime(2010, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "SeriesEntity", "The Fresh Prince of Bel-Air", 148, new DateTime(1990, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Productions",
                columns: new[] { "Id", "Discriminator", "DurationInMinutes", "Name", "Release", "WorldwideBoxOfficeGross" },
                values: new object[,]
                {
                    { 5, "MovieEntity", 120, "Downton Abbey", new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 194051302.0 },
                    { 4, "MovieEntity", 116, "Gemini Man", new DateTime(2019, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 166623705.0 },
                    { 3, "MovieEntity", 105, "Ip Man 4", new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 192617891.0 },
                    { 2, "MovieEntity", 118, "The Lion King", new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1654791102.0 },
                    { 1, "MovieEntity", 181, "Avengers: Endgame", new DateTime(2019, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2797800564.0 }
                });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 12,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 15,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 17,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 20,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 23,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 24,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 29,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 32,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 33,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 37,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 39,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 46,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 47,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 50,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 51,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 52,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 53,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 55,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 56,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 58,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 61,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 68,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 73,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 75,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 84,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 88,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 93,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 97,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 109,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 115,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 118,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 119,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 122,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 123,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 127,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 132,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 135,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 137,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 139,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 143,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 144,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 148,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 151,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 157,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 158,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 159,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 161,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 162,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 164,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 169,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 172,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 174,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 178,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 179,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 180,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 182,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 185,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 186,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 187,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 188,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 189,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 192,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 193,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 194,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 197,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 204,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 210,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 215,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 218,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 219,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 220,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 224,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 226,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 231,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 232,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 233,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 234,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 235,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 237,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 241,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 242,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 244,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 248,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 253,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 254,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 255,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 258,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 259,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 265,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 271,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 273,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 274,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 282,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 285,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 286,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 287,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 288,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 289,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 291,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 295,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 296,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 298,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 301,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 302,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 304,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 305,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 307,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 308,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 312,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 328,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 333,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 335,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 336,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 337,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 339,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 341,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 344,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 345,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 349,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 356,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 363,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 366,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 368,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 369,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 373,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 374,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 375,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 376,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 378,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 379,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 380,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 382,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 385,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 389,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 393,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 398,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 399,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 402,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 403,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 404,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 405,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 413,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 420,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 424,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 425,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 427,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 428,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 434,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 435,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 436,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 439,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 441,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 442,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 451,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 452,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 453,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 455,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 456,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 459,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 460,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 462,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 464,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 466,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 472,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 473,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 477,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 479,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 480,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 482,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 484,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 485,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 486,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 489,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 491,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 492,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 493,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 494,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 496,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 501,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 505,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 507,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 509,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 510,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 511,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 517,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 518,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 522,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 523,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 524,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 528,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 532,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 538,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 543,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 544,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 549,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 552,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 556,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 557,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 567,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 569,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 570,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 572,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 575,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 578,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 580,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 581,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 582,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 584,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 586,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 587,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 588,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 595,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 602,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 603,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 608,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 610,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 611,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 618,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 620,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 621,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 626,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 633,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 635,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 639,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 644,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 648,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 653,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 654,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 657,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 658,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 660,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 662,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 664,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 667,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 670,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 671,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 672,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 675,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 677,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 679,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 680,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 686,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 688,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 692,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 693,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 697,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 699,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 701,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 703,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 704,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 705,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 708,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 713,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 714,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 716,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 717,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 720,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 725,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 728,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 729,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 730,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 731,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 735,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 738,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 741,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 743,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 747,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 748,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 749,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 750,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 751,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 754,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 758,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 763,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 765,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 769,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 770,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 771,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 773,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 774,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 781,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 784,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 785,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 786,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 788,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 792,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 793,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 794,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 799,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 802,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 804,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 806,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 807,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 809,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 811,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 814,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 815,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 820,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 827,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 831,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 835,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 838,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 840,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 843,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 844,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 846,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 848,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 857,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 860,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 864,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 873,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 875,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 880,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 885,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 886,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 889,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 890,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 891,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 892,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 893,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 899,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 903,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 904,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 905,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 907,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 908,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 909,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 911,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 912,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 913,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 914,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 915,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 916,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 921,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 924,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 925,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 930,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 931,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 933,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 934,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 937,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 938,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 942,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 946,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 950,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 953,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 957,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 958,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 960,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 961,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 964,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 965,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 967,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 971,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 972,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 973,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 975,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 978,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 981,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 982,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 984,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 988,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 989,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 991,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 992,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 996,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 997,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });
        }
    }
}
