using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaktabTaha.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TasvibEntityChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TasvibStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "عدم تصویب");

            migrationBuilder.UpdateData(
                table: "TasvibStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "تصویب");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TasvibStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "تصویب");

            migrationBuilder.UpdateData(
                table: "TasvibStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "عدم تصویب");
        }
    }
}
