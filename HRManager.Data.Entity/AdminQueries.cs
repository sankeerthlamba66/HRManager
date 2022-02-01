using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManager.Models.Views;
using HRManager.Models.ViewModels;
using AutoMapper;
using HRManager.Models.EntityViews;

namespace HRManager.Data.Entity
{
    public class AdminQueries
    {
        private readonly Context context=new Context();

        public List<EmployeeTableSummary> GetRecentlyUpdatedEmployees()
        {
            List<EmployeeTableSummary> employeeTableSummary = new List<EmployeeTableSummary>();
            var employeesPersonlInfos = context.EmployeePersonalInfos.OrderByDescending(s => s.UpdatedDate);
            foreach(var item in employeesPersonlInfos)
            {
                employeeTableSummary.Add(GetEmployeeTableSummaryMapper(item));
            }
            return employeeTableSummary;
        }
        public EmployeeTableSummary GetEmployeeTableSummaryMapper(Entities.EmployeePersonalInfo employeePersonalInfo)
        {
            EmployeeTableSummary employeeTableSummary = new EmployeeTableSummary();
            employeeTableSummary.Id = employeePersonalInfo.Id;
            employeeTableSummary.EmployeeName = employeePersonalInfo.FirstName;
            employeeTableSummary.MobileNumber = employeePersonalInfo.MobileNumber;
            employeeTableSummary.PersonalEmailId = employeePersonalInfo.PersonalEmailId;
            return employeeTableSummary;
        }
        public EmployeeCardSummary GetEmployeeCardSummaryMapper(Entities.EmployeePersonalInfo employeePersonalInfo)
        {
            EmployeeCardSummary employeeCardSummary = new EmployeeCardSummary();
            employeeCardSummary.Id = employeePersonalInfo.Id;
            employeeCardSummary.EmployeeName = employeePersonalInfo.FirstName;
            employeeCardSummary.MobileNumber = employeePersonalInfo.MobileNumber;
            employeeCardSummary.PersonalEmailId = employeePersonalInfo.PersonalEmailId;
            return employeeCardSummary;
        }

        public EmployeeProfessionalInfo GetEmployeeProfessionalInfoMapper(Entities.EmployeeProfessionalInfo ProfessionalInfo)
        {
            EmployeeProfessionalInfo employeeProfessionalInfo = new EmployeeProfessionalInfo();
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
            return employeeProfessionalInfo;
        }
        public List<EmployeeTableSummary> GetRecentlyUpdatedEmployees(DateTime DateFrom, DateTime DateTo)
        {
            List<EmployeeTableSummary> employeeTableSummary = new List<EmployeeTableSummary>();
            var employeesPersonlInfos = context.EmployeePersonalInfos.Where(s=>s.UpdatedDate<=DateTo && s.UpdatedDate>=DateFrom).OrderByDescending(s => s.UpdatedDate);
            foreach (var item in employeesPersonlInfos)
            {
                employeeTableSummary.Add(GetEmployeeTableSummaryMapper(item));
            }
            return employeeTableSummary;
        }

        public List<EmployeeCardSummary> GetRecentlyUpdatedEmployeeCards()
        {
            List<EmployeeCardSummary> employeeCardsSummary = new List<EmployeeCardSummary>();
            var employeesPersonlInfos = context.EmployeePersonalInfos.OrderByDescending(s => s.UpdatedDate);
            foreach (var item in employeesPersonlInfos)
            {
                employeeCardsSummary.Add(GetEmployeeCardSummaryMapper(item));
            }
            return employeeCardsSummary;
        }

        public List<EmployeeCardSummary> GetRecentlyUpdatedEmployeeCards(DateTime DateFrom, DateTime DateTo)
        {
            List<EmployeeCardSummary> employeeCardsSummary = new List<EmployeeCardSummary>();
            var employeesPersonlInfos = context.EmployeePersonalInfos.Where(s => s.UpdatedDate <= DateTo && s.UpdatedDate >= DateFrom).OrderByDescending(s => s.UpdatedDate);
            foreach (var item in employeesPersonlInfos)
            {
                employeeCardsSummary.Add(GetEmployeeCardSummaryMapper(item));
            }
            return employeeCardsSummary;
        }

        public EmployeePDValidationSummary GetEmployeePDValidationSummary(int EmployeeId)
        {

            return new EmployeePDValidationSummary();
        }

        public EmployeeBGVerificationSummary GetEmployeeBGVerificationSummary(int EmployeeId)
        {
            EmployeeBGVerificationSummary employeeBGVerificationSummary = new EmployeeBGVerificationSummary();
            var employeeProfessionalInfos = context.EmployeeProfessionalInfos.Where(s => s.UserId == EmployeeId);
            foreach (var item in employeeProfessionalInfos)
            {
                employeeBGVerificationSummary.professionalDetails.Add(GetEmployeeProfessionalInfoMapper(item));
            }
            return employeeBGVerificationSummary;
        }

        public PDVEmailTemplate GetPDVEmailTemplate()
        {
            return new PDVEmailTemplate();
        }

        public BGVEmailTemplate GetBGVEmailTemplate()
        {
            return new BGVEmailTemplate();
        }

    }
}
