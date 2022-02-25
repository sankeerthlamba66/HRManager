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
        Male = 1,
        Female = 2
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

    public enum OrganizationName : byte
    {
        TekFriday=1,
        Vivifi=2
    }

    public enum EmergencyContact : byte
    {
        Father = 1,
        Mother = 2,
        Spouse = 3,
        Relative = 4
    }

    public enum Relationship : byte
    {
        Father = 1,
        Mother = 2,
        Spouse = 3,
        Children = 4

    }
}
