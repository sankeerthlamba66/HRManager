﻿using System;
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
        public EmployeePersonalInfo GetPersonalInfo(int? PersonalInfoId,int UserId)
        {
            return new EmployeePersonalInfo();
        }

        public int UpdatePersonalInfo(EmployeePersonalInfo PersonalInfo)
        {
            //update the values of entities here
            return 0;//return the updated id here
        }

        #endregion

        #region ProfessionalInfo Queries
        public EmployeeProfessionalInfo GetProfessionalInfo(int? ProfessionalInfoId,int UserId)
        {
            //list of professional details
            return new EmployeeProfessionalInfo();//list to be returned
        }

        public int AddProfessionalInfo(EmployeeProfessionalInfo ProfessionalInfo)
        {
            return 0;//added ProfessionalId value
        }

        public int UpdateProfessionalInfo(EmployeeProfessionalInfo ProfessionalInfo)
        {
            return 0;//updated professionalId value
        }

        public void DeleteProfessionalInfo(int ProfessionalInfoId,int UserId)
        {
            //linq to delete the row 
        }
#endregion

        #region BankInfo Queries
        public EmployeeBankInfo GetBankInfo(int? EmployeeBankInfoId,int UserId)
        {
            return new EmployeeBankInfo();
        }

        public int AddBankInfo(EmployeeBankInfo BankInfo)
        {
            return 0;//added bankId value
        }

        public int UpdateBankInfo(EmployeeBankInfo BankInfo)
        {
            return 0;//updated employeeBankInfoId value
        }

        public void DeleteBankInfo(int EmployeeBankInfoId,int UserId)
        {
            //linq to delete the row 
        }
#endregion

        #region Insurance Queries
        public EmployeeInsuranceInfo GetInsuranceInfo(int? EmployeeInsuranceInfoId,int UserId)
        {
            //details
            return new EmployeeInsuranceInfo();
        }

        public int AddInsuranceInfo(EmployeeInsuranceInfo InsuranceInfo)
        {
            return 0;//added insuranceId value
        }

        public int UpdateInsuranceInfo(EmployeeInsuranceInfo InsuranceInfo)
        {
            return 0;//updated employeeinsuranceInfoId value
        }

        public void DeleteInsuranceInfo(int EmployeeInsuranceInfoId,int UserId)
        {
            //linq to delete the row 
        }
#endregion

        #region PF and ESI queries
        public EmployeePFandESIInfo GetPFAndESIInfo(int? EmployeePFAndESIInfoId,int UserId)
        {
            return new EmployeePFandESIInfo();
        }

        public int AddPFAndESIInfo(EmployeePFandESIInfo PFAndESIInfo)
        {
            return 0;//added PfId value
        }

        public int UpdatePFAndESIInfo(EmployeePFandESIInfo PFAndESIInfo)
        {
            return 0;//updated employeePfInfoId value
        }

        public void DeletePFAndESIInfo(int EmployeePFAndESIInfoId,int UserId)
        {
            //linq to delete the row 
        }
#endregion

        #region Document Queries
        public EmployeeDocument GetDocument(int? EmployeeDocumentInfoId,int UserId)
        {
            //details
            return new EmployeeDocument();
        }

        public int AddDocument(EmployeeDocument DocumentInfo)
        {
            return 0;//added DocumentId value
        }

        public int UpdateDocument(EmployeeDocument DocumentInfo)
        {
            return 0;//updated employeeDoucumentInfoId value
        }

        public void DeleteDocument(int EmployeeDocumentInfoId,int UserId)
        {
            //linq to delete the row 
        }
        #endregion
    }
}
