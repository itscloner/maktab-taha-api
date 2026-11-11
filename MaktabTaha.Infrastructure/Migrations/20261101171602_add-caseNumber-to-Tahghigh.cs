using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaktabTaha.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addcaseNumbertoTahghigh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tahghigh_Moshavereh_MoshaverehId",
                table: "Tahghigh");

            migrationBuilder.AddColumn<string>(
                name: "CaseNumber",
                table: "Tahghigh",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Tahghigh_CaseNumber",
                table: "Tahghigh",
                column: "CaseNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Tahghigh_CaseBNF_CaseNumber",
                table: "Tahghigh",
                column: "CaseNumber",
                principalTable: "CaseBNF",
                principalColumn: "CaseNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tahghigh_Moshavereh_MoshaverehId",
                table: "Tahghigh",
                column: "MoshaverehId",
                principalTable: "Moshavereh",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tahghigh_CaseBNF_CaseNumber",
                table: "Tahghigh");

            migrationBuilder.DropForeignKey(
                name: "FK_Tahghigh_Moshavereh_MoshaverehId",
                table: "Tahghigh");

            migrationBuilder.DropIndex(
                name: "IX_Tahghigh_CaseNumber",
                table: "Tahghigh");

            migrationBuilder.DropColumn(
                name: "CaseNumber",
                table: "Tahghigh");

            migrationBuilder.AddForeignKey(
                name: "FK_Tahghigh_Moshavereh_MoshaverehId",
                table: "Tahghigh",
                column: "MoshaverehId",
                principalTable: "Moshavereh",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
