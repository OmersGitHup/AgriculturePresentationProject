using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Please Enter Username !")]
        public string userName { get; set; }


        [Required(ErrorMessage = "Please Enter Mail !")]
        public string mail { get; set; }


        [Required(ErrorMessage = "Please Enter Password !")]
        public string password { get; set; }


        [Required(ErrorMessage = "Please Enter Password !")]
        [Compare("password",ErrorMessage ="Password is not valid !")]
        public string PasswordConfirm { get; set; }


    }
}
