using AutoMapper;
using Company.DAL.Models;
using Company.PL.ViewModels.Projects;
namespace Company.PL.Mapping.Projects
{
    public class ProjectProfile : Profile
    {
        public ProjectProfile()
        {
            CreateMap<Project, ProjectViewModel>().ReverseMap();
        }
    }
}
