using TEntity.Domain.Commons;

namespace TEntity.Domain.Entities.Users
{
    public class User : Auditable
    {
        public string PhoneNumber { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
