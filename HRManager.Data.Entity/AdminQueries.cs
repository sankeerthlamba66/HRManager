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

        public PDVEmailTemplate GetPDVEmailTemplate(String EmployeeName,List<String> FieldsToUpdate)
        {
            PDVEmailTemplate EmailTemplate = new PDVEmailTemplate();
            try
            {                
                StringBuilder subject = new StringBuilder();
                EmailTemplate.PDVEmailSubjectTemplate = @"Verify and Update the following Details";
                subject.Append("Dear " + EmployeeName + ",\n        The following Details should be updated Or Are not matching with data Provided.\n");
                foreach (var item in FieldsToUpdate)
                {
                    subject.Append("* " + item + "\n");
                }
                subject.Append("\nRegards\n HR Manager\n HR@tekfriday.com");
                EmailTemplate.PDVEmailBodyTemplate = subject.ToString();
            }
            catch(Exception ex)
            {
                ErrorLogger.LogInfo(ex.Message);
            }
            return EmailTemplate;
        }

        public BGVEmailTemplate GetBGVEmailTemplate(EmployeeProfessionalInfo professionalInfo)
        {
            BGVEmailTemplate EmailTemplate = new BGVEmailTemplate();
            try
            {
                StringBuilder subject = new StringBuilder();
                EmailTemplate.PDVEmailSubjectTemplate = @"Verify and Update the following Details";
                subject.Append("Sir/Madam,\n        I am HRManager from TekFriday Pvt. Ltd. This is with regard to referral check of Mr. *****, whoworked with you as " + professionalInfo.LastDesignation + ". Can you please let me know the following details about him:");
                subject.Append("\nPeriod Of Employeement:\nCTC:\nDesignation:\nReason Of Leaving:\n");
                subject.Append("\nRegards\n HR Manager\n HR@tekfriday.com");
                EmailTemplate.PDVEmailBodyTemplate = subject.ToString();
            }
            catch( Exception ex)
            {
                ErrorLogger.LogInfo(ex.Message);
            }
            return EmailTemplate;
        }

    }
}
