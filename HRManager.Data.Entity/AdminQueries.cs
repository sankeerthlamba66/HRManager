using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManager.Models.Views;
using HRManager.Models.ViewModels;
using AutoMapper;
using HRManager.Data.Entity.EntityRepository;

namespace HRManager.Data.Entity
{
    public class AdminQueries:IAdminQueries
    {
        private readonly Context context;
        private readonly IMapper mapper;
        public AdminQueries(Context _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        public List<EmployeeTableSummary> GetRecentlyUpdatedEmployees()
        {
            List<EmployeeTableSummary> employeeTableSummary = new List<EmployeeTableSummary>();
            var employeesPersonlInfos = context.EmployeePersonalInfos.OrderByDescending(s => s.UpdatedDate);
            foreach(var item in employeesPersonlInfos)
            {
                employeeTableSummary.Add(mapper.Map<EmployeeTableSummary>(item));
            }
            return employeeTableSummary;
        }

        public List<EmployeeTableSummary> GetRecentlyUpdatedEmployees(DateTime DateFrom, DateTime DateTo)
        {
            List<EmployeeTableSummary> employeeTableSummary = new List<EmployeeTableSummary>();
            var employeesPersonlInfos = context.EmployeePersonalInfos.Where(s=>s.UpdatedDate<=DateTo && s.UpdatedDate>=DateFrom).OrderByDescending(s => s.UpdatedDate);
            foreach (var item in employeesPersonlInfos)
            {
                employeeTableSummary.Add(mapper.Map<EmployeeTableSummary>(item));
            }
            return employeeTableSummary;
        }

        public List<EmployeeCardSummary> GetRecentlyUpdatedEmployeeCards()
        {
            List<EmployeeCardSummary> employeeCardsSummary = new List<EmployeeCardSummary>();
            var employeesPersonlInfos = context.EmployeePersonalInfos.OrderByDescending(s => s.UpdatedDate);
            foreach (var item in employeesPersonlInfos)
            {
                employeeCardsSummary.Add(mapper.Map<EmployeeCardSummary>(item));
            }
            return employeeCardsSummary;
        }

        public List<EmployeeCardSummary> GetRecentlyUpdatedEmployeeCards(DateTime DateFrom, DateTime DateTo)
        {
            List<EmployeeCardSummary> employeeCardsSummary = new List<EmployeeCardSummary>();
            var employeesPersonlInfos = context.EmployeePersonalInfos.Where(s => s.UpdatedDate <= DateTo && s.UpdatedDate >= DateFrom).OrderByDescending(s => s.UpdatedDate);
            foreach (var item in employeesPersonlInfos)
            {
                employeeCardsSummary.Add(mapper.Map<EmployeeCardSummary>(item));
            }
            return employeeCardsSummary;
        }

        public EmployeePDValidationSummary GetEmployeePDValidationSummary(int EmployeeId)
        {

            return new EmployeePDValidationSummary();
        }

        public EmployeeBGVerificationSummary GetEmployeeBGVerificationSummary(int EmployeeId)
        {
            EmployeeBGVerificationSummary employeeBGVerificationSummary = new EmployeeBGVerificationSummary();
            var employeeProfessionalInfos = context.EmployeeProfessionalInfos.Where(s => s.UserId == EmployeeId);
            foreach (var item in employeeProfessionalInfos)
            {
                employeeBGVerificationSummary.professionalDetails.Add(mapper.Map<Models.EntityViews.EmployeeProfessionalInfo>(item));
            }
            return employeeBGVerificationSummary;
        }

        public PDVEmailTemplate GetPDVEmailTemplate()
        {
            return new PDVEmailTemplate();
        }

        public BGVEmailTemplate GetBGVEmailTemplate()
        {
            return new BGVEmailTemplate();
        }

    }
}
