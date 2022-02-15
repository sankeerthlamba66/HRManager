using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRManager.Data.Entity.Migrations
{
    public partial class tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    OrganizationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationTexts",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    ConfidentialityAgreement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceLevelAgreement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BGVAcknowlwdgement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BGVEmailSubjectTemplate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BGVEmailBodyTemplate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PDVEmailSubjectTemplate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PDVEmailBodyTemplate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationId = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationTexts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationTexts_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Roles = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationId = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeBankInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameAsPerBankAccount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IFSCCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeBankInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeBankInfos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PassportPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PanCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AadharCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Passport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoterId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentAddressProof = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermanentAddressProof = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FathersAadharCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MothersAadharCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThreeMonthsBankStatementOfSalaryAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Form16OrIncomeCertificateOfCurrentFinYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SSCOrEquivalent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateOrEquivalent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraduationOrEquivalent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PGOrEquivalent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdvancedDiplomaIfAny = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfessionalCertificationsIfAny = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeDocuments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeInsuranceInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAsPerAadhar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Relationship = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<byte>(type: "tinyint", nullable: false),
                    DateOfBirthAsPerAadhar = table.Column<DateTime>(type: "Date", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeInsuranceInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeInsuranceInfos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePersonalInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<byte>(type: "tinyint", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "Date", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalEmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermanentAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BloodGroup = table.Column<byte>(type: "tinyint", nullable: false),
                    EmergencyContactName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmergencyContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelationshipWithContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PanCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameAsPerAadhar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AadharCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FathersNameAsPerAadhar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FathersMobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MothersNameAsPerAadhar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HowWereYouReferredToUs = table.Column<byte>(type: "tinyint", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePersonalInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeePersonalInfos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePFandESIInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ESIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePFandESIInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeePFandESIInfos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProfessionalInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsThisYourLastEmployment = table.Column<bool>(type: "bit", nullable: false),
                    LastDesignation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "Date", nullable: false),
                    EndDate = table.Column<DateTime>(type: "Date", nullable: false),
                    CTC = table.Column<int>(type: "int", nullable: false),
                    ReportingManagerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportingManagerEmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HRName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HREmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OfferLetterPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelievingLetterPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExperienceLetterPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaySlip1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaySlip2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaySlip3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProfessionalInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeProfessionalInfos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationTexts_OrganizationId",
                table: "ApplicationTexts",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeBankInfos_UserId",
                table: "EmployeeBankInfos",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDocuments_UserId",
                table: "EmployeeDocuments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInsuranceInfos_UserId",
                table: "EmployeeInsuranceInfos",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePersonalInfos_UserId",
                table: "EmployeePersonalInfos",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePFandESIInfos_UserId",
                table: "EmployeePFandESIInfos",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProfessionalInfos_UserId",
                table: "EmployeeProfessionalInfos",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_OrganizationId",
                table: "Users",
                column: "OrganizationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationTexts");

            migrationBuilder.DropTable(
                name: "EmployeeBankInfos");

            migrationBuilder.DropTable(
                name: "EmployeeDocuments");

            migrationBuilder.DropTable(
                name: "EmployeeInsuranceInfos");

            migrationBuilder.DropTable(
                name: "EmployeePersonalInfos");

            migrationBuilder.DropTable(
                name: "EmployeePFandESIInfos");

            migrationBuilder.DropTable(
                name: "EmployeeProfessionalInfos");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Organizations");
        }
    }
}
