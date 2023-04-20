using System.ComponentModel.DataAnnotations;

namespace LoginSignupIdentity.Models
{
    public class Client
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Please Enter your First Name")]
        public string FirstName { get; set; }

        public string LastName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please Enter your Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter your Password")]
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Country { get; set; }
        [Required(ErrorMessage = "Please Enter your Mobile Number")]
        public string PhoneNumber { get; set; }
        

    }
}
