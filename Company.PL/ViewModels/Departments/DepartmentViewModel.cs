using Company.DAL.Models;
using System.ComponentModel.DataAnnotations;
namespace Company.PL.ViewModels.Departments
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Code Is Required")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Name Is Required")]
        public string Name { get; set; }

        public DateTime DateOfCreation { get; set; }


        public ICollection<Employee>? employees { get; set; }
    }
}
