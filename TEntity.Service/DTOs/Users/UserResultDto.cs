using System.ComponentModel.DataAnnotations;
using TEntity.Domain.Enums;

namespace TEntity.Service.DTOs.Users
{
    public class UserResultDto
    {
        public string PhoneNumber { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public UserRole Role { get; set; }
    }
}
