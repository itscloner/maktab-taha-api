using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MaktabTaha.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TasvibEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TasvibId",
                table: "Attachment",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ManagerTasvibStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerTasvibStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TasvibStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasvibStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasvib",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TasvibDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TahghighId = table.Column<int>(type: "int", nullable: false),
                    CaseNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClientRequestDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MosavebId = table.Column<int>(type: "int", nullable: false),
                    TasvibStatusId = table.Column<int>(type: "int", nullable: false),
                    TasvibReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManagerTasvibStatusId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasvib", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasvib_CaseBNF_CaseNumber",
                        column: x => x.CaseNumber,
                        principalTable: "CaseBNF",
                        principalColumn: "CaseNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tasvib_Donor_MosavebId",
                        column: x => x.MosavebId,
                        principalTable: "Donor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tasvib_ManagerTasvibStatus_ManagerTasvibStatusId",
                        column: x => x.ManagerTasvibStatusId,
                        principalTable: "ManagerTasvibStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tasvib_Tahghigh_TahghighId",
                        column: x => x.TahghighId,
                        principalTable: "Tahghigh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tasvib_TasvibStatus_TasvibStatusId",
                        column: x => x.TasvibStatusId,
                        principalTable: "TasvibStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ManagerTasvibStatus",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "منتظر تایید" },
                    { 2, "تایید" }
                });

            migrationBuilder.InsertData(
                table: "TasvibStatus",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "تصویب" },
                    { 2, "عدم تصویب" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_TasvibId",
                table: "Attachment",
                column: "TasvibId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasvib_CaseNumber",
                table: "Tasvib",
                column: "CaseNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Tasvib_ManagerTasvibStatusId",
                table: "Tasvib",
                column: "ManagerTasvibStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasvib_MosavebId",
                table: "Tasvib",
                column: "MosavebId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasvib_TahghighId",
                table: "Tasvib",
                column: "TahghighId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasvib_TasvibStatusId",
                table: "Tasvib",
                column: "TasvibStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachment_Tasvib_TasvibId",
                table: "Attachment",
                column: "TasvibId",
                principalTable: "Tasvib",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachment_Tasvib_TasvibId",
                table: "Attachment");

            migrationBuilder.DropTable(
                name: "Tasvib");

            migrationBuilder.DropTable(
                name: "ManagerTasvibStatus");

            migrationBuilder.DropTable(
                name: "TasvibStatus");

            migrationBuilder.DropIndex(
                name: "IX_Attachment_TasvibId",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "TasvibId",
                table: "Attachment");
        }
    }
}
