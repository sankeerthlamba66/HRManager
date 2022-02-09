﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManager.Models.Views;
using HRManager.Models.ViewModels;
using HRManager.Data.Entity;
using HRManager.Business.BussinessRepository;

namespace HRManager.Business
{
    public class AdminManager:IAdminManager
    {
        public List<EmployeeTableSummary> GetRecentlyUpdatedEmployees()
        {
            return new AdminQueries().GetRecentlyUpdatedEmployees();
        }

        public EmployeeAllDetails GetEmployeeAllDetails(int EmployeeUserId)
        {
            return new EmployeeQueries().GetEmployeeAllDetails(EmployeeUserId);
        }

        public List<EmployeeTableSummary> GetRecentlyUpdatedEmployees(DateTime DateFrom, DateTime DateTo)
        {
            return new AdminQueries().GetRecentlyUpdatedEmployees(DateFrom, DateTo);
        }

        public List<EmployeeCardSummary> GetRecentlyUpdatedEmployeeCards()
        {
            return new AdminQueries().GetRecentlyUpdatedEmployeeCards();
        }

        public List<EmployeeCardSummary> GetRecentlyUpdatedEmployeeCards(DateTime DateFrom, DateTime DateTo)
        {
            return new AdminQueries().GetRecentlyUpdatedEmployeeCards(DateFrom, DateTo);
        }

        public EmployeePDValidationSummary GetEmployeePDValidationSummary(int EmployeeId)
        {
            return new AdminQueries().GetEmployeePDValidationSummary(EmployeeId);
        }

        public EmployeeBGVerificationSummary GetEmployeeBGVerificationSummary(int EmployeeId)
        {
            return new AdminQueries().GetEmployeeBGVerificationSummary(EmployeeId);
        }

        public void SendPDValidationEmail(int EmployeeId, List<string> FieldsToUpdate)
        {
            var Summary = new EmployeeQueries().GetEmployeeShortSummary(EmployeeId);
            var EmailTemplate = new AdminQueries().GetPDVEmailTemplate(Summary.Name,FieldsToUpdate);

            //Substitute placeholders in the templates with the employee details and Fields List.
            string Subject = EmailTemplate.PDVEmailSubjectTemplate;//string.Empty;
            string Body = EmailTemplate.PDVEmailBodyTemplate;//string.Empty;

            Helpers.Utilities.SendEmail(Summary.Email, Subject, Body);
        }

        public void SendBGVerificationEmail(int ProfessionalDetailsId)
        {
            var ProfDetails = new EmployeeQueries().GetProfessionalDetails(ProfessionalDetailsId);
            var EmailTemplate = new AdminQueries().GetBGVEmailTemplate(ProfDetails);

            //Substitute placeholders in the templates with the professional details.
            string Subject = EmailTemplate.PDVEmailSubjectTemplate;
            string Body = EmailTemplate.PDVEmailBodyTemplate;

            Helpers.Utilities.SendEmail(ProfDetails.ReferenceEmailId, Subject, Body);
        }
    }
}
