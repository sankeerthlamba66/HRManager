using HRManager.Models.EntityViews;
using HRManager.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Business.BussinessRepository
{
    public interface IEmployeeManager
    {
        EmployeeIndexModels GetEmployeeDetails(int UserId);
        EmployeePersonalInfo GetPersonalInfo(int? PersonalInfoId, int UserId);
        EmployeePersonalInfo GetPersonalInfo(int UserId);
        int UpdatePersonalInfo(EmployeePersonalInfo PersonalInfo);
        EmployeeProfessionalDocuments GetProfessionalInfo(int? ProfessionalInfoId, int UserId);
        List<EmployeeProfessionalDocuments> GetProfessionalInfo(int UserId);
        int AddProfessionalInfo(EmployeeProfessionalDocuments ProfessionalInfo);
        int UpdateProfessionalInfo(EmployeeProfessionalDocuments ProfessionalInfo);
        void DeleteProfessionalInfo(int ProfessionalInfoId, int UserId);
        EmployeeBankInfo GetBankInfo(int? EmployeeBankInfoId, int UserId);
        List<EmployeeBankInfo> GetBankInfo(int UserId);
        int AddBankInfo(EmployeeBankInfo ProfessionalInfo);
        int UpdateBankInfo(EmployeeBankInfo BankInfo);
        void DeleteBankInfo(int EmployeeBankInfoId, int UserId);
        EmployeeInsuranceInfo GetInsuranceInfo(int? EmployeeInsuranceInfoId, int UserId);
        List<EmployeeInsuranceInfo> GetInsuranceInfo(int UserId);
        int AddInsuranceInfo(EmployeeInsuranceInfo InsuranceInfo);
        int UpdateInsuranceInfo(EmployeeInsuranceInfo InsuranceInfo);
        void DeleteInsuranceInfo(int EmployeeInsuranceInfoId, int UserId);
        EmployeePFandESIInfo GetPFAndESIInfo(int? EmployeePFAndESIInfoId, int UserId);
        List<EmployeePFandESIInfo> GetPFAndESIInfo(int UserId);
        int AddPFAndESIInfo(EmployeePFandESIInfo PFAndESIInfo);
        int UpdatePFAndESIInfo(EmployeePFandESIInfo PFAndESIInfo);
        void DeletePFAndESIInfo(int EmployeePFAndESIInfoId, int UserId);
        EmployeeDocument GetDocument(int? EmployeeDocumentInfoId, int UserId);
        EmployeeDocument GetDocument(int UserId);
        int AddDocument(EmployeeDocument DocumentInfo);
        int UpdateDocument(EmployeeDocument DocumentInfo);
        void DeleteDocument(int EmployeeDocumentInfoId, int UserId);
    }
}
