using System;
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

    public enum RoleType : byte
    {
        HRAdmin=0,
        Admin=1,
        Employee=2
    }

    public enum BloodGroup : byte
    {
        APositive = 0,
        ANegative = 1,
        xxx = 2
    }

    public enum ReferalSource : byte
    {
        LinkedIn = 0,
        Naukri = 1,
        MonsterJobs = 2,
        xxx = 3
    }
}
