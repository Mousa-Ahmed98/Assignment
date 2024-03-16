using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class RemoveDegreeColumnFromCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Degree",
                table: "Course");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16,
                column: "MinDegree",
                value: 84);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Degree",
                table: "Course",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                column: "Degree",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                column: "Degree",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                column: "Degree",
                value: 95);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                column: "Degree",
                value: 95);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                column: "Degree",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                column: "Degree",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                column: "Degree",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                column: "Degree",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9,
                column: "Degree",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10,
                column: "Degree",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 11,
                column: "Degree",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 12,
                column: "Degree",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13,
                column: "Degree",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 14,
                column: "Degree",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 15,
                column: "Degree",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Degree", "MinDegree" },
                values: new object[] { 85, 75 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 17,
                column: "Degree",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 18,
                column: "Degree",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 19,
                column: "Degree",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 20,
                column: "Degree",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 21,
                column: "Degree",
                value: 95);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 22,
                column: "Degree",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 23,
                column: "Degree",
                value: 95);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 24,
                column: "Degree",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 25,
                column: "Degree",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 26,
                column: "Degree",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 27,
                column: "Degree",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 28,
                column: "Degree",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 29,
                column: "Degree",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 30,
                column: "Degree",
                value: 85);
        }
    }
}
