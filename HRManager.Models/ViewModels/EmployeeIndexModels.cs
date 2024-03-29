﻿using HRManager.Models.EntityViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Models.ViewModels
{
    public class EmployeeIndexModels
    {
        public EmployeeIndexModels()
        {
            //this.employeePersonalInfo = new EmployeePersonalInfo();
            //this.employeeProfessionalInfos = new List<EmployeeProfessionalDocuments>();
            //this.employeeBankInfos = new List<EmployeeBankInfo>();
            //this.employeeInsuranceInfos = new List<EmployeeInsuranceInfo>();
            //this.employeePFandESIInfos = new List<EmployeePFandESIInfo>();
            //this.employeeDocuments = new EmployeeDocument();
            //this.applicationTexts = new ApplicationText();

        }
        public EmployeePersonalInfo employeePersonalInfo { get; set; }
        public List<EmployeeProfessionalDocuments> employeeProfessionalInfos { get; set; }
        public EmployeeBankInfo employeeBankInfos { get; set; }
        public List<EmployeeInsuranceInfo> employeeInsuranceInfos { get; set; }
        public EmployeePFandESIInfo employeePFandESIInfos { get; set; }
        public EmployeeDocument employeeDocuments { get; set; }
        public ApplicationText applicationTexts { get; set; }
        public EmployeeAgreementAcceptance? employeeAgreementAcceptance { get; set; }
    }
}
