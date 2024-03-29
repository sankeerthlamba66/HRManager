﻿using HRManager.Models.EntityViews;
using HRManager.Models.ViewModels;
using HRManager.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Business.BussinessRepository
{
    public interface IAdminManager
    {
        void AddEmployee(User user);
        List<EmployeeTableSummary> GetRecentlyUpdatedEmployees();
        EmployeeAllDetails GetEmployeeAllDetails(int EmployeeUserId);
        List<EmployeeTableSummary> GetRecentlyUpdatedEmployees(DateTime DateFrom, DateTime DateTo);
        List<EmployeeCardSummary> GetRecentlyUpdatedEmployeeCards();
        List<EmployeeCardSummary> GetRecentlyUpdatedEmployeeCards(DateTime DateFrom, DateTime DateTo);
        EmployeePDValidationSummary GetEmployeePDValidationSummary(int EmployeeId);
        EmployeeBGVerificationSummary GetEmployeeBGVerificationSummary(int EmployeeId);
        void SendPDValidationEmail(int EmployeeId, List<string> FieldsToUpdate, string AdminUserName);
        void SendBGVerificationEmail(int ProfessionalDetailsId);
        void UpdatePDValidate(int EmployeeId, string AdminUserName);
    }
}
