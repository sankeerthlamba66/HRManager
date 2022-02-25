using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManager.Models.Views;
using HRManager.Models.ViewModels;
using HRManager.Data.Entity;
using HRManager.Business.BussinessRepository;
using HRManager.Models.EntityViews;

namespace HRManager.Business
{
    public class AdminManager:IAdminManager
    {
        public void AddEmployee(User user) 
        {
            user.Password = GeneratePassWord();
            user.Id=new AdminQueries().AddEmployee(user);
            SendUserDetailsMail(user);
        }

        private string GeneratePassWord()
        {
            byte length = 8;
            const String ValidCharsacters= "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder passWord = new StringBuilder();
            Random random = new Random();
            while(0<length--)
            {
                passWord.Append(ValidCharsacters[random.Next(ValidCharsacters.Length)]);
            }
            return passWord.ToString();
        }

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

        public EmployeeBGVerificationSummary GetEmployeeBGVerificationSummary(int EmployeeUserId)
        {
            return new AdminQueries().GetEmployeeBGVerificationSummary(EmployeeUserId);
        }

        public void SendPDValidationEmail(int EmployeeId, List<string> FieldsToUpdate)
        {
            var Summary = new EmployeeQueries().GetEmployeeShortSummary(EmployeeId);
            var EmailTemplate = new AdminQueries().GetPDVEmailTemplate(Summary, FieldsToUpdate);

            //Substitute placeholders in the templates with the employee details and Fields List.
            string Subject = EmailTemplate.PDVEmailSubjectTemplate;//string.Empty;
            string Body = EmailTemplate.PDVEmailBodyTemplate;//string.Empty;

            Helpers.Utilities.SendEmail(Summary.Email, Subject, Body);
        }

        public void SendBGVerificationEmail(int ProfessionalDetailsId)
        {
            var ProfDetails = new EmployeeQueries().GetProfessionalDetails(ProfessionalDetailsId);
            var Summary = new EmployeeQueries().GetEmployeeFullName(ProfDetails.UserId);
            
            var EmailTemplate = new AdminQueries().GetBGVEmailTemplate(Summary.EmployeeFullName,ProfDetails);

            //Substitute placeholders in the templates with the professional details.
            string Subject = EmailTemplate.PDVEmailSubjectTemplate;
            string Body = EmailTemplate.PDVEmailBodyTemplate;

            Helpers.Utilities.SendEmail(ProfDetails.HREmailId, Subject, Body);
        }

        private void SendUserDetailsMail(User user)
        {
            var EmailTemplate = new AdminQueries().GetUserDetailsMailTemplate(user);

            string Subject = EmailTemplate.UserDetailsSubjectTemplate;
            string Body = EmailTemplate.UserDetailsBodyTemplate;

            Helpers.Utilities.SendEmail(user.UserMailId,Subject,Body);
        }

    }
}
