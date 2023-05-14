using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEntity.Domain.Enums;

namespace TEntity.Service.DTOs.Users
{
    public class UserUpdateDto
    {
        public string PhoneNumber { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}
