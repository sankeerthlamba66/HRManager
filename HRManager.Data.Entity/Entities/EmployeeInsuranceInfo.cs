﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManager.Models;

namespace HRManager.Data.Entity.Entities
{
    public class EmployeeInsuranceInfo : EntityBase
    {
        public int Id { get; set; }

        public string NameAsPerAadhar { get; set; }
        public string Relationship { get; set; }
        public Gender Gender { get; set; }
        public DateOnly DateOfBirthAsPerAadhar { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
