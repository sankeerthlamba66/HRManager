using AutoMapper;

namespace HRManager.Data.Entity
{
    internal class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<HRManager.Data.Entity.Entities.EmployeeProfessionalInfo, HRManager.Models.EntityViews.EmployeeProfessionalInfo>().ReverseMap();
            CreateMap<HRManager.Data.Entity.Entities.EmployeePersonalInfo, HRManager.Models.EntityViews.EmployeePersonalInfo>().ReverseMap();
            CreateMap<HRManager.Data.Entity.Entities.EmployeeBankInfo, HRManager.Models.EntityViews.EmployeeBankInfo>().ReverseMap();
            CreateMap<HRManager.Data.Entity.Entities.EmployeeDocument,HRManager.Models.EntityViews.EmployeeDocument> ().ReverseMap();
            CreateMap<HRManager.Data.Entity.Entities.EmployeeInsuranceInfo, HRManager.Models.EntityViews.EmployeeInsuranceInfo>().ReverseMap();
            CreateMap<HRManager.Data.Entity.Entities.EmployeePFandESIInfo,HRManager.Models.EntityViews.EmployeePFandESIInfo> ().ReverseMap();
        }
    }
}
