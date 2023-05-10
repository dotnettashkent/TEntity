using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEntity.Domain.Commons;

namespace TEntity.Domain.Entities.Products
{
    public class Product : Auditable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        
    }
}
