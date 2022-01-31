using HRManager.Business.BussinessRepository;
using HRManager.Data.Entity;
using HRManager.Data.Entity.EntityRepository;
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
        private readonly IEmployeeQueries employeeQueries;
        public EmployeeManager(IEmployeeQueries _employeeQueries)
        {
            employeeQueries = _employeeQueries;
        }
        public EmployeeIndexModels GetEmployeeDetails(int UserId)
        {
            return employeeQueries.GetEmployeeDetails(UserId);
        }
        #region PersonalInfo
        public EmployeePersonalInfo GetPersonalInfo(int? PersonalInfoId,int UserId)
        {
            return employeeQueries.GetPersonalInfo(PersonalInfoId, UserId);
        }

        public int UpdatePersonalInfo(EmployeePersonalInfo PersonalInfo)
        {
            return employeeQueries.UpdatePersonalInfo(PersonalInfo);
        }

        #endregion

        #region ProfessionalInfo
        public EmployeeProfessionalInfo GetProfessionalInfo(int? ProfessionalInfoId,int UserId)
        {
            return employeeQueries.GetProfessionalInfo(ProfessionalInfoId,UserId);
        }

        public int AddProfessionalInfo(EmployeeProfessionalInfo ProfessionalInfo)
        {
            return employeeQueries.AddProfessionalInfo(ProfessionalInfo);
        }

        public int UpdateProfessionalInfo(EmployeeProfessionalInfo ProfessionalInfo)
        {
            return employeeQueries.UpdateProfessionalInfo(ProfessionalInfo);
        }

        public void DeleteProfessionalInfo(int ProfessionalInfoId,int UserId)
        {
            employeeQueries.DeleteProfessionalInfo(ProfessionalInfoId,UserId);
        }
        #endregion

        #region BankInfo
        public EmployeeBankInfo GetBankInfo(int? EmployeeBankInfoId,int UserId)
        {
            return employeeQueries.GetBankInfo(EmployeeBankInfoId,UserId);
        }

        public int AddBankInfo(EmployeeBankInfo ProfessionalInfo)
        {
            return employeeQueries.AddBankInfo(ProfessionalInfo);
        }

        public int UpdateBankInfo(EmployeeBankInfo BankInfo)
        {
            return employeeQueries.UpdateBankInfo(BankInfo);
        }

        public void DeleteBankInfo(int EmployeeBankInfoId,int UserId)
        {
            employeeQueries.DeleteBankInfo(EmployeeBankInfoId,UserId);
        }
        #endregion

        #region InsuranceInfo
        public EmployeeInsuranceInfo GetInsuranceInfo(int? EmployeeInsuranceInfoId,int UserId)
        {
            return employeeQueries.GetInsuranceInfo(EmployeeInsuranceInfoId,UserId);
        }

        public int AddInsuranceInfo(EmployeeInsuranceInfo InsuranceInfo)
        {
            return employeeQueries.AddInsuranceInfo(InsuranceInfo);
        }

        public int UpdateInsuranceInfo(EmployeeInsuranceInfo InsuranceInfo)
        {
            return employeeQueries.UpdateInsuranceInfo(InsuranceInfo);
        }

        public void DeleteInsuranceInfo(int EmployeeInsuranceInfoId,int UserId)
        {
            employeeQueries.DeleteInsuranceInfo(EmployeeInsuranceInfoId,UserId);
        }
        #endregion

        #region PF and ESI 
        public EmployeePFandESIInfo GetPFAndESIInfo(int? EmployeePFAndESIInfoId,int UserId)
        {
            return employeeQueries.GetPFAndESIInfo(EmployeePFAndESIInfoId,UserId);
        }

        public int AddPFAndESIInfo(EmployeePFandESIInfo PFAndESIInfo)
        {
            return employeeQueries.AddPFAndESIInfo(PFAndESIInfo);
        }

        public int UpdatePFAndESIInfo(EmployeePFandESIInfo PFAndESIInfo)
        {
            return employeeQueries.UpdatePFAndESIInfo(PFAndESIInfo);
        }

        public void DeletePFAndESIInfo(int EmployeePFAndESIInfoId,int UserId)
        {
            employeeQueries.DeletePFAndESIInfo(EmployeePFAndESIInfoId,UserId);
        }
        #endregion

        #region Document
        public EmployeeDocument GetDocument(int? EmployeeDocumentInfoId,int UserId)
        {
            return employeeQueries.GetDocument(EmployeeDocumentInfoId,UserId);
        }

        public int AddDocument(EmployeeDocument DocumentInfo)
        {
            return employeeQueries.AddDocument(DocumentInfo);
        }

        public int UpdateDocument(EmployeeDocument DocumentInfo)
        {
            return employeeQueries.UpdateDocument(DocumentInfo);
        }

        public void DeleteDocument(int EmployeeDocumentInfoId,int UserId)
        {
            employeeQueries.DeleteDocument(EmployeeDocumentInfoId,UserId);
        }
        #endregion
    }
}
