using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManager.Models.EntityViews;
using HRManager.Models.Views;
using HRManager.Models.ViewModels;

namespace HRManager.Data.Entity
{
    public class EmployeeQueries
    {
        public EmployeeProfessionalInfo GetProfessionalDetails(int ProfessionalDetailsId)
        {
            return new EmployeeProfessionalInfo();
        }

        public EmployeeShortSummary GetEmployeeShortSummary(int EmployeeId)
        {
            return new EmployeeShortSummary();
        }

        #region Personal Info queries
        public EmployeePersonalInfo GetPersonalInfo(int? PersonalInfoId)
        {
            return new EmployeePersonalInfo();
        }

        public int UpdatePersonalInfo(int UserId, EmployeePersonalInfo PersonalInfo)
        {
            //update the values of entities here
            return 0;//return the updated id here
        }

        #endregion

        #region ProfessionalInfo Queries
        public EmployeeProfessionalInfo GetProfessionalInfo(int? ProfessionalInfoId)
        {
            //list of professional details
            return new EmployeeProfessionalInfo();//list to be returned
        }

        public int AddProfessionalInfo(int UserId, EmployeeProfessionalInfo ProfessionalInfo)
        {
            return 0;//added ProfessionalId value
        }

        public int UpdateProfessionalInfo(int UserId, EmployeeProfessionalInfo ProfessionalInfo)
        {
            return 0;//updated professionalId value
        }

        public void DeleteProfessionalInfo(int ProfessionalInfoId)
        {
            //linq to delete the row 
        }
#endregion

        #region BankInfo Queries
        public EmployeeBankInfo GetBankInfo(int? EmployeeBankInfoId)
        {
            return new EmployeeBankInfo();
        }

        public int AddBankInfo(int UserId, EmployeeBankInfo BankInfo)
        {
            return 0;//added bankId value
        }

        public int UpdateBankInfo(int UserId, EmployeeBankInfo BankInfo)
        {
            return 0;//updated employeeBankInfoId value
        }

        public void DeleteBankInfo(int EmployeeBankInfoId)
        {
            //linq to delete the row 
        }
#endregion

        #region Insurance Queries
        public EmployeeInsuranceInfo GetInsuranceInfo(int? EmployeeInsuranceInfoId)
        {
            //details
            return new EmployeeInsuranceInfo();
        }

        public int AddInsuranceInfo(int UserId, EmployeeInsuranceInfo InsuranceInfo)
        {
            return 0;//added insuranceId value
        }

        public int UpdateInsuranceInfo(int UserId, EmployeeInsuranceInfo InsuranceInfo)
        {
            return 0;//updated employeeinsuranceInfoId value
        }

        public void DeleteInsuranceInfo(int EmployeeInsuranceInfoId)
        {
            //linq to delete the row 
        }
#endregion

        #region PF and ESI queries
        public EmployeePFandESIInfo GetPFAndESIInfo(int? EmployeePFAndESIInfoId)
        {
            return new EmployeePFandESIInfo();
        }

        public int AddPFAndESIInfo(int UserId, EmployeePFandESIInfo PFAndESIInfo)
        {
            return 0;//added PfId value
        }

        public int UpdatePFAndESIInfo(int UserId, EmployeePFandESIInfo PFAndESIInfo)
        {
            return 0;//updated employeePfInfoId value
        }

        public void DeletePFAndESIInfo(int EmployeePFAndESIInfoId)
        {
            //linq to delete the row 
        }
#endregion

        #region Document Queries
        public EmployeeDocument GetDocument(int? EmployeeDocumentInfoId)
        {
            //details
            return new EmployeeDocument();
        }

        public int AddDocument(int UserId, EmployeeDocument DocumentInfo)
        {
            return 0;//added DocumentId value
        }

        public int UpdateDocument(int UserId, EmployeeDocument DocumentInfo)
        {
            return 0;//updated employeeDoucumentInfoId value
        }

        public void DeleteDocumant(int EmployeeDocumentInfoId)
        {
            //linq to delete the row 
        }
        #endregion
    }
}
