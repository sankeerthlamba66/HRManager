﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Models.EntityViews
{
    public class EmployeeInsuranceInfo
    {
        public int? Id { get; set; }
        public int UserId { get; set; }
        public string NameAsPerAadhar { get; set; }
        public string Relationship { get; set; }
        public Gender Gender { get; set; }
        public DateOnly DateOfBirthAsPerAadhar { get; set; }
    }
}
