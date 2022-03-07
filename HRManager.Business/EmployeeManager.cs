using HRManager.Business.BussinessRepository;
using HRManager.Data.Entity;
using HRManager.Models.EntityViews;
using HRManager.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Business
{
    public class EmployeeManager:IEmployeeManager
    {
        
        public EmployeeIndexModels GetEmployeeDetails(int UserId,int organizationId)
        {
            return new EmployeeQueries().GetEmployeeDetails(UserId,organizationId);
        }

        public bool CheckSubmission(int UserId)
        {
            return new EmployeeQueries().CheckSubmission(UserId);
        }
        #region PersonalInfo
        public int AddPersonalInfo(EmployeePersonalInfo PersonalInfo,int OrganizationId)
        {
            return new EmployeeQueries().AddPersonalInfo(PersonalInfo,OrganizationId);
        }
        public EmployeePersonalInfo GetPersonalInfo(int? PersonalInfoId,int UserId)
        {
            return new EmployeeQueries().GetPersonalInfo(PersonalInfoId, UserId);
        }

        public EmployeePersonalInfo GetPersonalInfo(int UserId)
        {
            return new EmployeeQueries().GetPersonalInfo(UserId);
        }
        public int UpdatePersonalInfo(EmployeePersonalInfo PersonalInfo)
        {
            return new EmployeeQueries().UpdatePersonalInfo(PersonalInfo);
        }

        
        #endregion

        #region ProfessionalInfo
        public EmployeeProfessionalDocuments GetProfessionalInfo(int? ProfessionalInfoId,int UserId)
        {
            return new EmployeeQueries().GetProfessionalInfo(ProfessionalInfoId,UserId);
        }

        public List<EmployeeProfessionalDocuments> GetProfessionalInfo(int UserId)
        {
            return new EmployeeQueries().GetProfessionalInfo(UserId);
        }

        public int AddProfessionalInfo(EmployeeProfessionalDocuments ProfessionalInfo)
        {
            return new EmployeeQueries().AddProfessionalInfo(ProfessionalInfo);
        }

        public int UpdateProfessionalInfo(EmployeeProfessionalDocuments ProfessionalInfo)
        {
            return new EmployeeQueries().UpdateProfessionalInfo(ProfessionalInfo);
        }

        public void DeleteProfessionalInfo(int ProfessionalInfoId,int UserId)
        {
            new EmployeeQueries().DeleteProfessionalInfo(ProfessionalInfoId,UserId);
        }
        #endregion

        #region BankInfo
        public EmployeeBankInfo GetBankInfo(int? EmployeeBankInfoId,int UserId)
        {
            return new EmployeeQueries().GetBankInfo(EmployeeBankInfoId,UserId);
        }

        public List<EmployeeBankInfo> GetBankInfo( int UserId)
        {
            return new EmployeeQueries().GetBankInfo(UserId);
        }
        public int AddBankInfo(EmployeeBankInfo BankInfo)
        {
            return new EmployeeQueries().AddBankInfo(BankInfo);
        }

        public int UpdateBankInfo(EmployeeBankInfo BankInfo)
        {
            return new EmployeeQueries().UpdateBankInfo(BankInfo);
        }

        public void DeleteBankInfo(int EmployeeBankInfoId,int UserId)
        {
            new EmployeeQueries().DeleteBankInfo(EmployeeBankInfoId,UserId);
        }
        #endregion

        #region InsuranceInfo
        public EmployeeInsuranceInfo GetInsuranceInfo(int? EmployeeInsuranceInfoId,int UserId)
        {
            return new EmployeeQueries().GetInsuranceInfo(EmployeeInsuranceInfoId,UserId);
        }

        public List<EmployeeInsuranceInfo> GetInsuranceInfo(int UserId)
        {
            return new EmployeeQueries().GetInsuranceInfo(UserId);
        }
        public int AddInsuranceInfo(EmployeeInsuranceInfo InsuranceInfo)
        {
            return new EmployeeQueries().AddInsuranceInfo(InsuranceInfo);
        }

        public int UpdateInsuranceInfo(EmployeeInsuranceInfo InsuranceInfo)
        {
            return new EmployeeQueries().UpdateInsuranceInfo(InsuranceInfo);
        }

        public void DeleteInsuranceInfo(int EmployeeInsuranceInfoId,int UserId)
        {
            new EmployeeQueries().DeleteInsuranceInfo(EmployeeInsuranceInfoId,UserId);
        }
        #endregion

        #region PF and ESI 
        public EmployeePFandESIInfo GetPFAndESIInfo(int? EmployeePFAndESIInfoId,int UserId)
        {
            return new EmployeeQueries().GetPFAndESIInfo(EmployeePFAndESIInfoId,UserId);
        }

        public List<EmployeePFandESIInfo> GetPFAndESIInfo(int UserId)
        {
            return new EmployeeQueries().GetPFAndESIInfo(UserId);
        }
        public int AddPFAndESIInfo(EmployeePFandESIInfo PFAndESIInfo)
        {
            return new EmployeeQueries().AddPFAndESIInfo(PFAndESIInfo);
        }

        public int UpdatePFAndESIInfo(EmployeePFandESIInfo PFAndESIInfo)
        {
            return new EmployeeQueries().UpdatePFAndESIInfo(PFAndESIInfo);
        }

        public void DeletePFAndESIInfo(int EmployeePFAndESIInfoId,int UserId)
        {
            new EmployeeQueries().DeletePFAndESIInfo(EmployeePFAndESIInfoId,UserId);
        }
        #endregion

        #region Document
        public EmployeeDocument GetDocument(int? EmployeeDocumentInfoId,int UserId)
        {
            return new EmployeeQueries().GetDocument(EmployeeDocumentInfoId,UserId);
        }

        public EmployeeDocument GetDocument(int UserId)
        {
            return new EmployeeQueries().GetDocument(UserId);
        }

        public int AddDocument(EmployeeDocument DocumentInfo)
        {
            return new EmployeeQueries().AddDocument(DocumentInfo);
        }

        public int UpdateDocument(EmployeeDocument DocumentInfo)
        {
            return new EmployeeQueries().UpdateDocument(DocumentInfo);
        }

        public void DeleteDocument(int EmployeeDocumentInfoId,int UserId)
        {
            new EmployeeQueries().DeleteDocument(EmployeeDocumentInfoId,UserId);
        }
        #endregion

        public void SendMailToHR(User EmployeeUserDetails)
        {
            var EmailTemplate = new EmployeeQueries().GetEmployeeSubmissionEMailTemplates(EmployeeUserDetails);
            new EmployeeQueries().UpdateSubmission(EmployeeUserDetails.Id, EmployeeUserDetails.UserName);
            new EmployeeQueries().UpdateEmployeeAgreementAcceptance(EmployeeUserDetails.Id, EmployeeUserDetails.UserName);
            string Subject = EmailTemplate.EmployeeSubmissionEMailSubjectTemplate;
            string Body = EmailTemplate.EmployeeSubmissionEMailBodyTemplate;
            var HRMailId = Helpers.Utilities.HRMailId;
            Helpers.Utilities.SendEmail(HRMailId, Subject, Body);
        }
    }
}
