﻿// <auto-generated />
using System;
using HRManager.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HRManager.Data.Entity.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HRManager.Data.Entity.Entities.ApplicationText", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnType("tinyint");

                    b.Property<string>("BGVAcknowlwdgement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BGVEmailBodyTemplate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BGVEmailSubjectTemplate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfidentialityAgreement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("Date");

                    b.Property<string>("EmployeeRegisteredEMailBodyTemplate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeRegisteredEMailSubjectTemplate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeSubmissionEMailBodyTemplate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeSubmissionEMailSubjectTemplate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("OrganizationId")
                        .HasColumnType("tinyint");

                    b.Property<string>("PDVEmailBodyTemplate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PDVEmailSubjectTemplate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceLevelAgreement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("Date");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("ApplicationTexts");
                });

            modelBuilder.Entity("HRManager.Data.Entity.Entities.EmployeeAgreementAcceptance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("BGVAcknowledgement")
                        .HasColumnType("bit");

                    b.Property<bool>("ConfidentialityAgreementAccepted")
                        .HasColumnType("bit");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("Date");

                    b.Property<bool>("ServiceLevelAgreement")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("Date");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("EmployeeAgreementAcceptances");
                });

            modelBuilder.Entity("HRManager.Data.Entity.Entities.EmployeeBankInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BranchName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("Date");

                    b.Property<string>("IFSCCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAsPerBankAccount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("Date");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("EmployeeBankInfos");
                });

            modelBuilder.Entity("HRManager.Data.Entity.Entities.EmployeeDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AadharCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdvancedDiplomaIfAny")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("Date");

                    b.Property<string>("CurrentAddressProof")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FathersAadharCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Form16OrIncomeCertificateOfCurrentFinYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GraduationOrEquivalent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntermediateOrEquivalent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MothersAadharCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PGOrEquivalent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PanCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Passport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermanentAddressProof")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfessionalCertificationsIfAny")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SSCOrEquivalent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThreeMonthsBankStatementOfSalaryAccount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("Date");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("VoterId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("EmployeeDocuments");
                });

            modelBuilder.Entity("HRManager.Data.Entity.Entities.EmployeeInsuranceInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("Date");

                    b.Property<DateTime?>("DateOfBirthAsPerAadhar")
                        .HasColumnType("Date");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAsPerAadhar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Relationship")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("Date");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("EmployeeInsuranceInfos");
                });

            modelBuilder.Entity("HRManager.Data.Entity.Entities.EmployeePersonalInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AadharCardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BloodGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("Date");

                    b.Property<string>("CurrentAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentAddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentAddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentAddressLine3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentPinCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("Date");

                    b.Property<string>("EmergencyContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmergencyContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FathersMobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FathersNameAsPerAadhar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaritalStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MothersNameAsPerAadhar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAsPerAadhar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PanCardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermanentAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermanentAddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermanentAddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermanentAddressLine3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermanentCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermanentPincode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermanentState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalEmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelationshipWithContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("Date");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("EmployeePersonalInfos");
                });

            modelBuilder.Entity("HRManager.Data.Entity.Entities.EmployeePFandESIInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("Date");

                    b.Property<string>("ESIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UAN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("Date");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("EmployeePFandESIInfos");
                });

            modelBuilder.Entity("HRManager.Data.Entity.Entities.EmployeeProfessionalInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CTC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("Date");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("Date");

                    b.Property<string>("ExperienceLetterPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HREmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HRName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsThisYourLastEmployment")
                        .HasColumnType("bit");

                    b.Property<string>("LastDesignation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfferLetterPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrganizationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaySlip1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaySlip2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaySlip3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelievingLetterPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReportingManagerEmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReportingManagerMobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReportingManagerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("Date");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("Date");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("EmployeeProfessionalInfos");
                });

            modelBuilder.Entity("HRManager.Data.Entity.Entities.Organization", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnType("tinyint");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("Date");

                    b.Property<string>("OrganizationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("Date");

                    b.HasKey("Id");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("HRManager.Data.Entity.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("Date");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("OrganizationId")
                        .HasColumnType("tinyint");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Roles")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("Date");

                    b.Property<string>("UserMailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HRManager.Data.Entity.Entities.Validation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("Date");

                    b.Property<bool>("PDValidated")
                        .HasColumnType("bit");

                    b.Property<bool>("Submitted")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("Date");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Validations");
                });

            modelBuilder.Entity("HRManager.Data.Entity.Entities.ApplicationText", b =>
                {
                    b.HasOne("HRManager.Data.Entity.Entities.Organization", "Organization")
                        .WithMany("ApplicationTexts")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("HRManager.Data.Entity.Entities.EmployeeAgreementAcceptance", b =>
                {
                    b.HasOne("HRManager.Data.Entity.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HRManager.Data.Entity.Entities.EmployeeBankInfo", b =>
                {
                    b.HasOne("HRManager.Data.Entity.Entities.User", "User")
                        .WithMany("BankInfos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HRManager.Data.Entity.Entities.EmployeeDocument", b =>
                {
                    b.HasOne("HRManager.Data.Entity.Entities.User", "User")
                        .WithMany("Documents")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HRManager.Data.Entity.Entities.EmployeeInsuranceInfo", b =>
                {
                    b.HasOne("HRManager.Data.Entity.Entities.User", "User")
                        .WithMany("InsuranceInfos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HRManager.Data.Entity.Entities.EmployeePersonalInfo", b =>
                {
                    b.HasOne("HRManager.Data.Entity.Entities.User", "User")
                        .WithOne("PersonalInfo")
                        .HasForeignKey("HRManager.Data.Entity.Entities.EmployeePersonalInfo", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HRManager.Data.Entity.Entities.EmployeePFandESIInfo", b =>
                {
                    b.HasOne("HRManager.Data.Entity.Entities.User", "User")
                        .WithMany("PFandESIInfos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HRManager.Data.Entity.Entities.EmployeeProfessionalInfo", b =>
                {
                    b.HasOne("HRManager.Data.Entity.Entities.User", "User")
                        .WithMany("ProfessionalInfos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HRManager.Data.Entity.Entities.User", b =>
                {
                    b.HasOne("HRManager.Data.Entity.Entities.Organization", "Organization")
                        .WithMany("Users")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("HRManager.Data.Entity.Entities.Validation", b =>
                {
                    b.HasOne("HRManager.Data.Entity.Entities.User", "User")
                        .WithOne("Validation")
                        .HasForeignKey("HRManager.Data.Entity.Entities.Validation", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HRManager.Data.Entity.Entities.Organization", b =>
                {
                    b.Navigation("ApplicationTexts");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("HRManager.Data.Entity.Entities.User", b =>
                {
                    b.Navigation("BankInfos");

                    b.Navigation("Documents");

                    b.Navigation("InsuranceInfos");

                    b.Navigation("PFandESIInfos");

                    b.Navigation("PersonalInfo")
                        .IsRequired();

                    b.Navigation("ProfessionalInfos");

                    b.Navigation("Validation")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
