using System.ComponentModel.DataAnnotations;

namespace TEntity.Service.DTOs.Users
{
    public class UserCreationDto
    {
        public string PhoneNumber { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
