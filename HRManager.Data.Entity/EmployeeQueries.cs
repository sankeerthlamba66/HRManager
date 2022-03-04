using System;
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
        private readonly Context context;
        public EmployeeQueries()
        {
            context = new Context();
        }

        public bool CheckAgreements(int UserId)
        {
            bool result = false;
            try
            {
                var agreement = context.EmployeeAgreementAcceptances.Where(s => s.UserId == UserId).FirstOrDefault();
                if (agreement.ServiceLevelAgreement == true)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return result;
        }

        public EmployeeProfessionalDocuments GetProfessionalDetails(int ProfessionalDetailsId)
        {
            EmployeeProfessionalDocuments professionalInfo = new EmployeeProfessionalDocuments();
            try
            {
                var employeeProfessionalInfo = context.EmployeeProfessionalInfos.FirstOrDefault(s => s.Id == ProfessionalDetailsId);
                //return mapper.Map<EmployeeProfessionalInfo>(employeeProfessionalInfo);
                if (employeeProfessionalInfo != null)
                {
                    professionalInfo.UserId = employeeProfessionalInfo.UserId;
                    professionalInfo.OrganizationName = employeeProfessionalInfo.OrganizationName;
                    professionalInfo.LastDesignation = employeeProfessionalInfo.LastDesignation;
                    professionalInfo.IsThisYourLastEmployment = employeeProfessionalInfo.IsThisYourLastEmployment;
                    professionalInfo.StartDate = employeeProfessionalInfo.StartDate;
                    professionalInfo.EndDate = employeeProfessionalInfo.EndDate;
                    professionalInfo.CTC = employeeProfessionalInfo.CTC;
                    professionalInfo.ReportingManagerName = employeeProfessionalInfo.ReportingManagerName;
                    professionalInfo.ReportingManagerEmailId = employeeProfessionalInfo.ReportingManagerEmailId;
                    professionalInfo.ReportingManagerMobileNumber = employeeProfessionalInfo.ReportingManagerMobileNumber;
                    professionalInfo.HRName = employeeProfessionalInfo.HRName;
                    professionalInfo.HREmailId = employeeProfessionalInfo.HREmailId;
                    professionalInfo.OfferLetterPath = employeeProfessionalInfo.OfferLetterPath;
                    professionalInfo.RelievingLetterPath = employeeProfessionalInfo.RelievingLetterPath;
                    professionalInfo.ExperienceLetterPath = employeeProfessionalInfo.ExperienceLetterPath;
                    professionalInfo.PaySlip1 = employeeProfessionalInfo.PaySlip1;
                    professionalInfo.PaySlip2 = employeeProfessionalInfo.PaySlip2;
                    professionalInfo.PaySlip3 = employeeProfessionalInfo.PaySlip3;
                   // professionalInfo.ReferenceEmailId = employeeProfessionalInfo.ReferenceEmailId;
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return professionalInfo;
        }
        public EmployeeAllDetails GetEmployeeAllDetails(int EmployeeUserId)
        {
            EmployeeAllDetails employeeAllDetails = new EmployeeAllDetails();
            try
            {
                employeeAllDetails.employeePersonalInfo = GetPersonalInfo(EmployeeUserId);
                employeeAllDetails.employeeProfessionalInfos = GetProfessionalInfo(EmployeeUserId);
                employeeAllDetails.employeeBankInfos = GetBankInfo(EmployeeUserId);
                employeeAllDetails.employeeInsuranceInfos = GetInsuranceInfo(EmployeeUserId);
                employeeAllDetails.employeePFandESIInfos = GetPFAndESIInfo(EmployeeUserId);
                employeeAllDetails.employeeDocuments = GetDocument(EmployeeUserId);
                employeeAllDetails.user = GetUserDetails(EmployeeUserId);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeAllDetails;

        }

        public User GetUserDetails(int UserId)
        {
            User user = new User();
            try
            {
                var UserDetails = context.Users.Where(s => s.Id == UserId).FirstOrDefault();
                if (UserDetails != null)
                {
                    user.Id = UserDetails.Id;
                    user.UserName = UserDetails.UserName;
                    user.Roles = UserDetails.Roles;
                    user.OrganizationId = UserDetails.OrganizationId;
                    
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return user;
        }

        public EmployeeShortSummary GetEmployeeShortSummary(int EmployeeId)
        {
            EmployeeShortSummary employeeShortSummary = new EmployeeShortSummary();
            try
            {
                var shortSummery = context.EmployeePersonalInfos.FirstOrDefault(s => s.Id == EmployeeId);
                if (shortSummery != null)
                {
                    employeeShortSummary.Id = shortSummery.Id;
                    employeeShortSummary.Name = GetEmployeeFullName(shortSummery.UserId).EmployeeFullName;
                    employeeShortSummary.Email = shortSummery.PersonalEmailId;
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeShortSummary;
        }

        public EmployeeName GetEmployeeFullName(int EmployeeUserId)
        {
            EmployeeName employeeName = new EmployeeName();
            try
            {
                var PersonalDetails = context.EmployeePersonalInfos.Where(s => s.UserId == EmployeeUserId).FirstOrDefault();
                if (PersonalDetails is not null)
                {
                    employeeName.EmployeeFullName = PersonalDetails.NameAsPerAadhar;
                }
            }
            catch(Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeName;
        }

        public EmployeeIndexModels GetEmployeeDetails(int UserId,int organizationId)
        {
            EmployeeIndexModels employeeIndexModels = new EmployeeIndexModels();
            try
            {
                employeeIndexModels.employeePersonalInfo = GetPersonalInfo(UserId);
                employeeIndexModels.employeeProfessionalInfos = GetProfessionalInfo(UserId);
                employeeIndexModels.employeeBankInfos = GetBankInfo(UserId);
                employeeIndexModels.employeeInsuranceInfos = GetInsuranceInfo(UserId);
                employeeIndexModels.employeePFandESIInfos = GetPFAndESIInfo(UserId);
                employeeIndexModels.employeeDocuments = GetDocument(UserId);
                employeeIndexModels.applicationTexts=GetApplicationTexts(organizationId);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeIndexModels;
        }

        public ApplicationText GetApplicationTexts(int organizationId)
        {
            ApplicationText applicationText = new ApplicationText();
            try
            {
                var appTexts = context.ApplicationTexts.Where(s=>s.OrganizationId== organizationId).FirstOrDefault();
                if (appTexts is not null)
                {
                    applicationText.ConfidentialityAgreement = appTexts.ConfidentialityAgreement;
                    applicationText.ServiceLevelAgreement = appTexts.ServiceLevelAgreement;
                    applicationText.BGVAcknowlwdgement = appTexts.BGVAcknowlwdgement;
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return applicationText;
        }

        #region Entities to Entity view Mappers returns EntityViews
        public EmployeePersonalInfo GetEmployeePersonalInfoMapper(Entities.EmployeePersonalInfo PersonalInfo)
        {
            EmployeePersonalInfo EmployeePersonalInfo = new EmployeePersonalInfo();
            try
            {
                EmployeePersonalInfo.Id = PersonalInfo.Id;
                EmployeePersonalInfo.FirstName = PersonalInfo.FirstName;
                EmployeePersonalInfo.MiddleName = PersonalInfo.MiddleName;
                EmployeePersonalInfo.LastName = PersonalInfo.LastName;
                EmployeePersonalInfo.Gender = PersonalInfo.Gender;
                EmployeePersonalInfo.MaritalStatus = PersonalInfo.MaritalStatus;
                EmployeePersonalInfo.DateOfBirth = PersonalInfo.DateOfBirth;
                EmployeePersonalInfo.MobileNumber = PersonalInfo.MobileNumber;
                EmployeePersonalInfo.PersonalEmailId = PersonalInfo.PersonalEmailId;
                EmployeePersonalInfo.CurrentAddressLine1 = PersonalInfo.CurrentAddressLine1;
                EmployeePersonalInfo.CurrentAddressLine2 = PersonalInfo.CurrentAddressLine2;
                EmployeePersonalInfo.CurrentAddressLine3 = PersonalInfo.CurrentAddressLine3;
                EmployeePersonalInfo.CurrentCity = PersonalInfo.CurrentCity;
                EmployeePersonalInfo.CurrentState = PersonalInfo.CurrentState;
                EmployeePersonalInfo.CurrentPinCode = PersonalInfo.CurrentPinCode;
                EmployeePersonalInfo.PermanentAddressLine1 = PersonalInfo.PermanentAddressLine1;
                EmployeePersonalInfo.PermanentAddressLine2 = PersonalInfo.PermanentAddressLine2;
                EmployeePersonalInfo.PermanentAddressLine3 = PersonalInfo.PermanentAddressLine3;
                EmployeePersonalInfo.PermanentCity = PersonalInfo.PermanentCity;
                EmployeePersonalInfo.PermanentState = PersonalInfo.PermanentState;
                EmployeePersonalInfo.PermanentPincode = PersonalInfo.PermanentPincode;
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
                //EmployeePersonalInfo.HowWereYouReferredToUs = PersonalInfo.HowWereYouReferredToUs;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return EmployeePersonalInfo;
        }

        public EmployeeProfessionalDocuments GetEmployeeProfessionalInfoMapper(Entities.EmployeeProfessionalInfo ProfessionalInfo)
        {
            EmployeeProfessionalDocuments employeeProfessionalInfo = new EmployeeProfessionalDocuments();
            try
            {
                employeeProfessionalInfo.Id = ProfessionalInfo.Id;
                employeeProfessionalInfo.UserId = ProfessionalInfo.UserId;
                employeeProfessionalInfo.OrganizationName = ProfessionalInfo.OrganizationName;
                employeeProfessionalInfo.IsThisYourLastEmployment = ProfessionalInfo.IsThisYourLastEmployment;
                employeeProfessionalInfo.LastDesignation = ProfessionalInfo.LastDesignation;
                employeeProfessionalInfo.StartDate = ProfessionalInfo.StartDate;
                employeeProfessionalInfo.EndDate = ProfessionalInfo.EndDate;
                employeeProfessionalInfo.CTC = ProfessionalInfo.CTC;
                employeeProfessionalInfo.ReportingManagerName = ProfessionalInfo.ReportingManagerName;
                employeeProfessionalInfo.ReportingManagerEmailId = ProfessionalInfo.ReportingManagerEmailId;
                employeeProfessionalInfo.ReportingManagerMobileNumber = ProfessionalInfo.ReportingManagerMobileNumber;
                employeeProfessionalInfo.HRName = ProfessionalInfo.HRName;
                employeeProfessionalInfo.HREmailId = ProfessionalInfo.HREmailId;
                employeeProfessionalInfo.OfferLetterPath = ProfessionalInfo.OfferLetterPath;
                employeeProfessionalInfo.RelievingLetterPath = ProfessionalInfo.RelievingLetterPath;
                employeeProfessionalInfo.ExperienceLetterPath = ProfessionalInfo.ExperienceLetterPath;
                employeeProfessionalInfo.PaySlip1 = ProfessionalInfo.PaySlip1;
                employeeProfessionalInfo.PaySlip2 = ProfessionalInfo.PaySlip2;
                employeeProfessionalInfo.PaySlip3 = ProfessionalInfo.PaySlip3;
                //employeeProfessionalInfo.ReferenceEmailId= ProfessionalInfo.ReferenceEmailId;
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
                employeeBankInfo.Id = BankInfo.Id;
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
                employeeInsuranceInfo.Id = InsuranceInfo.Id;
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
                employeePFandESIInfo.Id = PFAndESIInfo.Id;
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
                employeeDocumentInfo.Id = DocumentInfo.Id;
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
            EmployeePersonalInfo _employeePersonalInfo = new EmployeePersonalInfo();
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
        public EmployeePersonalInfo GetPersonalInfo(int UserId)
        {
            EmployeePersonalInfo _employeePersonalInfo = null;
            try
            {
                var employeePersonalInfo = context.EmployeePersonalInfos.FirstOrDefault(s => s.UserId == UserId);
                if (employeePersonalInfo is not null)
                { _employeePersonalInfo = GetEmployeePersonalInfoMapper(employeePersonalInfo); }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return _employeePersonalInfo;
        }

        public string GenerateEmployeeId(int UserId, int OrganizationId)
        {
            StringBuilder employeeId = new StringBuilder(UserId.ToString());
            while(employeeId.Length<4)
            {
                employeeId.Insert(0,"0");
            }
            var organization = context.Organizations.Where(s => s.Id == OrganizationId).FirstOrDefault();
            if (organization is not null)
            {
                if (organization.OrganizationName.ToString().Contains("TekFriday"))
                {
                    employeeId.Insert(0, "T");
                }
                else if(organization.OrganizationName.ToString().Contains("Vivifi"))
                {
                    employeeId.Insert(0, "T");
                }
            }
            return employeeId.ToString();

        }
        public int AddPersonalInfo(EmployeePersonalInfo personalInfo,int OrganizationId)
        {
            Entities.EmployeePersonalInfo employeePersonalInfo = new Entities.EmployeePersonalInfo();
            try
            {
                
                if (personalInfo is not null)
                {
                    employeePersonalInfo.UserId = personalInfo.UserId;
                    employeePersonalInfo.EmployeeId = GenerateEmployeeId(personalInfo.UserId,OrganizationId);
                    employeePersonalInfo.FirstName = personalInfo.FirstName;
                    employeePersonalInfo.MiddleName = personalInfo.MiddleName;
                    employeePersonalInfo.LastName = personalInfo.LastName;
                    employeePersonalInfo.Gender = personalInfo.Gender;
                    employeePersonalInfo.MaritalStatus = personalInfo.MaritalStatus;
                    employeePersonalInfo.DateOfBirth = personalInfo.DateOfBirth;
                    employeePersonalInfo.MobileNumber = personalInfo.MobileNumber;
                    employeePersonalInfo.PersonalEmailId = personalInfo.PersonalEmailId;
                    employeePersonalInfo.CurrentAddressLine1 = personalInfo.CurrentAddressLine1;
                    employeePersonalInfo.CurrentAddressLine2 = personalInfo.CurrentAddressLine2;
                    employeePersonalInfo.CurrentAddressLine3 = personalInfo.CurrentAddressLine3;
                    employeePersonalInfo.CurrentCity = personalInfo.CurrentCity;
                    employeePersonalInfo.CurrentState = personalInfo.CurrentState;
                    employeePersonalInfo.CurrentPinCode = personalInfo.CurrentPinCode;
                    employeePersonalInfo.PermanentAddressLine1 = personalInfo.PermanentAddressLine1;
                    employeePersonalInfo.PermanentAddressLine2 = personalInfo.PermanentAddressLine2;
                    employeePersonalInfo.PermanentAddressLine3 = personalInfo.PermanentAddressLine3;
                    employeePersonalInfo.PermanentCity = personalInfo.PermanentCity;
                    employeePersonalInfo.PermanentState = personalInfo.PermanentState;
                    employeePersonalInfo.PermanentPincode = personalInfo.PermanentPincode;
                    employeePersonalInfo.BloodGroup = personalInfo.BloodGroup;
                    employeePersonalInfo.EmergencyContactName = personalInfo.EmergencyContactName;
                    employeePersonalInfo.EmergencyContactNumber = personalInfo.EmergencyContactNumber;
                    employeePersonalInfo.RelationshipWithContact = personalInfo.RelationshipWithContact;
                    employeePersonalInfo.PanCardNumber = personalInfo.PanCardNumber;
                    employeePersonalInfo.NameAsPerAadhar = personalInfo.NameAsPerAadhar;
                    employeePersonalInfo.AadharCardNumber = personalInfo.AadharCardNumber;
                    employeePersonalInfo.FathersNameAsPerAadhar = personalInfo.FathersNameAsPerAadhar;
                    employeePersonalInfo.FathersMobileNumber = personalInfo.FathersMobileNumber;
                    employeePersonalInfo.MothersNameAsPerAadhar = personalInfo.MothersNameAsPerAadhar;
                    employeePersonalInfo.UpdatedDate = DateTime.Now;
                    employeePersonalInfo.CreatedDate = DateTime.Now;
                    employeePersonalInfo.CreatedBy = personalInfo.CreatedBy;
                    employeePersonalInfo.UpdatedBy = personalInfo.CreatedBy;
                    context.Add(employeePersonalInfo);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeePersonalInfo.Id;
        }

        public int UpdatePersonalInfo(EmployeePersonalInfo PersonalInfo)
        {
            try
            {
                var EmployeePersonalInfo = context.EmployeePersonalInfos.FirstOrDefault(s => s.Id == PersonalInfo.Id && s.UserId == PersonalInfo.UserId);
                if (EmployeePersonalInfo is not null)
                {
                    EmployeePersonalInfo.FirstName = PersonalInfo.FirstName;
                    EmployeePersonalInfo.MiddleName = PersonalInfo.MiddleName;
                    EmployeePersonalInfo.LastName = PersonalInfo.LastName;
                    EmployeePersonalInfo.Gender = PersonalInfo.Gender;
                    EmployeePersonalInfo.MaritalStatus = PersonalInfo.MaritalStatus;
                    EmployeePersonalInfo.DateOfBirth = PersonalInfo.DateOfBirth;
                    EmployeePersonalInfo.MobileNumber = PersonalInfo.MobileNumber;
                    EmployeePersonalInfo.PersonalEmailId = PersonalInfo.PersonalEmailId;
                    EmployeePersonalInfo.CurrentAddressLine1 = PersonalInfo.CurrentAddressLine1;
                    EmployeePersonalInfo.CurrentAddressLine2 = PersonalInfo.CurrentAddressLine2;
                    EmployeePersonalInfo.CurrentAddressLine3 = PersonalInfo.CurrentAddressLine3;
                    EmployeePersonalInfo.CurrentCity = PersonalInfo.CurrentCity;
                    EmployeePersonalInfo.CurrentState = PersonalInfo.CurrentState;
                    EmployeePersonalInfo.CurrentPinCode = PersonalInfo.CurrentPinCode;
                    EmployeePersonalInfo.PermanentAddressLine1 = PersonalInfo.PermanentAddressLine1;
                    EmployeePersonalInfo.PermanentAddressLine2 = PersonalInfo.PermanentAddressLine2;
                    EmployeePersonalInfo.PermanentAddressLine3 = PersonalInfo.PermanentAddressLine3;
                    EmployeePersonalInfo.PermanentCity = PersonalInfo.PermanentCity;
                    EmployeePersonalInfo.PermanentState = PersonalInfo.PermanentState;
                    EmployeePersonalInfo.PermanentPincode = PersonalInfo.PermanentPincode;
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
                    //EmployeePersonalInfo.HowWereYouReferredToUs = PersonalInfo.HowWereYouReferredToUs;
                    EmployeePersonalInfo.UpdatedBy = PersonalInfo.UpdatedBy;
                    EmployeePersonalInfo.UpdatedDate = DateTime.Now;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return Convert.ToInt32(PersonalInfo.Id);//return the updated id here
        }

        #endregion

        #region ProfessionalInfo Queries
        public EmployeeProfessionalDocuments GetProfessionalInfo(int? ProfessionalInfoId,int UserId)
        {
            EmployeeProfessionalDocuments employeeProfessionalInfo = new EmployeeProfessionalDocuments();
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

        public List<EmployeeProfessionalDocuments> GetProfessionalInfo(int UserId)
        {
            List<EmployeeProfessionalDocuments> employeeProfessionalInfo = new List<EmployeeProfessionalDocuments>();
            try
            {
                var professionalInfo = context.EmployeeProfessionalInfos.Where(s =>s.UserId == UserId).ToList();
                foreach (var item in professionalInfo)
                {
                    employeeProfessionalInfo.Add(GetEmployeeProfessionalInfoMapper(item));
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeProfessionalInfo;//list to be returned
        }

        public int AddProfessionalInfo(EmployeeProfessionalDocuments ProfessionalInfo)
        {
            Entities.EmployeeProfessionalInfo employeeProfessionalInfo = new Entities.EmployeeProfessionalInfo();
            try
            {
                employeeProfessionalInfo.UserId = ProfessionalInfo.UserId;
                employeeProfessionalInfo.OrganizationName = ProfessionalInfo.OrganizationName;
                employeeProfessionalInfo.IsThisYourLastEmployment = ProfessionalInfo.IsThisYourLastEmployment;
                employeeProfessionalInfo.LastDesignation = ProfessionalInfo.LastDesignation;
                employeeProfessionalInfo.StartDate = ProfessionalInfo.StartDate;
                employeeProfessionalInfo.EndDate = ProfessionalInfo.EndDate;
                employeeProfessionalInfo.CTC = ProfessionalInfo.CTC;
                employeeProfessionalInfo.ReportingManagerName = ProfessionalInfo.ReportingManagerName;
                employeeProfessionalInfo.ReportingManagerEmailId = ProfessionalInfo.ReportingManagerEmailId;
                employeeProfessionalInfo.ReportingManagerMobileNumber = ProfessionalInfo.ReportingManagerMobileNumber;
                employeeProfessionalInfo.HRName = ProfessionalInfo.HRName;
                employeeProfessionalInfo.HREmailId = ProfessionalInfo.HREmailId;
                employeeProfessionalInfo.OfferLetterPath = ProfessionalInfo.OfferLetterPath;
                employeeProfessionalInfo.RelievingLetterPath = ProfessionalInfo.RelievingLetterPath;
                employeeProfessionalInfo.ExperienceLetterPath = ProfessionalInfo.ExperienceLetterPath;
                employeeProfessionalInfo.PaySlip1 = ProfessionalInfo.PaySlip1;
                employeeProfessionalInfo.PaySlip2 = ProfessionalInfo.PaySlip2;
                employeeProfessionalInfo.PaySlip3 = ProfessionalInfo.PaySlip3;
                //employeeProfessionalInfo.ReferenceEmailId = ProfessionalInfo.ReferenceEmailId;
                employeeProfessionalInfo.CreatedBy = ProfessionalInfo.CreatedBy;
                employeeProfessionalInfo.CreatedDate = DateTime.Now;
                employeeProfessionalInfo.UpdatedBy = ProfessionalInfo.CreatedBy;
                employeeProfessionalInfo.UpdatedDate = DateTime.Now;
                context.EmployeeProfessionalInfos.Add(employeeProfessionalInfo);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeProfessionalInfo.Id;//added ProfessionalId value
        }

        public int UpdateProfessionalInfo(EmployeeProfessionalDocuments ProfessionalInfo)
        {
            try
            {
                var employeeProfessionalInfo = context.EmployeeProfessionalInfos.FirstOrDefault(s => s.Id == ProfessionalInfo.Id && s.UserId == ProfessionalInfo.UserId);
                if (employeeProfessionalInfo != null)
                {
                    employeeProfessionalInfo.OrganizationName = ProfessionalInfo.OrganizationName;
                    employeeProfessionalInfo.IsThisYourLastEmployment = ProfessionalInfo.IsThisYourLastEmployment;
                    employeeProfessionalInfo.LastDesignation = ProfessionalInfo.LastDesignation;
                    employeeProfessionalInfo.StartDate = ProfessionalInfo.StartDate;
                    employeeProfessionalInfo.EndDate = ProfessionalInfo.EndDate;
                    employeeProfessionalInfo.CTC = ProfessionalInfo.CTC;
                    employeeProfessionalInfo.ReportingManagerName = ProfessionalInfo.ReportingManagerName;
                    employeeProfessionalInfo.ReportingManagerEmailId = ProfessionalInfo.ReportingManagerEmailId;
                    employeeProfessionalInfo.ReportingManagerMobileNumber = ProfessionalInfo.ReportingManagerMobileNumber;
                    employeeProfessionalInfo.HRName = ProfessionalInfo.HRName;
                    employeeProfessionalInfo.HREmailId = ProfessionalInfo.HREmailId;
                    if (!string.IsNullOrEmpty(ProfessionalInfo.OfferLetterPath))
                    { employeeProfessionalInfo.OfferLetterPath = ProfessionalInfo.OfferLetterPath; }
                    if (!string.IsNullOrEmpty(ProfessionalInfo.RelievingLetterPath))
                    { employeeProfessionalInfo.RelievingLetterPath = ProfessionalInfo.RelievingLetterPath; }
                    if (!string.IsNullOrEmpty(ProfessionalInfo.ExperienceLetterPath))
                    { employeeProfessionalInfo.ExperienceLetterPath = ProfessionalInfo.ExperienceLetterPath; }
                    if (!string.IsNullOrEmpty(ProfessionalInfo.PaySlip1))
                    { employeeProfessionalInfo.PaySlip1 = ProfessionalInfo.PaySlip1; }
                    if (!string.IsNullOrEmpty(ProfessionalInfo.PaySlip2))
                    { employeeProfessionalInfo.PaySlip2 = ProfessionalInfo.PaySlip2; }
                    if (!string.IsNullOrEmpty(ProfessionalInfo.PaySlip3))
                    { employeeProfessionalInfo.PaySlip3 = ProfessionalInfo.PaySlip3; }
                    //employeeProfessionalInfo.ReferenceEmailId = ProfessionalInfo.ReferenceEmailId;
                    employeeProfessionalInfo.UpdatedBy = ProfessionalInfo.UpdatedBy;
                    employeeProfessionalInfo.UpdatedDate = DateTime.Now;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return Convert.ToInt32(ProfessionalInfo.Id);//updated professionalId value
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

        public List<EmployeeBankInfo> GetBankInfo(int UserId)
        {
            List<EmployeeBankInfo> employeeBankInfo = new List<EmployeeBankInfo>();
            try
            {
                var bankInfo = context.EmployeeBankInfos.Where(s => s.UserId == UserId).ToList();
                foreach (var item in bankInfo)
                { employeeBankInfo.Add(GetEmployeeBankMapper(item)); }
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
                employeeBankInfo.UserId = BankInfo.UserId;
                employeeBankInfo.BankName = BankInfo.BankName;
                employeeBankInfo.NameAsPerBankAccount = BankInfo.NameAsPerBankAccount;
                employeeBankInfo.AccountNumber = BankInfo.AccountNumber;
                employeeBankInfo.BranchName = BankInfo.BranchName;
                employeeBankInfo.IFSCCode = BankInfo.IFSCCode;
                employeeBankInfo.CreatedBy = BankInfo.CreatedBy;
                employeeBankInfo.CreatedDate = DateTime.Now;
                employeeBankInfo.UpdatedBy = BankInfo.CreatedBy;
                employeeBankInfo.UpdatedDate = DateTime.Now;
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
            try
            {
                var employeeBankInfo = context.EmployeeBankInfos.Where(s => s.Id == BankInfo.Id && s.UserId == BankInfo.UserId).FirstOrDefault();
                if (employeeBankInfo != null)
                {
                    employeeBankInfo.BankName = BankInfo.BankName;
                    employeeBankInfo.NameAsPerBankAccount = BankInfo.NameAsPerBankAccount;
                    employeeBankInfo.AccountNumber = BankInfo.AccountNumber;
                    employeeBankInfo.BranchName = BankInfo.BranchName;
                    employeeBankInfo.IFSCCode = BankInfo.IFSCCode;
                    employeeBankInfo.UpdatedBy = BankInfo.UpdatedBy;
                    employeeBankInfo.UpdatedDate = DateTime.Now;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return Convert.ToInt32(BankInfo.Id);//updated employeeBankInfoId value
        }

        public void DeleteBankInfo(int EmployeeBankInfoId,int UserId)
        {
            try
            {
                var employeeBankInfo = context.EmployeeBankInfos.Where(s => s.Id == EmployeeBankInfoId && s.UserId == UserId).FirstOrDefault();
                if (employeeBankInfo != null)
                {
                    context.EmployeeBankInfos.Remove(employeeBankInfo);
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

        public List<EmployeeInsuranceInfo> GetInsuranceInfo(int UserId)
        {
            List<EmployeeInsuranceInfo> _employeeInsuranceInfo = new List<EmployeeInsuranceInfo>();
            try
            {
                var employeeInsuranceInfo = context.EmployeeInsuranceInfos.Where(s => s.UserId == UserId).ToList();
                foreach (var item in employeeInsuranceInfo)
                {
                    _employeeInsuranceInfo.Add(GetEmployeeInsuranceMapper(item));
                }
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
                employeeInsuranceInfo.UserId = InsuranceInfo.UserId;
                employeeInsuranceInfo.NameAsPerAadhar = InsuranceInfo.NameAsPerAadhar;
                employeeInsuranceInfo.Relationship = InsuranceInfo.Relationship;
                employeeInsuranceInfo.Gender = InsuranceInfo.Gender;
                employeeInsuranceInfo.DateOfBirthAsPerAadhar = InsuranceInfo.DateOfBirthAsPerAadhar;
                employeeInsuranceInfo.CreatedDate = DateTime.Now;
                employeeInsuranceInfo.CreatedBy = InsuranceInfo.CreatedBy;
                employeeInsuranceInfo.UpdatedDate= DateTime.Now;
                employeeInsuranceInfo.UpdatedBy = InsuranceInfo.CreatedBy;
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
            try
            {
                var employeeInsuranceInfo = context.EmployeeInsuranceInfos.Where(s => s.Id == InsuranceInfo.Id && s.UserId == InsuranceInfo.UserId).FirstOrDefault();
                if (employeeInsuranceInfo != null)
                {
                    employeeInsuranceInfo.NameAsPerAadhar = InsuranceInfo.NameAsPerAadhar;
                    employeeInsuranceInfo.Relationship = InsuranceInfo.Relationship;
                    employeeInsuranceInfo.Gender = InsuranceInfo.Gender;
                    employeeInsuranceInfo.DateOfBirthAsPerAadhar = InsuranceInfo.DateOfBirthAsPerAadhar;
                    employeeInsuranceInfo.UpdatedBy = InsuranceInfo.UpdatedBy;
                    employeeInsuranceInfo.UpdatedDate = DateTime.Now;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return Convert.ToInt32(InsuranceInfo.Id);//updated employeeinsuranceInfoId value
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

        public List<EmployeePFandESIInfo> GetPFAndESIInfo(int UserId)
        {
            List<EmployeePFandESIInfo> _employeePFandESIInfo = new List<EmployeePFandESIInfo>();
            try
            {
                var employeePFAndESIInfo = context.EmployeePFandESIInfos.Where(s=>s.UserId == UserId).ToList();
                foreach (var item in employeePFAndESIInfo)
                {
                    _employeePFandESIInfo.Add(GetPFandESIInfoMapper(item));
                }
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
                employeePFAndESIInfo.UserId = PFAndESIInfo.UserId;
                employeePFAndESIInfo.UAN = PFAndESIInfo.UAN;
                employeePFAndESIInfo.ESIN = PFAndESIInfo.ESIN;
                employeePFAndESIInfo.CreatedBy = PFAndESIInfo.CreatedBy;
                employeePFAndESIInfo.CreatedDate = DateTime.Now;
                employeePFAndESIInfo.UpdatedDate = DateTime.Now;
                employeePFAndESIInfo.UpdatedBy = PFAndESIInfo.CreatedBy;
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
            try
            {
                var employeePFandESIInfo = context.EmployeePFandESIInfos.Where(s => s.Id == PFAndESIInfo.Id && s.UserId == PFAndESIInfo.UserId).FirstOrDefault();
                if (employeePFandESIInfo != null)
                {
                    employeePFandESIInfo.UAN = PFAndESIInfo.UAN;
                    employeePFandESIInfo.ESIN = PFAndESIInfo.ESIN;
                    employeePFandESIInfo.UpdatedDate = DateTime.Now;
                    employeePFandESIInfo.UpdatedBy = PFAndESIInfo.UpdatedBy;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return Convert.ToInt32(PFAndESIInfo.Id);//updated employeePfInfoId value
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

        public EmployeeDocument GetDocument(int UserId)
        {
            EmployeeDocument _employeeDocument = null;
            try
            {
                var employeeDocumentInfo = context.EmployeeDocuments.Where(s => s.UserId == UserId).FirstOrDefault();
                if (employeeDocumentInfo is not null)
                { _employeeDocument = GetEmployeeDocumentMapper(employeeDocumentInfo); }
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
                employeeDocumentInfo.UserId = DocumentInfo.UserId;
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
                employeeDocumentInfo.CreatedDate = DateTime.Now;
                employeeDocumentInfo.CreatedBy = DocumentInfo.CreatedBy;
                employeeDocumentInfo.UpdatedDate = DateTime.Now;
                employeeDocumentInfo.UpdatedBy = DocumentInfo.CreatedBy;
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
            try
            {
                var employeeDocumentInfo = context.EmployeeDocuments.Where(s => s.Id == DocumentInfo.Id && s.UserId == DocumentInfo.UserId).FirstOrDefault();
                if (employeeDocumentInfo is not null)
                {
                    if (!string.IsNullOrEmpty(DocumentInfo.PassportPhoto))
                    { employeeDocumentInfo.PassportPhoto = DocumentInfo.PassportPhoto; }
                    if (!string.IsNullOrEmpty(DocumentInfo.Resume))
                    { employeeDocumentInfo.Resume = DocumentInfo.Resume; }
                    if (!string.IsNullOrEmpty(DocumentInfo.PanCard))
                    { employeeDocumentInfo.PanCard = DocumentInfo.PanCard; }
                    if (!string.IsNullOrEmpty(DocumentInfo.AadharCard))
                    { employeeDocumentInfo.AadharCard = DocumentInfo.AadharCard; }
                    if (!string.IsNullOrEmpty(DocumentInfo.Passport))
                    { employeeDocumentInfo.Passport = DocumentInfo.Passport; }
                    if (!string.IsNullOrEmpty(DocumentInfo.VoterId))
                    { employeeDocumentInfo.VoterId = DocumentInfo.VoterId; }
                    if (!string.IsNullOrEmpty(DocumentInfo.CurrentAddressProof))
                    { employeeDocumentInfo.CurrentAddressProof = DocumentInfo.CurrentAddressProof; }
                    if (!string.IsNullOrEmpty(DocumentInfo.PermanentAddressProof))
                    { employeeDocumentInfo.PermanentAddressProof = DocumentInfo.PermanentAddressProof; }
                    if (!string.IsNullOrEmpty(DocumentInfo.FathersAadharCard))
                    { employeeDocumentInfo.FathersAadharCard = DocumentInfo.FathersAadharCard; }
                    if (!string.IsNullOrEmpty(DocumentInfo.MothersAadharCard))
                    { employeeDocumentInfo.MothersAadharCard = DocumentInfo.MothersAadharCard; }
                    if (!string.IsNullOrEmpty(DocumentInfo.ThreeMonthsBankStatementOfSalaryAccount))
                    { employeeDocumentInfo.ThreeMonthsBankStatementOfSalaryAccount = DocumentInfo.ThreeMonthsBankStatementOfSalaryAccount; }
                    if (!string.IsNullOrEmpty(DocumentInfo.Form16OrIncomeCertificateOfCurrentFinYear))
                    { employeeDocumentInfo.Form16OrIncomeCertificateOfCurrentFinYear = DocumentInfo.Form16OrIncomeCertificateOfCurrentFinYear; }
                    if (!string.IsNullOrEmpty(DocumentInfo.SSCOrEquivalent))
                    { employeeDocumentInfo.SSCOrEquivalent = DocumentInfo.SSCOrEquivalent; }
                    if (!string.IsNullOrEmpty(DocumentInfo.IntermediateOrEquivalent))
                    { employeeDocumentInfo.IntermediateOrEquivalent = DocumentInfo.IntermediateOrEquivalent; }
                    if (!string.IsNullOrEmpty(DocumentInfo.GraduationOrEquivalent))
                    { employeeDocumentInfo.GraduationOrEquivalent = DocumentInfo.GraduationOrEquivalent; }
                    if (!string.IsNullOrEmpty(DocumentInfo.PGOrEquivalent))
                    { employeeDocumentInfo.PGOrEquivalent = DocumentInfo.PGOrEquivalent; }
                    if (!string.IsNullOrEmpty(DocumentInfo.AdvancedDiplomaIfAny))
                    { employeeDocumentInfo.AdvancedDiplomaIfAny = DocumentInfo.AdvancedDiplomaIfAny; }
                    if (!string.IsNullOrEmpty(DocumentInfo.ProfessionalCertificationsIfAny))
                    { employeeDocumentInfo.ProfessionalCertificationsIfAny = DocumentInfo.ProfessionalCertificationsIfAny; }
                    employeeDocumentInfo.UpdatedBy = DocumentInfo.UpdatedBy;
                    employeeDocumentInfo.UpdatedDate = DateTime.Now;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return Convert.ToInt32(DocumentInfo.Id);//updated employeeDoucumentInfoId value
        }

        public void DeleteDocument(int EmployeeDocumentInfoId,int UserId)
        {
            try
            {
                var employeeDocumentInfo = context.EmployeeDocuments.Where(s => s.Id == EmployeeDocumentInfoId && s.UserId == UserId).FirstOrDefault();
                //DeleteDocumentsFromFolder(employeeDocumentInfo);
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

        //public void DeleteDocumentsFromFolder(Entities.EmployeeDocument employeeDocumentInfo)
        //{
        //    try
        //    {
        //        if (!string.IsNullOrEmpty(employeeDocumentInfo.PassportPhoto))
        //        { File.Delete(employeeDocumentInfo.PassportPhoto); }
        //        if (!string.IsNullOrEmpty(employeeDocumentInfo.Resume))
        //        { File.Delete(employeeDocumentInfo.Resume); }
        //        if (!string.IsNullOrEmpty(employeeDocumentInfo.PanCard))
        //        { File.Delete(employeeDocumentInfo.PanCard); }
        //        if (!string.IsNullOrEmpty(employeeDocumentInfo.AadharCard))
        //        { File.Delete(employeeDocumentInfo.AadharCard); }
        //        if (!string.IsNullOrEmpty(employeeDocumentInfo.Passport))
        //        { File.Delete(employeeDocumentInfo.Passport); }
        //        if (!string.IsNullOrEmpty(employeeDocumentInfo.VoterId))
        //        { File.Delete(employeeDocumentInfo.VoterId); }
        //        if (!string.IsNullOrEmpty(employeeDocumentInfo.CurrentAddressProof))
        //        { File.Delete(employeeDocumentInfo.CurrentAddressProof); }
        //        if (!string.IsNullOrEmpty(employeeDocumentInfo.PermanentAddressProof))
        //        { File.Delete(employeeDocumentInfo.PermanentAddressProof); }
        //        if (!string.IsNullOrEmpty(employeeDocumentInfo.FathersAadharCard))
        //        { File.Delete(employeeDocumentInfo.FathersAadharCard); }
        //        if (!string.IsNullOrEmpty(employeeDocumentInfo.MothersAadharCard))
        //        { File.Delete(employeeDocumentInfo.MothersAadharCard); }
        //        if (!string.IsNullOrEmpty(employeeDocumentInfo.ThreeMonthsBankStatementOfSalaryAccount))
        //        { File.Delete(employeeDocumentInfo.ThreeMonthsBankStatementOfSalaryAccount); }
        //        if (!string.IsNullOrEmpty(employeeDocumentInfo.Form16OrIncomeCertificateOfCurrentFinYear))
        //        { File.Delete(employeeDocumentInfo.Form16OrIncomeCertificateOfCurrentFinYear); }
        //        if (!string.IsNullOrEmpty(employeeDocumentInfo.SSCOrEquivalent))
        //        { File.Delete(employeeDocumentInfo.SSCOrEquivalent); }
        //        if (!string.IsNullOrEmpty(employeeDocumentInfo.IntermediateOrEquivalent))
        //        { File.Delete(employeeDocumentInfo.IntermediateOrEquivalent); }
        //        if (!string.IsNullOrEmpty(employeeDocumentInfo.GraduationOrEquivalent))
        //        { File.Delete(employeeDocumentInfo.GraduationOrEquivalent); }
        //        if (!string.IsNullOrEmpty(employeeDocumentInfo.PGOrEquivalent))
        //        { File.Delete(employeeDocumentInfo.PGOrEquivalent); }
        //        if (!string.IsNullOrEmpty(employeeDocumentInfo.AdvancedDiplomaIfAny))
        //        { File.Delete(employeeDocumentInfo.AdvancedDiplomaIfAny); }
        //        if (!string.IsNullOrEmpty(employeeDocumentInfo.ProfessionalCertificationsIfAny))
        //        { File.Delete(employeeDocumentInfo.ProfessionalCertificationsIfAny); }
        //    }
        //    catch (Exception ex)
        //    {
        //        ErrorLogger.LogError(ex.Message);
        //    }
        //}
        #endregion

        #region mail
        public EmployeeSubmissionEMail GetEmployeeSubmissionEMailTemplates(User EmployeeUserDetails)
        {
            EmployeeSubmissionEMail MailTemplate = new EmployeeSubmissionEMail();
            try
            {
                var employeeSubmissionTemplates =context.ApplicationTexts.Where(s=>s.OrganizationId== EmployeeUserDetails.OrganizationId).FirstOrDefault();
                //hrMailTemplate.EmployeeSubmissionEMailSubjectTemplate = @"New Employee Details Updated";
                MailTemplate.EmployeeSubmissionEMailSubjectTemplate = employeeSubmissionTemplates.EmployeeSubmissionEMailSubjectTemplate;
                StringBuilder Body = new StringBuilder(employeeSubmissionTemplates.EmployeeSubmissionEMailBodyTemplate);
                Body.Replace("EmployeeID", EmployeeUserDetails.Id.ToString());
                Body.Replace("EmployeeUserName", GetEmployeeFullName((int)EmployeeUserDetails.Id).EmployeeFullName);
                Body.Replace("EmployeeUserMailId", EmployeeUserDetails.UserMailId);
                //Body.Append("Employee with user ID EmployeeID,name EmployeeUserName , with mail EmployeeUserMailId has uploaded all the documents, agreed to all the conditions and updated all the details. ");
                MailTemplate.EmployeeSubmissionEMailBodyTemplate = Body.ToString();
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return MailTemplate;
        }
        #endregion

        #region Employee Agreement Acceptance
        public void UpdateEmployeeAgreementAcceptance(int? employeeUserId,string employeeName)
        {             
            try
            {
                var employeeAgreementAcceptance =context.EmployeeAgreementAcceptances.Where(a => a.UserId == employeeUserId).FirstOrDefault();
                if (employeeAgreementAcceptance != null)
                {
                    employeeAgreementAcceptance.ConfidentialityAgreementAccepted = true;
                    employeeAgreementAcceptance.ServiceLevelAgreement = true;
                    employeeAgreementAcceptance.BGVAcknowledgement = true;
                    employeeAgreementAcceptance.UpdatedDate = DateTime.Now;
                    employeeAgreementAcceptance.UpdatedBy = employeeName;
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
