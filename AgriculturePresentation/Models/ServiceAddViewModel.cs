using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class ServiceAddViewModel
    {
        [Display(Name ="Title")]
        [Required(ErrorMessage ="You must enter Title")]
        public string Title { get; set; }


        [Display(Name = "Image")]
        [Required(ErrorMessage = "You must enter Image")]
        public string Image { get; set; }


        [Display(Name = "Description")]
        [Required(ErrorMessage = "You must enter Description")]
        public string Description { get; set; }

    }
}
