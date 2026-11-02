using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaktabTaha.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ReCreateCaseDonorHelps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CaseDonorHelps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TasvibId = table.Column<int>(type: "int", nullable: false),
                    CaseNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RequestTypeId = table.Column<int>(type: "int", nullable: false),
                    MoneyAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DonorId = table.Column<int>(type: "int", nullable: false),
                    FromDate = table.Column<DateTime>(type: "Date", nullable: true),
                    ToDate = table.Column<DateTime>(type: "Date", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseDonorHelps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CaseDonorHelps_CaseBNF_CaseNumber",
                        column: x => x.CaseNumber,
                        principalTable: "CaseBNF",
                        principalColumn: "CaseNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CaseDonorHelps_Donor_DonorId",
                        column: x => x.DonorId,
                        principalTable: "Donor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaseDonorHelps_RequestType_RequestTypeId",
                        column: x => x.RequestTypeId,
                        principalTable: "RequestType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CaseDonorHelps_Tasvib_TasvibId",
                        column: x => x.TasvibId,
                        principalTable: "Tasvib",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaseDonorHelps_CaseNumber",
                table: "CaseDonorHelps",
                column: "CaseNumber");

            migrationBuilder.CreateIndex(
                name: "IX_CaseDonorHelps_DonorId",
                table: "CaseDonorHelps",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_CaseDonorHelps_RequestTypeId",
                table: "CaseDonorHelps",
                column: "RequestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CaseDonorHelps_TasvibId",
                table: "CaseDonorHelps",
                column: "TasvibId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaseDonorHelps");
        }
    }
}
