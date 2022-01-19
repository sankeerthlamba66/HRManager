﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Models
{
    public enum MaritalStatus : byte
    {
        Married = 0,
        UnMarried = 1
    }

    public enum Gender : byte
    {
        Male = 0,
        Female = 1
    }

    public enum DocumentType : byte
    {
        Aadhar = 0,
        Pan = 1,
        xxx = 2
    }
}
