﻿using Company.DAL.Models;
using System.ComponentModel.DataAnnotations;
namespace Company.PL.ViewModels.Projects
{
    public class ProjectViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name Is Required !!")]
        public string Name { get; set; }
        public string Location { get; set; }
        [Required(ErrorMessage = "City Is Required !!")]
        public string City { get; set; }
        public int? DepartmentsId { get; set; } //F.k
        public Department? Departments { get; set; }//Navigation Property
    }
}
