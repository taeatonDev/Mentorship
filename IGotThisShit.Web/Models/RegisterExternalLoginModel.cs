using System.ComponentModel.DataAnnotations;

namespace IGotThisShit.Web.Models
{
    public class RegisterExternalLoginModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public string ExternalLoginData { get; set; }
    }
}