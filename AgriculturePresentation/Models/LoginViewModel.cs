using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Please Enter Username")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        public string password { get; set; }
    }
}
