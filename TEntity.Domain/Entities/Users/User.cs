using TEntity.Domain.Commons;
using TEntity.Domain.Enums;

namespace TEntity.Domain.Entities.Users
{
    public class User : Auditable
    {
        public string PhoneNumber { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; } = UserRole.User;
    }
}
