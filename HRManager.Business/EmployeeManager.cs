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
        public EmployeePersonalInfo GetPersonalInfo(int? PersonalInfoId)
        {
            return new EmployeeQueries().GetPersonalInfo(PersonalInfoId);
        }

        public int UpdatePersonalInfo(int UserId, EmployeePersonalInfo PersoanlInfo)
        {
            return new EmployeeQueries().UpdatePersonalInfo(UserId, PersoanlInfo);
        }

        #endregion

        #region ProfessionalInfo
        public EmployeeProfessionalInfo GetProfessionalInfo(int? ProfessionalInfoId)
        {
            return new EmployeeQueries().GetProfessionalInfo(ProfessionalInfoId);
        }

        public int AddProfessionalInfo(int UserId,EmployeeProfessionalInfo ProfessionalInfo)
        {
            return new EmployeeQueries().AddProfessionalInfo(UserId,ProfessionalInfo);
        }

        public int UpdateProfessionalInfo(int UserId,EmployeeProfessionalInfo ProfessionalInfo)
        {
            return new EmployeeQueries().UpdateProfessionalInfo(UserId,ProfessionalInfo);
        }

        public void DeleteProfessionalInfo(int ProfessionalInfoId)
        {
            new EmployeeQueries().DeleteProfessionalInfo(ProfessionalInfoId);
        }
        #endregion

        #region BankInfo
        public EmployeeBankInfo GetBankInfo(int? EmployeeBankInfoId)
        {
            return new EmployeeQueries().GetBankInfo(EmployeeBankInfoId);
        }

        public int AddBankInfo(int UserId, EmployeeBankInfo ProfessionalInfo)
        {
            return new EmployeeQueries().AddBankInfo(UserId, ProfessionalInfo);
        }

        public int UpdateBankInfo(int UserId, EmployeeBankInfo BankInfo)
        {
            return new EmployeeQueries().UpdateBankInfo(UserId, BankInfo);
        }

        public void DeleteBankInfo(int EmployeeBankInfoId)
        {
            new EmployeeQueries().DeleteBankInfo(EmployeeBankInfoId);
        }
        #endregion

        #region InsuranceInfo
        public EmployeeInsuranceInfo GetInsuranceInfo(int? EmployeeInsuranceInfoId)
        {
            return new EmployeeQueries().GetInsuranceInfo(EmployeeInsuranceInfoId);
        }

        public int AddInsuranceInfo(int UserId, EmployeeInsuranceInfo InsuranceInfo)
        {
            return new EmployeeQueries().AddInsuranceInfo(UserId,InsuranceInfo);
        }

        public int UpdateInsuranceInfo(int UserId, EmployeeInsuranceInfo InsuranceInfo)
        {
            return new EmployeeQueries().UpdateInsuranceInfo(UserId, InsuranceInfo);
        }

        public void DeleteInsuranceInfo(int EmployeeInsuranceInfoId)
        {
            new EmployeeQueries().DeleteInsuranceInfo(EmployeeInsuranceInfoId);
        }
        #endregion

        #region PF and ESI 
        public EmployeePFandESIInfo GetPFAndESIInfo(int? EmployeePFAndESIInfoId)
        {
            return new EmployeeQueries().GetPFAndESIInfo(EmployeePFAndESIInfoId);
        }

        public int AddPFAndESIInfo(int UserId, EmployeePFandESIInfo PFAndESIInfo)
        {
            return new EmployeeQueries().AddPFAndESIInfo(UserId, PFAndESIInfo);
        }

        public int UpdatePFAndESIInfo(int UserId, EmployeePFandESIInfo PFAndESIInfo)
        {
            return new EmployeeQueries().UpdatePFAndESIInfo(UserId, PFAndESIInfo);
        }

        public void DeletePFAndESIInfo(int EmployeePFAndESIInfoId)
        {
            new EmployeeQueries().DeletePFAndESIInfo(EmployeePFAndESIInfoId);
        }
        #endregion

        #region Document
        public EmployeeDocument GetDocument(int? EmployeeDocumentInfoId)
        {
            return new EmployeeQueries().GetDocument(EmployeeDocumentInfoId);
        }

        public int AddDocument(int UserId, EmployeeDocument DocumentInfo)
        {
            return new EmployeeQueries().AddDocument(UserId, DocumentInfo);
        }

        public int UpdateDocument(int UserId, EmployeeDocument DocumentInfo)
        {
            return new EmployeeQueries().UpdateDocument(UserId, DocumentInfo);
        }

        public void DeleteDocumant(int EmployeeDocumentInfoId)
        {
            new EmployeeQueries().DeleteDocumant(EmployeeDocumentInfoId);
        }
        #endregion
    }
}
