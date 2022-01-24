using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManager.Models.EntityViews;
using HRManager.Models.Views;
using HRManager.Models.ViewModels;
using AutoMapper;

namespace HRManager.Data.Entity
{
    public class EmployeeQueries
    {
        private readonly Context context = new Context();
        private readonly IMapper mapper;
        public EmployeeProfessionalInfo GetProfessionalDetails(int ProfessionalDetailsId)
        {
            //EmployeeProfessionalInfo professionalInfo = new EmployeeProfessionalInfo();
            var employeeProfessionalInfo = context.EmployeeProfessionalInfos.FirstOrDefault(s => s.Id == ProfessionalDetailsId);
            return mapper.Map<EmployeeProfessionalInfo>(employeeProfessionalInfo);

            //professionalInfo.OrganizationName = employeeProfessionalInfo.OrganizationName;
            //professionalInfo.IsThisYourLastEmployment = employeeProfessionalInfo.IsThisYourLastEmployment;
            //professionalInfo.StartDate = employeeProfessionalInfo.StartDate;
            //professionalInfo.EndDate = employeeProfessionalInfo.EndDate;
            //professionalInfo.CTC = employeeProfessionalInfo.CTC;
            //professionalInfo.ReportingManagerName = employeeProfessionalInfo.ReportingManagerName;
            //professionalInfo.ReportingManagerEmailId = employeeProfessionalInfo.ReportingManagerEmailId;
            //professionalInfo.HRName = employeeProfessionalInfo.HRName;
            //professionalInfo.HREmailId = employeeProfessionalInfo.HREmailId;
            //professionalInfo.OfferLetterPath = employeeProfessionalInfo.OfferLetterPath;
            //professionalInfo.RelievingLetterPath = employeeProfessionalInfo.RelievingLetterPath;
            //professionalInfo.ExperienceLetterPath = employeeProfessionalInfo.ExperienceLetterPath;
            //professionalInfo.PaySlip1 = employeeProfessionalInfo.PaySlip1;
            //professionalInfo.PaySlip2 = employeeProfessionalInfo.PaySlip2;
            //professionalInfo.PaySlip3 = employeeProfessionalInfo.PaySlip3;
            //return professionalInfo;
        }

        public EmployeeShortSummary GetEmployeeShortSummary(int EmployeeId)
        {
            EmployeeShortSummary employeeShortSummary = new EmployeeShortSummary();
            var shortSummery = context.EmployeePersonalInfos.FirstOrDefault(s => s.Id == EmployeeId);
            employeeShortSummary.Name = shortSummery.FirstName;
            employeeShortSummary.Email = shortSummery.PersonalEmailId;
            return employeeShortSummary;
        }

        #region Personal Info queries
        public EmployeePersonalInfo GetPersonalInfo(int? PersonalInfoId,int UserId)
        {
            var employeePersonalInfo = context.EmployeePersonalInfos.FirstOrDefault(s => s.Id == PersonalInfoId && s.UserId == UserId);
            return mapper.Map<EmployeePersonalInfo>(employeePersonalInfo);
        }

        public int UpdatePersonalInfo(EmployeePersonalInfo PersonalInfo)
        {
            var EmployeePersonalInfo = context.EmployeePersonalInfos.FirstOrDefault(s => s.Id == PersonalInfo.Id && s.UserId==PersonalInfo.UserId);
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
            return EmployeePersonalInfo.Id;//return the updated id here
        }

        #endregion

        #region ProfessionalInfo Queries
        public EmployeeProfessionalInfo GetProfessionalInfo(int? ProfessionalInfoId,int UserId)
        {
            var professionalInfo = context.EmployeeProfessionalInfos.FirstOrDefault(s => s.Id == ProfessionalInfoId && s.UserId == UserId);
            return mapper.Map<EmployeeProfessionalInfo>(professionalInfo);//list to be returned
        }

        public int AddProfessionalInfo(EmployeeProfessionalInfo ProfessionalInfo)
        {
            Entities.EmployeeProfessionalInfo employeeProfessionalInfo = mapper.Map<Entities.EmployeeProfessionalInfo>(ProfessionalInfo);
            context.EmployeeProfessionalInfos.Add(employeeProfessionalInfo);
            context.SaveChanges();
            return 0;//added ProfessionalId value
        }

        public int UpdateProfessionalInfo(EmployeeProfessionalInfo ProfessionalInfo)
        {
            var employeeProfessionalInfo = context.EmployeeProfessionalInfos.FirstOrDefault(s => s.Id == ProfessionalInfo.Id && s.UserId==ProfessionalInfo.UserId);
            employeeProfessionalInfo.OrganizationName = ProfessionalInfo.OrganizationName;
            employeeProfessionalInfo.IsThisYourLastEmployment  = ProfessionalInfo.IsThisYourLastEmployment;
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
            return employeeProfessionalInfo.Id;//updated professionalId value
        }

        public void DeleteProfessionalInfo(int ProfessionalInfoId,int UserId)
        {
            var ProfessionalInfo=context.EmployeeProfessionalInfos.Where(s=>s.Id==ProfessionalInfoId && s.UserId==UserId).FirstOrDefault();
            if (ProfessionalInfo != null)
            {
                context.EmployeeProfessionalInfos.Remove(ProfessionalInfo);
                context.SaveChanges();
            }
        }
#endregion

        #region BankInfo Queries
        public EmployeeBankInfo GetBankInfo(int? EmployeeBankInfoId,int UserId)
        {
            var bankInfo = context.EmployeeBankInfos.Where(s => s.Id == EmployeeBankInfoId && s.UserId == UserId).FirstOrDefault();
            return mapper.Map<EmployeeBankInfo>(bankInfo);
        }

        public int AddBankInfo(EmployeeBankInfo BankInfo)
        {
            Entities.EmployeeBankInfo employeeBankInfo = mapper.Map<Entities.EmployeeBankInfo>(BankInfo);
            context.EmployeeBankInfos.Add(employeeBankInfo);
            context.SaveChanges();
            return 0;//added bankId value
        }

        public int UpdateBankInfo(EmployeeBankInfo BankInfo)
        {
            var employeeBankInfo = context.EmployeeBankInfos.Where(s => s.Id == BankInfo.Id && s.UserId==BankInfo.UserId).FirstOrDefault();
            employeeBankInfo.BankName = BankInfo.BankName;
            employeeBankInfo.NameAsPerBankAccount = BankInfo.NameAsPerBankAccount;
            employeeBankInfo.AccountNumber = BankInfo.AccountNumber;
            employeeBankInfo.BranchName = BankInfo.BranchName;
            employeeBankInfo.IFSCCode = BankInfo.IFSCCode;
            context.SaveChanges();
            return employeeBankInfo.Id;//updated employeeBankInfoId value
        }

        public void DeleteBankInfo(int EmployeeBankInfoId,int UserId)
        {
            var employeeBankInfo = context.EmployeeProfessionalInfos.Where(s => s.Id == EmployeeBankInfoId && s.UserId == UserId).FirstOrDefault();
            if (employeeBankInfo != null)
            {
                context.EmployeeProfessionalInfos.Remove(employeeBankInfo);
                context.SaveChanges();
            }
        }
#endregion

        #region Insurance Queries
        public EmployeeInsuranceInfo GetInsuranceInfo(int? EmployeeInsuranceInfoId,int UserId)
        {
            var employeeInsuranceInfo = context.EmployeeBankInfos.Where(s => s.Id == EmployeeInsuranceInfoId && s.UserId == UserId).FirstOrDefault();
            return mapper.Map<EmployeeInsuranceInfo>(employeeInsuranceInfo);
        }

        public int AddInsuranceInfo(EmployeeInsuranceInfo InsuranceInfo)
        {
            Entities.EmployeeInsuranceInfo employeeInsuranceInfo = mapper.Map<Entities.EmployeeInsuranceInfo>(InsuranceInfo);
            context.EmployeeInsuranceInfos.Add(employeeInsuranceInfo);
            context.SaveChanges();
            return 0;//added insuranceId value
        }

        public int UpdateInsuranceInfo(EmployeeInsuranceInfo InsuranceInfo)
        {
            var employeeInsuranceInfo = context.EmployeeInsuranceInfos.Where(s => s.Id == InsuranceInfo.Id && s.UserId == InsuranceInfo.UserId).FirstOrDefault();
            employeeInsuranceInfo.NameAsPerAadhar = InsuranceInfo.NameAsPerAadhar;
            employeeInsuranceInfo.Relationship = InsuranceInfo.Relationship;
            employeeInsuranceInfo.Gender = InsuranceInfo.Gender;
            employeeInsuranceInfo.DateOfBirthAsPerAadhar = InsuranceInfo.DateOfBirthAsPerAadhar;
            return employeeInsuranceInfo.Id;//updated employeeinsuranceInfoId value
        }

        public void DeleteInsuranceInfo(int EmployeeInsuranceInfoId,int UserId)
        {
            var employeeInsuranceInfo = context.EmployeeInsuranceInfos.Where(s => s.Id == EmployeeInsuranceInfoId && s.UserId == UserId).FirstOrDefault();
            if (employeeInsuranceInfo != null)
            {
                context.EmployeeInsuranceInfos.Remove(employeeInsuranceInfo);
                context.SaveChanges();
            }
        }
#endregion

        #region PF and ESI queries
        public EmployeePFandESIInfo GetPFAndESIInfo(int? EmployeePFAndESIInfoId,int UserId)
        {
            var employeePFAndESIInfo = context.EmployeeBankInfos.Where(s => s.Id == EmployeePFAndESIInfoId && s.UserId == UserId).FirstOrDefault();
            return mapper.Map<EmployeePFandESIInfo>(employeePFAndESIInfo);
        }

        public int AddPFAndESIInfo(EmployeePFandESIInfo PFAndESIInfo)
        {
            Entities.EmployeePFandESIInfo employeePFAndESIInfo = mapper.Map<Entities.EmployeePFandESIInfo>(PFAndESIInfo);
            context.EmployeePFandESIInfos.Add(employeePFAndESIInfo);
            context.SaveChanges();
            return 0;//added PfId value
        }

        public int UpdatePFAndESIInfo(EmployeePFandESIInfo PFAndESIInfo)
        {
            var employeePFandESIInfo = context.EmployeePFandESIInfos.Where(s => s.Id == PFAndESIInfo.Id && s.UserId == PFAndESIInfo.UserId).FirstOrDefault();
            employeePFandESIInfo.UAN = PFAndESIInfo.UAN;
            employeePFandESIInfo.ESIN = PFAndESIInfo.ESIN;
            context.SaveChanges();
            return employeePFandESIInfo.Id;//updated employeePfInfoId value
        }

        public void DeletePFAndESIInfo(int EmployeePFAndESIInfoId,int UserId)
        {
            var employeePFandESIInfo = context.EmployeePFandESIInfos.Where(s => s.Id == EmployeePFAndESIInfoId && s.UserId == UserId).FirstOrDefault();
            if (employeePFandESIInfo != null)
            {
                context.EmployeePFandESIInfos.Remove(employeePFandESIInfo);
                context.SaveChanges();
            }
        }
#endregion

        #region Document Queries
        public EmployeeDocument GetDocument(int? EmployeeDocumentInfoId,int UserId)
        {
            var employeeDocumentInfo = context.EmployeeBankInfos.Where(s => s.Id == EmployeeDocumentInfoId && s.UserId == UserId).FirstOrDefault();
            return mapper.Map<EmployeeDocument>(employeeDocumentInfo);
        }

        public int AddDocument(EmployeeDocument DocumentInfo)
        {
            Entities.EmployeeDocument employeeDocumentInfo = mapper.Map<Entities.EmployeeDocument>(DocumentInfo);
            context.EmployeeDocuments.Add(employeeDocumentInfo);
            context.SaveChanges();
            return 0;//added DocumentId value
        }

        public int UpdateDocument(EmployeeDocument DocumentInfo)
        {
            var employeeDocumentInfo = context.EmployeeDocuments.Where(s => s.Id == DocumentInfo.Id && s.UserId == DocumentInfo.UserId).FirstOrDefault();
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
            return employeeDocumentInfo.Id;//updated employeeDoucumentInfoId value
        }

        public void DeleteDocumant(int EmployeeDocumentInfoId,int UserId)
        {
            var employeeDocumentInfo = context.EmployeeDocuments.Where(s => s.Id == EmployeeDocumentInfoId && s.UserId == UserId).FirstOrDefault();
            if (employeeDocumentInfo != null)
            {
                context.EmployeeDocuments.Remove(employeeDocumentInfo);
                context.SaveChanges();
            }
        }
        #endregion
    }
}
