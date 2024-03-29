﻿using HRManager.Data.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Data.Entity
{
    public class Context:DbContext
    {
        //public Context(DbContextOptions<Context> options):base(options)
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Setup.DBConnectionString);
        }
        public DbSet<ApplicationText> ApplicationTexts { get; set; }
        public DbSet<EmployeeAgreementAcceptance> EmployeeAgreementAcceptances { get; set; }
        public DbSet<EmployeePersonalInfo> EmployeePersonalInfos { get; set; }
        public DbSet<EmployeeProfessionalInfo>EmployeeProfessionalInfos { get; set; }
        public DbSet<EmployeeBankInfo> EmployeeBankInfos { get; set; }
        public DbSet<EmployeeInsuranceInfo>EmployeeInsuranceInfos { get; set; }
        public DbSet<EmployeePFandESIInfo> EmployeePFandESIInfos { get;set; }
        public DbSet<EmployeeDocument>EmployeeDocuments { get; set; }
        public DbSet<Organization>Organizations{ get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Validation> Validations { get; set; }
    }
}
