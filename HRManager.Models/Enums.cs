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
        BPositive = 2,
        BNegative = 3,
        ABPositive = 4,
        ABNegative = 5,
        OPositive = 6,
        ONegative = 7,
        Others = 8

    }

    public enum ReferalSource : byte
    {
        LinkedIn = 0,
        Naukri = 1,
        MonsterJobs = 2,
        SocialMedia = 3,
        Newspapers= 4,
        Reference= 5
    }
    public enum OrgaizationName : byte
    {
        TekFriday=1,
        Vivifi=2
    }
}
