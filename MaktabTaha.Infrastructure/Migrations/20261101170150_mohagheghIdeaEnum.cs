using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MaktabTaha.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mohagheghIdeaEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MohagheghIdea",
                table: "Tahghigh");

            migrationBuilder.AddColumn<int>(
                name: "MohagheghIdeaId",
                table: "Tahghigh",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MohagheghIdea",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MohagheghIdea", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MohagheghIdea",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "عدم تایید" },
                    { 2, "تایید" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tahghigh_MohagheghIdeaId",
                table: "Tahghigh",
                column: "MohagheghIdeaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tahghigh_MohagheghIdea_MohagheghIdeaId",
                table: "Tahghigh",
                column: "MohagheghIdeaId",
                principalTable: "MohagheghIdea",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tahghigh_MohagheghIdea_MohagheghIdeaId",
                table: "Tahghigh");

            migrationBuilder.DropTable(
                name: "MohagheghIdea");

            migrationBuilder.DropIndex(
                name: "IX_Tahghigh_MohagheghIdeaId",
                table: "Tahghigh");

            migrationBuilder.DropColumn(
                name: "MohagheghIdeaId",
                table: "Tahghigh");

            migrationBuilder.AddColumn<string>(
                name: "MohagheghIdea",
                table: "Tahghigh",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
