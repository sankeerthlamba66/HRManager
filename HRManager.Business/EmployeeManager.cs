using HRManager.Data.Entity;
using HRManager.Models.EntityViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Business
{
    public class EmployeeManager
    {
        #region PersonalInfo
        public EmployeePersonalInfo GetPersonalInfo(int? PersonalInfoId,int UserId)
        {
            return new EmployeeQueries().GetPersonalInfo(PersonalInfoId, UserId);
        }

        public int UpdatePersonalInfo(EmployeePersonalInfo PersonalInfo)
        {
            return new EmployeeQueries().UpdatePersonalInfo(PersonalInfo);
        }

        #endregion

        #region ProfessionalInfo
        public EmployeeProfessionalInfo GetProfessionalInfo(int? ProfessionalInfoId,int UserId)
        {
            return new EmployeeQueries().GetProfessionalInfo(ProfessionalInfoId,UserId);
        }

        public int AddProfessionalInfo(EmployeeProfessionalInfo ProfessionalInfo)
        {
            return new EmployeeQueries().AddProfessionalInfo(ProfessionalInfo);
        }

        public int UpdateProfessionalInfo(EmployeeProfessionalInfo ProfessionalInfo)
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

        public int AddBankInfo(EmployeeBankInfo ProfessionalInfo)
        {
            return new EmployeeQueries().AddBankInfo(ProfessionalInfo);
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
    }
}
