using AutoMapper;
using Company.DAL.Models;
using Company.PL.ViewModels.Dependents;

namespace Company.PL.Mapping.Dependents
{
    public class DependentProfile : Profile
    {
        public DependentProfile()
        {
            CreateMap<Dependent, DependentViewModel>().ReverseMap();
        }
    }
}
