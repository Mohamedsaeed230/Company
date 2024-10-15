using AutoMapper;
using Company.DAL.Models;
using Company.PL.ViewModels.Departments;

namespace Company.PL.Mapping.Departments
{
    public class DepartmentProfiler : Profile
    {
        public DepartmentProfiler()
        {
            CreateMap<Department, DepartmentViewModel>().ReverseMap();
        }
    }
}
