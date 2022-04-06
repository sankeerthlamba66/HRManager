using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        Female = 2,
        Others= 3
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
        [Display(Name ="A+")]
        APositive = 0,

        [Display(Name = "A-")]
        ANegative = 1,

        [Display(Name = "B+")]
        BPositive = 2,

        [Display(Name = "B-")]
        BNegative = 3,

        [Display(Name = "AB+")]
        ABPositive = 4,

        [Display(Name = "AB-")]
        ABNegative = 5,

        [Display(Name = "O+")]
        OPositive = 6,

        [Display(Name = "O-")]
        ONegative = 7,

        [Display(Name = "Bombay Blood Group")]
        BombayBloodGroup = 8

    }

    public enum OrganizationName : byte
    {
        TekFriday=1,
        Vivifi=2
    }

    public enum EmergencyContactRelationship : byte
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

    public enum States : byte
    {
        [Display(Name = "Andhra Pradesh")]
        AndhraPradesh = 1,

        [Display(Name = "Arunachal Pradesh")]
        ArunachalPradesh = 2,

        [Display(Name = "Assam")]
        Assam = 3,

        [Display(Name = "Bihar")]
        Bihar = 4,

        [Display(Name = "Chhattisgarh")]
        Chhattisgarh = 5,

        [Display(Name = "Goa")]
        Goa = 6,

        [Display(Name = "Gujarat")]
        Gujarat = 7,

        [Display(Name = "Haryana")]
        Haryana = 8,

        [Display(Name = "Himachal Pradesh")]
        HimachalPradesh = 9,

        [Display(Name = "Jammu and Kashmir")]
        JammuandKashmir = 10,

        [Display(Name = "Jharkhand")]
        Jharkhand = 11,

        [Display(Name = "Karnataka")]
        Karnataka = 12,

        [Display(Name = "Kerala")]
        Kerala = 13,

        [Display(Name = "Madhya  Pradesh")]
        MadhyaPradesh = 14,

        [Display(Name = "Maharashtra")]
        Maharashtra = 15,

        [Display(Name = "Manipur")]
        Manipur = 16,

        [Display(Name = "Meghalaya")]
        Meghalaya = 17,

        [Display(Name = "Mizoram")]
        Mizoram = 18,

        [Display(Name = "Nagaland")]
        Nagaland = 19,

        [Display(Name = "Odisha")]
        Odisha = 20,

        [Display(Name = "Punjab")]
        Punjab = 21,

        [Display(Name = "Rajasthan")]
        Rajasthan = 22,

        [Display(Name = "Sikkim")]
        Sikkim = 23,

        [Display(Name = "Tamil Nadu")]
        TamilNadu = 24,

        [Display(Name = "Telangana")]
        Telangana = 25,

        [Display(Name = "Tripura")]
        Tripura = 26,

        [Display(Name = "Uttar Pradesh")]
        UttarPradesh = 27,

        [Display(Name = "Uttarakhand")]
        Uttarakhand = 28,

        [Display(Name = "West Bengal")]
        WestBengal = 29
    }
}
