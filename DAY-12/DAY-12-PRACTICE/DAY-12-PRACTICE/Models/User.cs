using System.ComponentModel.DataAnnotations;

namespace DAY_12_PRACTICE.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is Required")]
        [StringLength(50,ErrorMessage ="Name cannot exceed 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Email is required")]
        [EmailAddress(ErrorMessage ="Invalid email format")]
        public string Email { get; set; }

    }
}
