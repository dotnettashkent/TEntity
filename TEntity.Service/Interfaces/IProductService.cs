using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TEntity.Domain.Entities.Products;
using TEntity.Service.DTOs.Products;

namespace TEntity.Service.Interfaces
{
    public interface IProductService
    {
        ValueTask<ProductResultDto> CreateAsync(ProductCreationDto dto);
        ValueTask<ProductResultDto> UpdateAsync(ProductUpdateDto dto);
        ValueTask<bool> DeleteAsync(long id);
        ValueTask<ProductResultDto> GetByIdAsync(long id);
        ValueTask<IEnumerable<ProductResultDto>> GetAllAsync(Expression<Func<Product,bool>> expression = null, string search = null);
    }
}
