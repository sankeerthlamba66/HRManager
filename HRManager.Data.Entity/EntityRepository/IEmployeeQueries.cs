using HRManager.Models.EntityViews;
using HRManager.Models.ViewModels;
using HRManager.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Data.Entity.EntityRepository
{
    public interface IEmployeeQueries
    {
        EmployeeProfessionalInfo GetProfessionalDetails(int ProfessionalDetailsId);
        EmployeeShortSummary GetEmployeeShortSummary(int EmployeeId);
        EmployeeIndexModels GetEmployeeDetails(int UserId);
        EmployeePersonalInfo GetPersonalInfo(int? PersonalInfoId, int UserId);
        int UpdatePersonalInfo(EmployeePersonalInfo PersonalInfo);
        EmployeeProfessionalInfo GetProfessionalInfo(int? ProfessionalInfoId, int UserId);
        int AddProfessionalInfo(EmployeeProfessionalInfo ProfessionalInfo);
        int UpdateProfessionalInfo(EmployeeProfessionalInfo ProfessionalInfo);
        void DeleteProfessionalInfo(int ProfessionalInfoId, int UserId);
        EmployeeBankInfo GetBankInfo(int? EmployeeBankInfoId, int UserId);
        int AddBankInfo(EmployeeBankInfo ProfessionalInfo);
        int UpdateBankInfo(EmployeeBankInfo BankInfo);
        void DeleteBankInfo(int EmployeeBankInfoId, int UserId);
        EmployeeInsuranceInfo GetInsuranceInfo(int? EmployeeInsuranceInfoId, int UserId);
        int AddInsuranceInfo(EmployeeInsuranceInfo InsuranceInfo);
        int UpdateInsuranceInfo(EmployeeInsuranceInfo InsuranceInfo);
        void DeleteInsuranceInfo(int EmployeeInsuranceInfoId, int UserId);
        EmployeePFandESIInfo GetPFAndESIInfo(int? EmployeePFAndESIInfoId, int UserId);
        int AddPFAndESIInfo(EmployeePFandESIInfo PFAndESIInfo);
        int UpdatePFAndESIInfo(EmployeePFandESIInfo PFAndESIInfo);
        void DeletePFAndESIInfo(int EmployeePFAndESIInfoId, int UserId);
        EmployeeDocument GetDocument(int? EmployeeDocumentInfoId, int UserId);
        int AddDocument(EmployeeDocument DocumentInfo);
        int UpdateDocument(EmployeeDocument DocumentInfo);
        void DeleteDocument(int EmployeeDocumentInfoId, int UserId);
    }
}
