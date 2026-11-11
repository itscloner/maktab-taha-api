using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaktabTaha.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ReqTypeHelp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaseDonorHelps_CaseType_CaseTypeId",
                table: "CaseDonorHelps");

            migrationBuilder.RenameColumn(
                name: "CaseTypeId",
                table: "CaseDonorHelps",
                newName: "RequestTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_CaseDonorHelps_CaseTypeId",
                table: "CaseDonorHelps",
                newName: "IX_CaseDonorHelps_RequestTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CaseDonorHelps_RequestType_RequestTypeId",
                table: "CaseDonorHelps",
                column: "RequestTypeId",
                principalTable: "RequestType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaseDonorHelps_RequestType_RequestTypeId",
                table: "CaseDonorHelps");

            migrationBuilder.RenameColumn(
                name: "RequestTypeId",
                table: "CaseDonorHelps",
                newName: "CaseTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_CaseDonorHelps_RequestTypeId",
                table: "CaseDonorHelps",
                newName: "IX_CaseDonorHelps_CaseTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CaseDonorHelps_CaseType_CaseTypeId",
                table: "CaseDonorHelps",
                column: "CaseTypeId",
                principalTable: "CaseType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
