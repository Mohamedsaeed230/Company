using System.ComponentModel.DataAnnotations;

namespace Company.PL.ViewModels._Auth
{
    public class ForgetPasswordViewModel
    {
        [Required(ErrorMessage = "Email Is Required !!")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
    }
}
