using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEntity.Service.DTOs.Users
{
    public class UserImageResultDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public long UserId { get; set; }
    }
}
