﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManager.Models.EntityViews;
using HRManager.Models.Views;
using HRManager.Models.ViewModels;
using AutoMapper;
using HRManager.Utilities;

namespace HRManager.Data.Entity
{
    public class EmployeeQueries
    {
        private readonly Context context=new Context();
        public EmployeeProfessionalInfo GetProfessionalDetails(int ProfessionalDetailsId)
        {
            EmployeeProfessionalInfo professionalInfo = new EmployeeProfessionalInfo();
            try
            {
                var employeeProfessionalInfo = context.EmployeeProfessionalInfos.FirstOrDefault(s => s.Id == ProfessionalDetailsId);
                //return mapper.Map<EmployeeProfessionalInfo>(employeeProfessionalInfo);
                professionalInfo.OrganizationName = employeeProfessionalInfo.OrganizationName;
                professionalInfo.IsThisYourLastEmployment = employeeProfessionalInfo.IsThisYourLastEmployment;
                professionalInfo.StartDate = employeeProfessionalInfo.StartDate;
                professionalInfo.EndDate = employeeProfessionalInfo.EndDate;
                professionalInfo.CTC = employeeProfessionalInfo.CTC;
                professionalInfo.ReportingManagerName = employeeProfessionalInfo.ReportingManagerName;
                professionalInfo.ReportingManagerEmailId = employeeProfessionalInfo.ReportingManagerEmailId;
                professionalInfo.HRName = employeeProfessionalInfo.HRName;
                professionalInfo.HREmailId = employeeProfessionalInfo.HREmailId;
                professionalInfo.OfferLetterPath = employeeProfessionalInfo.OfferLetterPath;
                professionalInfo.RelievingLetterPath = employeeProfessionalInfo.RelievingLetterPath;
                professionalInfo.ExperienceLetterPath = employeeProfessionalInfo.ExperienceLetterPath;
                professionalInfo.PaySlip1 = employeeProfessionalInfo.PaySlip1;
                professionalInfo.PaySlip2 = employeeProfessionalInfo.PaySlip2;
                professionalInfo.PaySlip3 = employeeProfessionalInfo.PaySlip3;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return professionalInfo;
        }

        public EmployeeShortSummary GetEmployeeShortSummary(int EmployeeId)
        {
            EmployeeShortSummary employeeShortSummary = new EmployeeShortSummary();
            try
            {
                var shortSummery = context.EmployeePersonalInfos.FirstOrDefault(s => s.Id == EmployeeId);
                employeeShortSummary.Name = shortSummery.FirstName;
                employeeShortSummary.Email = shortSummery.PersonalEmailId;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeShortSummary;
        }

        public EmployeeIndexModels GetEmployeeDetails(int UserId)
        {
            EmployeeIndexModels employeeIndexModels = new EmployeeIndexModels();
            try
            {
                var EmployeePersonalDetails = context.EmployeePersonalInfos.Where(s => s.UserId == UserId).FirstOrDefault();
                employeeIndexModels.employeePersonalInfo = GetEmployeePersonalInfoMapper(EmployeePersonalDetails);
                var EmployeeProfessionalDetails = context.EmployeeProfessionalInfos.Where(s => s.UserId == UserId).ToList();
                List<EmployeeProfessionalInfo> ListEmployeeProfessionalInfo = new List<EmployeeProfessionalInfo>();
                foreach (var item in EmployeeProfessionalDetails)
                {
                    ListEmployeeProfessionalInfo.Add(GetEmployeeProfessionalInfoMapper(item));
                }
                var EmployeeBankDetails = context.EmployeeBankInfos.Where(s => s.UserId == UserId).ToList();
                List<EmployeeBankInfo> ListEmployeeBankDetails = new List<EmployeeBankInfo>();
                foreach (var item in EmployeeBankDetails)
                {
                    ListEmployeeBankDetails.Add(GetEmployeeBankMapper(item));
                }
                var EmployeeInsuranceDetails = context.EmployeeInsuranceInfos.Where(s => s.UserId == UserId).ToList();
                List<EmployeeInsuranceInfo> ListEmployeeInsuranceDetails = new List<EmployeeInsuranceInfo>();
                foreach (var item in EmployeeInsuranceDetails)
                {
                    ListEmployeeInsuranceDetails.Add(GetEmployeeInsuranceMapper(item));
                }
                var EmployeePFAndESIDetails = context.EmployeePFandESIInfos.Where(s => s.UserId == UserId).ToList();
                List<EmployeePFandESIInfo> ListEmployeePFAndESIDetails = new List<EmployeePFandESIInfo>();
                foreach (var item in EmployeePFAndESIDetails)
                {
                    ListEmployeePFAndESIDetails.Add(GetPFandESIInfoMapper(item));
                }
                var EmployeeDocumentDetails = context.EmployeeDocuments.Where(s => s.UserId == UserId).ToList();
                List<EmployeeDocument> ListEmployeeDocumentDetails = new List<EmployeeDocument>();
                foreach (var item in EmployeeDocumentDetails)
                {
                    ListEmployeeDocumentDetails.Add(GetEmployeeDocumentMapper(item));
                }
                employeeIndexModels.employeeProfessionalInfos = ListEmployeeProfessionalInfo;
                employeeIndexModels.employeeBankInfos = ListEmployeeBankDetails;
                employeeIndexModels.employeeInsuranceInfos = ListEmployeeInsuranceDetails;
                employeeIndexModels.employeePFandESIInfos = ListEmployeePFAndESIDetails;
                employeeIndexModels.employeeDocuments = ListEmployeeDocumentDetails;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeIndexModels;
        }

        #region Entities to Entity view Mappers returns EntityViews
        public EmployeePersonalInfo GetEmployeePersonalInfoMapper(Entities.EmployeePersonalInfo PersonalInfo)
        {
            EmployeePersonalInfo EmployeePersonalInfo = new EmployeePersonalInfo();
            try
            {
                EmployeePersonalInfo.FirstName = PersonalInfo.FirstName;
                EmployeePersonalInfo.MiddleName = PersonalInfo.MiddleName;
                EmployeePersonalInfo.LastName = PersonalInfo.LastName;
                EmployeePersonalInfo.Gender = PersonalInfo.Gender;
                EmployeePersonalInfo.DateOfBirth = PersonalInfo.DateOfBirth;
                EmployeePersonalInfo.MobileNumber = PersonalInfo.MobileNumber;
                EmployeePersonalInfo.PersonalEmailId = PersonalInfo.PersonalEmailId;
                EmployeePersonalInfo.CurrentAddress = PersonalInfo.CurrentAddress;
                EmployeePersonalInfo.PermanentAddress = PersonalInfo.PermanentAddress;
                EmployeePersonalInfo.BloodGroup = PersonalInfo.BloodGroup;
                EmployeePersonalInfo.EmergencyContactName = PersonalInfo.EmergencyContactName;
                EmployeePersonalInfo.EmergencyContactNumber = PersonalInfo.EmergencyContactNumber;
                EmployeePersonalInfo.RelationshipWithContact = PersonalInfo.RelationshipWithContact;
                EmployeePersonalInfo.PanCardNumber = PersonalInfo.PanCardNumber;
                EmployeePersonalInfo.NameAsPerAadhar = PersonalInfo.NameAsPerAadhar;
                EmployeePersonalInfo.AadharCardNumber = PersonalInfo.AadharCardNumber;
                EmployeePersonalInfo.FathersNameAsPerAadhar = PersonalInfo.FathersNameAsPerAadhar;
                EmployeePersonalInfo.FathersMobileNumber = PersonalInfo.FathersMobileNumber;
                EmployeePersonalInfo.MothersNameAsPerAadhar = PersonalInfo.MothersNameAsPerAadhar;
                EmployeePersonalInfo.HowWereYouReferredToUs = PersonalInfo.HowWereYouReferredToUs;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return EmployeePersonalInfo;
        }

        public EmployeeProfessionalInfo GetEmployeeProfessionalInfoMapper(Entities.EmployeeProfessionalInfo ProfessionalInfo)
        {
            EmployeeProfessionalInfo employeeProfessionalInfo = new EmployeeProfessionalInfo();
            try
            {
                employeeProfessionalInfo.OrganizationName = ProfessionalInfo.OrganizationName;
                employeeProfessionalInfo.IsThisYourLastEmployment = ProfessionalInfo.IsThisYourLastEmployment;
                employeeProfessionalInfo.LastDesignation = ProfessionalInfo.LastDesignation;
                employeeProfessionalInfo.StartDate = ProfessionalInfo.StartDate;
                employeeProfessionalInfo.EndDate = ProfessionalInfo.EndDate;
                employeeProfessionalInfo.CTC = ProfessionalInfo.CTC;
                employeeProfessionalInfo.ReportingManagerName = ProfessionalInfo.ReportingManagerName;
                employeeProfessionalInfo.ReportingManagerEmailId = ProfessionalInfo.ReportingManagerEmailId;
                employeeProfessionalInfo.HRName = ProfessionalInfo.HRName;
                employeeProfessionalInfo.HREmailId = ProfessionalInfo.HREmailId;
                employeeProfessionalInfo.OfferLetterPath = ProfessionalInfo.OfferLetterPath;
                employeeProfessionalInfo.RelievingLetterPath = ProfessionalInfo.RelievingLetterPath;
                employeeProfessionalInfo.ExperienceLetterPath = ProfessionalInfo.ExperienceLetterPath;
                employeeProfessionalInfo.PaySlip1 = ProfessionalInfo.PaySlip1;
                employeeProfessionalInfo.PaySlip2 = ProfessionalInfo.PaySlip2;
                employeeProfessionalInfo.PaySlip3 = ProfessionalInfo.PaySlip3;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeProfessionalInfo;
        }

        public EmployeeBankInfo GetEmployeeBankMapper(Entities.EmployeeBankInfo BankInfo)
        {
            EmployeeBankInfo employeeBankInfo = new EmployeeBankInfo();
            try
            {
                employeeBankInfo.BankName = BankInfo.BankName;
                employeeBankInfo.NameAsPerBankAccount = BankInfo.NameAsPerBankAccount;
                employeeBankInfo.AccountNumber = BankInfo.AccountNumber;
                employeeBankInfo.BranchName = BankInfo.BranchName;
                employeeBankInfo.IFSCCode = BankInfo.IFSCCode;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeBankInfo;
        }

        public EmployeeInsuranceInfo GetEmployeeInsuranceMapper(Entities.EmployeeInsuranceInfo InsuranceInfo)
        {
            EmployeeInsuranceInfo employeeInsuranceInfo = new EmployeeInsuranceInfo();
            try
            {
                employeeInsuranceInfo.NameAsPerAadhar = InsuranceInfo.NameAsPerAadhar;
                employeeInsuranceInfo.Relationship = InsuranceInfo.Relationship;
                employeeInsuranceInfo.Gender = InsuranceInfo.Gender;
                employeeInsuranceInfo.DateOfBirthAsPerAadhar = InsuranceInfo.DateOfBirthAsPerAadhar;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeInsuranceInfo;
        }

        public EmployeePFandESIInfo GetPFandESIInfoMapper(Entities.EmployeePFandESIInfo PFAndESIInfo)
        {
            EmployeePFandESIInfo employeePFandESIInfo = new EmployeePFandESIInfo();
            try
            {
                employeePFandESIInfo.UAN = PFAndESIInfo.UAN;
                employeePFandESIInfo.ESIN = PFAndESIInfo.ESIN;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeePFandESIInfo;
        }

        public EmployeeDocument GetEmployeeDocumentMapper(Entities.EmployeeDocument DocumentInfo)
        {
            EmployeeDocument employeeDocumentInfo = new EmployeeDocument();
            try
            {
                employeeDocumentInfo.PassportPhoto = DocumentInfo.PassportPhoto;
                employeeDocumentInfo.Resume = DocumentInfo.Resume;
                employeeDocumentInfo.PanCard = DocumentInfo.PanCard;
                employeeDocumentInfo.AadharCard = DocumentInfo.AadharCard;
                employeeDocumentInfo.Passport = DocumentInfo.Passport;
                employeeDocumentInfo.VoterId = DocumentInfo.VoterId;
                employeeDocumentInfo.CurrentAddressProof = DocumentInfo.CurrentAddressProof;
                employeeDocumentInfo.PermanentAddressProof = DocumentInfo.PermanentAddressProof;
                employeeDocumentInfo.FathersAadharCard = DocumentInfo.FathersAadharCard;
                employeeDocumentInfo.MothersAadharCard = DocumentInfo.MothersAadharCard;
                employeeDocumentInfo.ThreeMonthsBankStatementOfSalaryAccount = DocumentInfo.ThreeMonthsBankStatementOfSalaryAccount;
                employeeDocumentInfo.Form16OrIncomeCertificateOfCurrentFinYear = DocumentInfo.Form16OrIncomeCertificateOfCurrentFinYear;
                employeeDocumentInfo.SSCOrEquivalent = DocumentInfo.SSCOrEquivalent;
                employeeDocumentInfo.IntermediateOrEquivalent = DocumentInfo.IntermediateOrEquivalent;
                employeeDocumentInfo.GraduationOrEquivalent = DocumentInfo.GraduationOrEquivalent;
                employeeDocumentInfo.PGOrEquivalent = DocumentInfo.PGOrEquivalent;
                employeeDocumentInfo.AdvancedDiplomaIfAny = DocumentInfo.AdvancedDiplomaIfAny;
                employeeDocumentInfo.ProfessionalCertificationsIfAny = DocumentInfo.ProfessionalCertificationsIfAny;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeDocumentInfo;
        }
        #endregion

        #region Personal Info queries
        public EmployeePersonalInfo GetPersonalInfo(int? PersonalInfoId,int UserId)
        {
            EmployeePersonalInfo _employeePersonalInfo = null;
            try
            {
                var employeePersonalInfo = context.EmployeePersonalInfos.FirstOrDefault(s => s.Id == PersonalInfoId && s.UserId == UserId);
                _employeePersonalInfo = GetEmployeePersonalInfoMapper(employeePersonalInfo);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return _employeePersonalInfo;  
        }

        public int UpdatePersonalInfo(EmployeePersonalInfo PersonalInfo)
        {
            var EmployeePersonalInfo = context.EmployeePersonalInfos.FirstOrDefault(s => s.Id == PersonalInfo.Id && s.UserId==PersonalInfo.UserId);
            try
            {
                EmployeePersonalInfo.FirstName = PersonalInfo.FirstName;
                EmployeePersonalInfo.MiddleName = PersonalInfo.MiddleName;
                EmployeePersonalInfo.LastName = PersonalInfo.LastName;
                EmployeePersonalInfo.Gender = PersonalInfo.Gender;
                EmployeePersonalInfo.DateOfBirth = PersonalInfo.DateOfBirth;
                EmployeePersonalInfo.MobileNumber = PersonalInfo.MobileNumber;
                EmployeePersonalInfo.PersonalEmailId = PersonalInfo.PersonalEmailId;
                EmployeePersonalInfo.CurrentAddress = PersonalInfo.CurrentAddress;
                EmployeePersonalInfo.PermanentAddress = PersonalInfo.PermanentAddress;
                EmployeePersonalInfo.BloodGroup = PersonalInfo.BloodGroup;
                EmployeePersonalInfo.EmergencyContactName = PersonalInfo.EmergencyContactName;
                EmployeePersonalInfo.EmergencyContactNumber = PersonalInfo.EmergencyContactNumber;
                EmployeePersonalInfo.RelationshipWithContact = PersonalInfo.RelationshipWithContact;
                EmployeePersonalInfo.PanCardNumber = PersonalInfo.PanCardNumber;
                EmployeePersonalInfo.NameAsPerAadhar = PersonalInfo.NameAsPerAadhar;
                EmployeePersonalInfo.AadharCardNumber = PersonalInfo.AadharCardNumber;
                EmployeePersonalInfo.FathersNameAsPerAadhar = PersonalInfo.FathersNameAsPerAadhar;
                EmployeePersonalInfo.FathersMobileNumber = PersonalInfo.FathersMobileNumber;
                EmployeePersonalInfo.MothersNameAsPerAadhar = PersonalInfo.MothersNameAsPerAadhar;
                EmployeePersonalInfo.HowWereYouReferredToUs = PersonalInfo.HowWereYouReferredToUs;

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return EmployeePersonalInfo.Id;//return the updated id here
        }

        #endregion

        #region ProfessionalInfo Queries
        public EmployeeProfessionalInfo GetProfessionalInfo(int? ProfessionalInfoId,int UserId)
        {
            EmployeeProfessionalInfo employeeProfessionalInfo = null;
            try
            {
                var professionalInfo = context.EmployeeProfessionalInfos.FirstOrDefault(s => s.Id == ProfessionalInfoId && s.UserId == UserId);
                employeeProfessionalInfo = GetEmployeeProfessionalInfoMapper(professionalInfo);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeProfessionalInfo;//list to be returned
        }

        public int AddProfessionalInfo(EmployeeProfessionalInfo ProfessionalInfo)
        {
            Entities.EmployeeProfessionalInfo employeeProfessionalInfo = new Entities.EmployeeProfessionalInfo();
            try
            {
                employeeProfessionalInfo.OrganizationName = ProfessionalInfo.OrganizationName;
                employeeProfessionalInfo.IsThisYourLastEmployment = ProfessionalInfo.IsThisYourLastEmployment;
                employeeProfessionalInfo.LastDesignation = ProfessionalInfo.LastDesignation;
                employeeProfessionalInfo.StartDate = ProfessionalInfo.StartDate;
                employeeProfessionalInfo.EndDate = ProfessionalInfo.EndDate;
                employeeProfessionalInfo.CTC = ProfessionalInfo.CTC;
                employeeProfessionalInfo.ReportingManagerName = ProfessionalInfo.ReportingManagerName;
                employeeProfessionalInfo.ReportingManagerEmailId = ProfessionalInfo.ReportingManagerEmailId;
                employeeProfessionalInfo.HRName = ProfessionalInfo.HRName;
                employeeProfessionalInfo.HREmailId = ProfessionalInfo.HREmailId;
                employeeProfessionalInfo.OfferLetterPath = ProfessionalInfo.OfferLetterPath;
                employeeProfessionalInfo.RelievingLetterPath = ProfessionalInfo.RelievingLetterPath;
                employeeProfessionalInfo.ExperienceLetterPath = ProfessionalInfo.ExperienceLetterPath;
                employeeProfessionalInfo.PaySlip1 = ProfessionalInfo.PaySlip1;
                employeeProfessionalInfo.PaySlip2 = ProfessionalInfo.PaySlip2;
                employeeProfessionalInfo.PaySlip3 = ProfessionalInfo.PaySlip3;
                context.EmployeeProfessionalInfos.Add(employeeProfessionalInfo);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeProfessionalInfo.Id;//added ProfessionalId value
        }

        public int UpdateProfessionalInfo(EmployeeProfessionalInfo ProfessionalInfo)
        {
            var employeeProfessionalInfo = context.EmployeeProfessionalInfos.FirstOrDefault(s => s.Id == ProfessionalInfo.Id && s.UserId==ProfessionalInfo.UserId);
            try
            {
                employeeProfessionalInfo.OrganizationName = ProfessionalInfo.OrganizationName;
                employeeProfessionalInfo.IsThisYourLastEmployment = ProfessionalInfo.IsThisYourLastEmployment;
                employeeProfessionalInfo.LastDesignation = ProfessionalInfo.LastDesignation;
                employeeProfessionalInfo.StartDate = ProfessionalInfo.StartDate;
                employeeProfessionalInfo.EndDate = ProfessionalInfo.EndDate;
                employeeProfessionalInfo.CTC = ProfessionalInfo.CTC;
                employeeProfessionalInfo.ReportingManagerName = ProfessionalInfo.ReportingManagerName;
                employeeProfessionalInfo.ReportingManagerEmailId = ProfessionalInfo.ReportingManagerEmailId;
                employeeProfessionalInfo.HRName = ProfessionalInfo.HRName;
                employeeProfessionalInfo.HREmailId = ProfessionalInfo.HREmailId;
                employeeProfessionalInfo.OfferLetterPath = ProfessionalInfo.OfferLetterPath;
                employeeProfessionalInfo.RelievingLetterPath = ProfessionalInfo.RelievingLetterPath;
                employeeProfessionalInfo.ExperienceLetterPath = ProfessionalInfo.ExperienceLetterPath;
                employeeProfessionalInfo.PaySlip1 = ProfessionalInfo.PaySlip1;
                employeeProfessionalInfo.PaySlip2 = ProfessionalInfo.PaySlip2;
                employeeProfessionalInfo.PaySlip3 = ProfessionalInfo.PaySlip3;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeProfessionalInfo.Id;//updated professionalId value
        }

        public void DeleteProfessionalInfo(int ProfessionalInfoId,int UserId)
        {
            try
            {
                var ProfessionalInfo = context.EmployeeProfessionalInfos.Where(s => s.Id == ProfessionalInfoId && s.UserId == UserId).FirstOrDefault();
                if (ProfessionalInfo != null)
                {
                    context.EmployeeProfessionalInfos.Remove(ProfessionalInfo);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
        }
#endregion

        #region BankInfo Queries
        public EmployeeBankInfo GetBankInfo(int? EmployeeBankInfoId,int UserId)
        {
            EmployeeBankInfo employeeBankInfo = null;
            try
            {
                var bankInfo = context.EmployeeBankInfos.Where(s => s.Id == EmployeeBankInfoId && s.UserId == UserId).FirstOrDefault();
                employeeBankInfo = GetEmployeeBankMapper(bankInfo);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeBankInfo;
        }

        public int AddBankInfo(EmployeeBankInfo BankInfo)
        {
            Entities.EmployeeBankInfo employeeBankInfo = new Entities.EmployeeBankInfo();
            try
            {
                employeeBankInfo.BankName = BankInfo.BankName;
                employeeBankInfo.NameAsPerBankAccount = BankInfo.NameAsPerBankAccount;
                employeeBankInfo.AccountNumber = BankInfo.AccountNumber;
                employeeBankInfo.BranchName = BankInfo.BranchName;
                employeeBankInfo.IFSCCode = BankInfo.IFSCCode;
                context.EmployeeBankInfos.Add(employeeBankInfo);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeBankInfo.Id;//added bankId value
        }

        public int UpdateBankInfo(EmployeeBankInfo BankInfo)
        {
            var employeeBankInfo = context.EmployeeBankInfos.Where(s => s.Id == BankInfo.Id && s.UserId==BankInfo.UserId).FirstOrDefault();
            try
            {
                employeeBankInfo.BankName = BankInfo.BankName;
                employeeBankInfo.NameAsPerBankAccount = BankInfo.NameAsPerBankAccount;
                employeeBankInfo.AccountNumber = BankInfo.AccountNumber;
                employeeBankInfo.BranchName = BankInfo.BranchName;
                employeeBankInfo.IFSCCode = BankInfo.IFSCCode;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeBankInfo.Id;//updated employeeBankInfoId value
        }

        public void DeleteBankInfo(int EmployeeBankInfoId,int UserId)
        {
            try
            {
                var employeeBankInfo = context.EmployeeProfessionalInfos.Where(s => s.Id == EmployeeBankInfoId && s.UserId == UserId).FirstOrDefault();
                if (employeeBankInfo != null)
                {
                    context.EmployeeProfessionalInfos.Remove(employeeBankInfo);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
        }
#endregion

        #region Insurance Queries
        public EmployeeInsuranceInfo GetInsuranceInfo(int? EmployeeInsuranceInfoId,int UserId)
        {
            EmployeeInsuranceInfo _employeeInsuranceInfo = null;
            try
            {
                var employeeInsuranceInfo = context.EmployeeInsuranceInfos.Where(s => s.Id == EmployeeInsuranceInfoId && s.UserId == UserId).FirstOrDefault();
                _employeeInsuranceInfo = GetEmployeeInsuranceMapper(employeeInsuranceInfo);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return _employeeInsuranceInfo;

        }

        public int AddInsuranceInfo(EmployeeInsuranceInfo InsuranceInfo)
        {
            Entities.EmployeeInsuranceInfo employeeInsuranceInfo = new Entities.EmployeeInsuranceInfo();
            try
            {
                employeeInsuranceInfo.NameAsPerAadhar = InsuranceInfo.NameAsPerAadhar;
                employeeInsuranceInfo.Relationship = InsuranceInfo.Relationship;
                employeeInsuranceInfo.Gender = InsuranceInfo.Gender;
                employeeInsuranceInfo.DateOfBirthAsPerAadhar = InsuranceInfo.DateOfBirthAsPerAadhar;
                context.EmployeeInsuranceInfos.Add(employeeInsuranceInfo);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeInsuranceInfo.Id;//added insuranceId value
        }

        public int UpdateInsuranceInfo(EmployeeInsuranceInfo InsuranceInfo)
        {
            var employeeInsuranceInfo = context.EmployeeInsuranceInfos.Where(s => s.Id == InsuranceInfo.Id && s.UserId == InsuranceInfo.UserId).FirstOrDefault();
            try
            {
                employeeInsuranceInfo.NameAsPerAadhar = InsuranceInfo.NameAsPerAadhar;
                employeeInsuranceInfo.Relationship = InsuranceInfo.Relationship;
                employeeInsuranceInfo.Gender = InsuranceInfo.Gender;
                employeeInsuranceInfo.DateOfBirthAsPerAadhar = InsuranceInfo.DateOfBirthAsPerAadhar;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeInsuranceInfo.Id;//updated employeeinsuranceInfoId value
        }

        public void DeleteInsuranceInfo(int EmployeeInsuranceInfoId,int UserId)
        {
            try
            {
                var employeeInsuranceInfo = context.EmployeeInsuranceInfos.Where(s => s.Id == EmployeeInsuranceInfoId && s.UserId == UserId).FirstOrDefault();
                if (employeeInsuranceInfo != null)
                {
                    context.EmployeeInsuranceInfos.Remove(employeeInsuranceInfo);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
        }
#endregion

        #region PF and ESI queries
        public EmployeePFandESIInfo GetPFAndESIInfo(int? EmployeePFAndESIInfoId,int UserId)
        {
            EmployeePFandESIInfo _employeePFandESIInfo=null;
            try
            {
                var employeePFAndESIInfo = context.EmployeePFandESIInfos.Where(s => s.Id == EmployeePFAndESIInfoId && s.UserId == UserId).FirstOrDefault();
                _employeePFandESIInfo = GetPFandESIInfoMapper(employeePFAndESIInfo);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return _employeePFandESIInfo;
        }

        public int AddPFAndESIInfo(EmployeePFandESIInfo PFAndESIInfo)
        {
            Entities.EmployeePFandESIInfo employeePFAndESIInfo = new Entities.EmployeePFandESIInfo();
            try
            {
                employeePFAndESIInfo.UAN = PFAndESIInfo.UAN;
                employeePFAndESIInfo.ESIN = PFAndESIInfo.ESIN;
                context.EmployeePFandESIInfos.Add(employeePFAndESIInfo);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeePFAndESIInfo.Id;//added PfId value
        }

        public int UpdatePFAndESIInfo(EmployeePFandESIInfo PFAndESIInfo)
        {
            var employeePFandESIInfo = context.EmployeePFandESIInfos.Where(s => s.Id == PFAndESIInfo.Id && s.UserId == PFAndESIInfo.UserId).FirstOrDefault();
            try
            {
                employeePFandESIInfo.UAN = PFAndESIInfo.UAN;
                employeePFandESIInfo.ESIN = PFAndESIInfo.ESIN;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeePFandESIInfo.Id;//updated employeePfInfoId value
        }

        public void DeletePFAndESIInfo(int EmployeePFAndESIInfoId,int UserId)
        {
            try
            {
                var employeePFandESIInfo = context.EmployeePFandESIInfos.Where(s => s.Id == EmployeePFAndESIInfoId && s.UserId == UserId).FirstOrDefault();
                if (employeePFandESIInfo != null)
                {
                    context.EmployeePFandESIInfos.Remove(employeePFandESIInfo);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
        }
#endregion

        #region Document Queries
        public EmployeeDocument GetDocument(int? EmployeeDocumentInfoId,int UserId)
        {
            EmployeeDocument _employeeDocument=null;
            try
            {
                var employeeDocumentInfo = context.EmployeeDocuments.Where(s => s.Id == EmployeeDocumentInfoId && s.UserId == UserId).FirstOrDefault();
                _employeeDocument = GetEmployeeDocumentMapper(employeeDocumentInfo);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return _employeeDocument;
        }

        public int AddDocument(EmployeeDocument DocumentInfo)
        {
            Entities.EmployeeDocument employeeDocumentInfo = new Entities.EmployeeDocument();
            try
            {
                employeeDocumentInfo.PassportPhoto = DocumentInfo.PassportPhoto;
                employeeDocumentInfo.Resume = DocumentInfo.Resume;
                employeeDocumentInfo.PanCard = DocumentInfo.PanCard;
                employeeDocumentInfo.AadharCard = DocumentInfo.AadharCard;
                employeeDocumentInfo.Passport = DocumentInfo.Passport;
                employeeDocumentInfo.VoterId = DocumentInfo.VoterId;
                employeeDocumentInfo.CurrentAddressProof = DocumentInfo.CurrentAddressProof;
                employeeDocumentInfo.PermanentAddressProof = DocumentInfo.PermanentAddressProof;
                employeeDocumentInfo.FathersAadharCard = DocumentInfo.FathersAadharCard;
                employeeDocumentInfo.MothersAadharCard = DocumentInfo.MothersAadharCard;
                employeeDocumentInfo.ThreeMonthsBankStatementOfSalaryAccount = DocumentInfo.ThreeMonthsBankStatementOfSalaryAccount;
                employeeDocumentInfo.Form16OrIncomeCertificateOfCurrentFinYear = DocumentInfo.Form16OrIncomeCertificateOfCurrentFinYear;
                employeeDocumentInfo.SSCOrEquivalent = DocumentInfo.SSCOrEquivalent;
                employeeDocumentInfo.IntermediateOrEquivalent = DocumentInfo.IntermediateOrEquivalent;
                employeeDocumentInfo.GraduationOrEquivalent = DocumentInfo.GraduationOrEquivalent;
                employeeDocumentInfo.PGOrEquivalent = DocumentInfo.PGOrEquivalent;
                employeeDocumentInfo.AdvancedDiplomaIfAny = DocumentInfo.AdvancedDiplomaIfAny;
                employeeDocumentInfo.ProfessionalCertificationsIfAny = DocumentInfo.ProfessionalCertificationsIfAny;
                context.EmployeeDocuments.Add(employeeDocumentInfo);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeDocumentInfo.Id;//added DocumentId value
        }

        public int UpdateDocument(EmployeeDocument DocumentInfo)
        {
            var employeeDocumentInfo = context.EmployeeDocuments.Where(s => s.Id == DocumentInfo.Id && s.UserId == DocumentInfo.UserId).FirstOrDefault();
            try
            {
                employeeDocumentInfo.PassportPhoto = DocumentInfo.PassportPhoto;
                employeeDocumentInfo.Resume = DocumentInfo.Resume;
                employeeDocumentInfo.PanCard = DocumentInfo.PanCard;
                employeeDocumentInfo.AadharCard = DocumentInfo.AadharCard;
                employeeDocumentInfo.Passport = DocumentInfo.Passport;
                employeeDocumentInfo.VoterId = DocumentInfo.VoterId;
                employeeDocumentInfo.CurrentAddressProof = DocumentInfo.CurrentAddressProof;
                employeeDocumentInfo.PermanentAddressProof = DocumentInfo.PermanentAddressProof;
                employeeDocumentInfo.FathersAadharCard = DocumentInfo.FathersAadharCard;
                employeeDocumentInfo.MothersAadharCard = DocumentInfo.MothersAadharCard;
                employeeDocumentInfo.ThreeMonthsBankStatementOfSalaryAccount = DocumentInfo.ThreeMonthsBankStatementOfSalaryAccount;
                employeeDocumentInfo.Form16OrIncomeCertificateOfCurrentFinYear = DocumentInfo.Form16OrIncomeCertificateOfCurrentFinYear;
                employeeDocumentInfo.SSCOrEquivalent = DocumentInfo.SSCOrEquivalent;
                employeeDocumentInfo.IntermediateOrEquivalent = DocumentInfo.IntermediateOrEquivalent;
                employeeDocumentInfo.GraduationOrEquivalent = DocumentInfo.GraduationOrEquivalent;
                employeeDocumentInfo.PGOrEquivalent = DocumentInfo.PGOrEquivalent;
                employeeDocumentInfo.AdvancedDiplomaIfAny = DocumentInfo.AdvancedDiplomaIfAny;
                employeeDocumentInfo.ProfessionalCertificationsIfAny = DocumentInfo.ProfessionalCertificationsIfAny;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeDocumentInfo.Id;//updated employeeDoucumentInfoId value
        }

        public void DeleteDocument(int EmployeeDocumentInfoId,int UserId)
        {
            try
            {
                var employeeDocumentInfo = context.EmployeeDocuments.Where(s => s.Id == EmployeeDocumentInfoId && s.UserId == UserId).FirstOrDefault();
                if (employeeDocumentInfo != null)
                {
                    context.EmployeeDocuments.Remove(employeeDocumentInfo);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
        }
        #endregion
    }
}
