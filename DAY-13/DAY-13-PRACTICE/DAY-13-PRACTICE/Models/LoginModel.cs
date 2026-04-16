using System.ComponentModel.DataAnnotations;

namespace DAY_13_PRACTICE.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="UserName is required")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Password is equired")]

        public string Password { get; set; }    
    }
}
