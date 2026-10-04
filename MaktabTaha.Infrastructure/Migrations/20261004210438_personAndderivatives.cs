using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaktabTaha.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class personAndderivatives : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CaseLevel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseLevelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DependancyStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DependencyStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DependancyStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaritalStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalCode = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShenasnamehNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShenasnamehSeries = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthProvinceId = table.Column<int>(type: "int", nullable: false),
                    BirthCityId = table.Column<int>(type: "int", nullable: false),
                    MaritalStatusId = table.Column<int>(type: "int", nullable: false),
                    NationalityId = table.Column<int>(type: "int", nullable: false),
                    ReligonId = table.Column<int>(type: "int", nullable: false),
                    JobId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    Interest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wish = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DependancyStatusId = table.Column<int>(type: "int", nullable: false),
                    EducationStatusId = table.Column<int>(type: "int", nullable: false),
                    EducationLevelId = table.Column<int>(type: "int", nullable: false),
                    AverageScore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrphanStatusId = table.Column<int>(type: "int", nullable: false),
                    Income = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IncomeDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhysicalStatusId = table.Column<int>(type: "int", nullable: false),
                    SicknessType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmploymentStatusId = table.Column<int>(type: "int", nullable: false),
                    UnemploymentReasonId = table.Column<int>(type: "int", nullable: false),
                    SadatStatusId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_CaseType_SadatStatusId",
                        column: x => x.SadatStatusId,
                        principalTable: "CaseType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_City_BirthCityId",
                        column: x => x.BirthCityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_DependancyStatus_DependancyStatusId",
                        column: x => x.DependancyStatusId,
                        principalTable: "DependancyStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_EducationLevel_EducationLevelId",
                        column: x => x.EducationLevelId,
                        principalTable: "EducationLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_EducationStatus_EducationStatusId",
                        column: x => x.EducationStatusId,
                        principalTable: "EducationStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_EmploymantStatus_EmploymentStatusId",
                        column: x => x.EmploymentStatusId,
                        principalTable: "EmploymantStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_Job_JobId",
                        column: x => x.JobId,
                        principalTable: "Job",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_MaritalStatus_MaritalStatusId",
                        column: x => x.MaritalStatusId,
                        principalTable: "MaritalStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_Nationality_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Nationality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_OrphanStatus_OrphanStatusId",
                        column: x => x.OrphanStatusId,
                        principalTable: "OrphanStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_PhysicalStatus_PhysicalStatusId",
                        column: x => x.PhysicalStatusId,
                        principalTable: "PhysicalStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_Province_BirthProvinceId",
                        column: x => x.BirthProvinceId,
                        principalTable: "Province",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_Religon_ReligonId",
                        column: x => x.ReligonId,
                        principalTable: "Religon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_UnemploymentReason_UnemploymentReasonId",
                        column: x => x.UnemploymentReasonId,
                        principalTable: "UnemploymentReason",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attachment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttachmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Attach = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    PersonId1 = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attachment_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attachment_Person_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Person",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_PersonId",
                table: "Attachment",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_PersonId1",
                table: "Attachment",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_Person_BirthCityId",
                table: "Person",
                column: "BirthCityId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_BirthProvinceId",
                table: "Person",
                column: "BirthProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_DependancyStatusId",
                table: "Person",
                column: "DependancyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_EducationLevelId",
                table: "Person",
                column: "EducationLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_EducationStatusId",
                table: "Person",
                column: "EducationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_EmploymentStatusId",
                table: "Person",
                column: "EmploymentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_GenderId",
                table: "Person",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_JobId",
                table: "Person",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_MaritalStatusId",
                table: "Person",
                column: "MaritalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_NationalityId",
                table: "Person",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_OrphanStatusId",
                table: "Person",
                column: "OrphanStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_PhysicalStatusId",
                table: "Person",
                column: "PhysicalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_ReligonId",
                table: "Person",
                column: "ReligonId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_SadatStatusId",
                table: "Person",
                column: "SadatStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_SkillId",
                table: "Person",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_UnemploymentReasonId",
                table: "Person",
                column: "UnemploymentReasonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attachment");

            migrationBuilder.DropTable(
                name: "CaseLevel");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "DependancyStatus");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "MaritalStatus");
        }
    }
}
