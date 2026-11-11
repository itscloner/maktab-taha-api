using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaktabTaha.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDeleteBehaviorsCascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaseDonorHelps_Donor_DonorId",
                table: "CaseDonorHelps");

            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Permissions_ParentId",
                table: "Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_CaseType_SadatStatusId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_City_BirthCityId",
                table: "Person");

            migrationBuilder.AddForeignKey(
                name: "FK_CaseDonorHelps_Donor_DonorId",
                table: "CaseDonorHelps",
                column: "DonorId",
                principalTable: "Donor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Permissions_ParentId",
                table: "Permissions",
                column: "ParentId",
                principalTable: "Permissions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_CaseType_SadatStatusId",
                table: "Person",
                column: "SadatStatusId",
                principalTable: "CaseType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_City_BirthCityId",
                table: "Person",
                column: "BirthCityId",
                principalTable: "City",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaseDonorHelps_Donor_DonorId",
                table: "CaseDonorHelps");

            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Permissions_ParentId",
                table: "Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_CaseType_SadatStatusId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_City_BirthCityId",
                table: "Person");

            migrationBuilder.AddForeignKey(
                name: "FK_CaseDonorHelps_Donor_DonorId",
                table: "CaseDonorHelps",
                column: "DonorId",
                principalTable: "Donor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Permissions_ParentId",
                table: "Permissions",
                column: "ParentId",
                principalTable: "Permissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_CaseType_SadatStatusId",
                table: "Person",
                column: "SadatStatusId",
                principalTable: "CaseType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_City_BirthCityId",
                table: "Person",
                column: "BirthCityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
