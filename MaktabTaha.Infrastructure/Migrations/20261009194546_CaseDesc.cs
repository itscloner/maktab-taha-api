using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaktabTaha.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CaseDesc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Case_Request_RequestId",
                table: "Case");

            migrationBuilder.AddForeignKey(
                name: "FK_Case_Request_RequestId",
                table: "Case",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Case_Request_RequestId",
                table: "Case");

            migrationBuilder.AddForeignKey(
                name: "FK_Case_Request_RequestId",
                table: "Case",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
