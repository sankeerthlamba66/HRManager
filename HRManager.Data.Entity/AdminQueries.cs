using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManager.Models.Views;
using HRManager.Models.ViewModels;
using AutoMapper;
using HRManager.Models.EntityViews;
using HRManager.Utilities;

namespace HRManager.Data.Entity
{
    public class AdminQueries
    {
        private readonly Context context=new Context();

        public int AddEmployee(User user)
        {
            Entities.User UserDetail = new Entities.User();
            Entities.EmployeePersonalInfo employeePersonalInfo = new Entities.EmployeePersonalInfo();
            Entities.EmployeeAgreementAcceptance employeeAgreementAcceptance = new Entities.EmployeeAgreementAcceptance();
            try
            {
                var organization=context.Organizations.Where(s=>s.OrganizationName==user.OrganizationName).FirstOrDefault();
                user.OrganizationId=organization.Id;
                if (user is not null)
                {
                    UserDetail.UserName = user.UserName;
                    UserDetail.Roles = user.Roles;
                    UserDetail.OrganizationId = user.OrganizationId;
                    UserDetail.Password = user.Password;
                    UserDetail.UserMailId = user.UserMailId;
                    UserDetail.CreatedBy = user.CreatedBy;
                    UserDetail.UpdatedBy = user.CreatedBy;
                    UserDetail.CreatedDate = DateTime.Now;
                    UserDetail.UpdatedDate = DateTime.Now;
                    context.Add(UserDetail);
                    context.SaveChanges();
                    employeeAgreementAcceptance.ConfidentialityAgreementAccepted = false;
                    employeeAgreementAcceptance.ServiceLevelAgreement = false;
                    employeeAgreementAcceptance.BGVAcknowledgement = false;
                    employeeAgreementAcceptance.UserId = UserDetail.Id;
                    employeeAgreementAcceptance.UpdatedDate = DateTime.Now;
                    employeeAgreementAcceptance.CreatedDate = DateTime.Now;
                    employeeAgreementAcceptance.CreatedBy = user.CreatedBy;
                    employeeAgreementAcceptance.UpdatedBy = user.CreatedBy;
                    context.Add(employeeAgreementAcceptance);
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return UserDetail.Id;
        }

        public List<EmployeeTableSummary> GetRecentlyUpdatedEmployees()
        {
            List<EmployeeTableSummary> employeeTableSummary = new List<EmployeeTableSummary>();
            try
            {
                var employeesPersonlInfos = context.EmployeePersonalInfos.OrderByDescending(s => s.UpdatedDate).ToList();
                foreach (var item in employeesPersonlInfos)
                {
                    employeeTableSummary.Add(GetEmployeeTableSummaryMapper(item));
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeTableSummary;
        }
        public EmployeeTableSummary GetEmployeeTableSummaryMapper(Entities.EmployeePersonalInfo employeePersonalInfo)
        {
            EmployeeTableSummary employeeTableSummary = new EmployeeTableSummary();
            try
            {
                employeeTableSummary.Id = employeePersonalInfo.Id;
                if (!string.IsNullOrEmpty(employeePersonalInfo.MiddleName))
                { employeeTableSummary.EmployeeName = employeePersonalInfo.FirstName + " " + employeePersonalInfo.MiddleName + " " + employeePersonalInfo.LastName; }
                else
                { employeeTableSummary.EmployeeName = employeePersonalInfo.FirstName + " " + employeePersonalInfo.LastName; }
                employeeTableSummary.MobileNumber = employeePersonalInfo.MobileNumber;
                employeeTableSummary.PersonalEmailId = employeePersonalInfo.PersonalEmailId;
                employeeTableSummary.PanCard = employeePersonalInfo.PanCardNumber;
                employeeTableSummary.UserId = employeePersonalInfo.UserId;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeTableSummary;
        }
        public EmployeeCardSummary GetEmployeeCardSummaryMapper(Entities.EmployeePersonalInfo employeePersonalInfo)
        {
            EmployeeCardSummary employeeCardSummary = new EmployeeCardSummary();
            try
            {
                employeeCardSummary.Id = employeePersonalInfo.Id;
                if (!string.IsNullOrEmpty(employeePersonalInfo.MiddleName))
                { employeeCardSummary.EmployeeName = employeePersonalInfo.FirstName + " " + employeePersonalInfo.MiddleName + " " + employeePersonalInfo.LastName; }
                else 
                { employeeCardSummary.EmployeeName= employeePersonalInfo.FirstName+ " " + employeePersonalInfo.LastName; }
                employeeCardSummary.MobileNumber = employeePersonalInfo.MobileNumber;
                employeeCardSummary.PersonalEmailId = employeePersonalInfo.PersonalEmailId;
                employeeCardSummary.PanCard = employeePersonalInfo.PanCardNumber;
                employeeCardSummary.UserId = employeePersonalInfo.UserId;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeCardSummary;
        }

        public EmployeeProfessionalDocuments GetEmployeeProfessionalInfoMapper(Entities.EmployeeProfessionalInfo ProfessionalInfo)
        {
            EmployeeProfessionalDocuments employeeProfessionalInfo = new EmployeeProfessionalDocuments();
            try
            {
                employeeProfessionalInfo.Id = ProfessionalInfo.Id;
                employeeProfessionalInfo.UserId= ProfessionalInfo.UserId;
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
        public List<EmployeeTableSummary> GetRecentlyUpdatedEmployees(DateTime DateFrom, DateTime DateTo)
        {
            List<EmployeeTableSummary> employeeTableSummary = new List<EmployeeTableSummary>();
            try
            {
                var employeesPersonlInfos = context.EmployeePersonalInfos.Where(s => s.UpdatedDate <= DateTo && s.UpdatedDate >= DateFrom).OrderByDescending(s => s.UpdatedDate).ToList();
                foreach (var item in employeesPersonlInfos)
                {
                    employeeTableSummary.Add(GetEmployeeTableSummaryMapper(item));
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeTableSummary;
        }

        public List<EmployeeCardSummary> GetRecentlyUpdatedEmployeeCards()
        {
            List<EmployeeCardSummary> employeeCardsSummary = new List<EmployeeCardSummary>();
            try
            { 
                var employeesPersonlInfos = context.EmployeePersonalInfos.OrderByDescending(s => s.UpdatedDate).ToList();
                foreach (var item in employeesPersonlInfos)
                {
                    employeeCardsSummary.Add(GetEmployeeCardSummaryMapper(item));
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeCardsSummary;
        }

        public List<EmployeeCardSummary> GetRecentlyUpdatedEmployeeCards(DateTime DateFrom, DateTime DateTo)
        {
            List<EmployeeCardSummary> employeeCardsSummary = new List<EmployeeCardSummary>();
            try
            {
                var employeesPersonlInfos = context.EmployeePersonalInfos.Where(s => s.UpdatedDate <= DateTo && s.UpdatedDate >= DateFrom).OrderByDescending(s => s.UpdatedDate).ToList();
                foreach (var item in employeesPersonlInfos)
                {
                    employeeCardsSummary.Add(GetEmployeeCardSummaryMapper(item));
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeCardsSummary;
        }

        public EmployeePDValidationSummary GetEmployeePDValidationSummary(int EmployeeId)
        {
            return new EmployeePDValidationSummary();
        }

        public EmployeeBGVerificationSummary GetEmployeeBGVerificationSummary(int EmployeeUserId)
        {
            EmployeeBGVerificationSummary employeeBGVerificationSummary = new EmployeeBGVerificationSummary();
            try
            {
                var employeeProfessionalInfos = context.EmployeeProfessionalInfos.Where(s => s.UserId == EmployeeUserId);
                foreach (var item in employeeProfessionalInfos)
                {
                    employeeBGVerificationSummary.professionalDetails.Add(GetEmployeeProfessionalInfoMapper(item));
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return employeeBGVerificationSummary;
        }

        public PDVEmailTemplate GetPDVEmailTemplate(EmployeeShortSummary summary,List<String> FieldsToUpdate)
        {
            PDVEmailTemplate EmailTemplate = new PDVEmailTemplate();
            try
            {
                var personalDetails = context.EmployeePersonalInfos.Where(s => s.Id == summary.Id).FirstOrDefault();
                var employeeUserDetails = context.Users.Where(s => s.Id == personalDetails.UserId).FirstOrDefault();
                var applicationTexts = context.ApplicationTexts.Where(s => s.OrganizationId == employeeUserDetails.OrganizationId).FirstOrDefault();
                EmailTemplate.PDVEmailSubjectTemplate = applicationTexts.PDVEmailSubjectTemplate;
                StringBuilder Body = new StringBuilder(applicationTexts.PDVEmailBodyTemplate);
                Body.Replace("EmployeeName", summary.Name);
                foreach (var item in FieldsToUpdate)
                {
                    Body.Append("\n * " + item );
                }
                Body.Append("\n\nRegards\n HR Manager\n HR@tekfriday.com");
                EmailTemplate.PDVEmailBodyTemplate = Body.ToString();
            }
            catch(Exception ex)
            {
                ErrorLogger.LogInfo(ex.Message);
            }
            return EmailTemplate;
        }

        public BGVEmailTemplate GetBGVEmailTemplate(string EmployeeName, EmployeeProfessionalInfo professionalInfo)
        {
            BGVEmailTemplate EmailTemplate = new BGVEmailTemplate();
            try
            {
                var employeeUserDetails = context.Users.Where(s => s.Id == professionalInfo.UserId).FirstOrDefault();
                var applicationTexts = context.ApplicationTexts.Where(s => s.OrganizationId == employeeUserDetails.OrganizationId).FirstOrDefault();
                var organization=context.Organizations.Where(s=>s.Id== employeeUserDetails.OrganizationId).FirstOrDefault();
                EmailTemplate.PDVEmailSubjectTemplate = applicationTexts.BGVEmailSubjectTemplate;
                StringBuilder Body = new StringBuilder(applicationTexts.BGVEmailBodyTemplate);
                Body.Replace("TekFriday", organization.OrganizationName.ToString());
                Body.Replace("EmployeeName", EmployeeName);
                Body.Replace("LastDesignation", professionalInfo.LastDesignation);
                Body.Replace("StartDate", professionalInfo.StartDate.ToString("dd/MM/yyyy"));
                Body.Replace("EndDate", professionalInfo.EndDate.ToString("dd/MM/yyyy"));
                Body.Replace("companyCTC", professionalInfo.CTC.ToString());
                //Body.Append("Sir/Madam,\n        I am HR Manager from TekFriday Pvt. Ltd. This is with regard to referral check of " + EmployeeName +", who worked with you as " + professionalInfo.LastDesignation + ". Can you please let me know the following details about him/her: ");
                //Body.Append("\nPeriod Of Employeement: From "+professionalInfo.StartDate+" To"+professionalInfo.EndDate+"\nCTC: "+professionalInfo.CTC+"\nDesignation: "+professionalInfo.LastDesignation+"\n");
                Body.Append("\nRegards\n HR Manager\n HR@tekfriday.com");
                EmailTemplate.PDVEmailBodyTemplate = Body.ToString();
            }
            catch( Exception ex)
            {
                ErrorLogger.LogInfo(ex.Message);
            }
            return EmailTemplate;
        }

        public UserDetailsEmailTemplate GetUserDetailsMailTemplate(User user)
        {
            UserDetailsEmailTemplate userDetailsEmailTemplate = new UserDetailsEmailTemplate();
            try
            {
                var employeeUserDetails = context.Users.Where(s => s.Id == user.Id).FirstOrDefault();
                var applicationTexts = context.ApplicationTexts.Where(s => s.OrganizationId == employeeUserDetails.OrganizationId).FirstOrDefault();
                userDetailsEmailTemplate.UserDetailsSubjectTemplate = applicationTexts.EmployeeRegisteredEMailSubjectTemplate;
                StringBuilder Body = new StringBuilder(@applicationTexts.EmployeeRegisteredEMailBodyTemplate);
                Body.Replace("UserName",user.UserName);
                Body.Replace("UserMailId",user.UserMailId);
                Body.Replace("Password1",user.Password);
                //Body.Append("Dear UserName ,\n        Your Login details are: \nEMail: UserMailId \n Password: Password\n");
                //Body.Append("\nRegards\n HRManager\n HR@tekfriday.com");
                userDetailsEmailTemplate.UserDetailsBodyTemplate = Body.ToString();
            }
            catch (Exception ex)
            {
                ErrorLogger.LogInfo(ex.Message);
            }
            return userDetailsEmailTemplate;
        }

    }
}
