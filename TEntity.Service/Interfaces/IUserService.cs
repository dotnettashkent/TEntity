using System.Linq.Expressions;
using TEntity.Domain.Entities.Users;
using TEntity.Service.DTOs.Users;

namespace TEntity.Service.Interfaces
{
    public interface IUserService
    {
        ValueTask<UserResultDto> CreateAsync(UserCreationDto dto);
        ValueTask<UserResultDto> UpdateAsync(UserUpdateDto dto);
        ValueTask<bool> DeleteAsync(long  id);
        ValueTask<IEnumerable<UserResultDto>> GetAllAsync(Expression<Func<User,bool>> expression = null, string search = null);
        ValueTask<UserResultDto> GetByIdAsync(long id);
        ValueTask<UserResultDto> ChangePasswordAsync(UserChangePasswordDto dto);
        ValueTask<UserImageResultDto> ImageUploadAsync(UserImageCreationDto dto);
        ValueTask<UserImageResultDto> GetImageAsync(long userId);
        ValueTask<bool> DeleteImageAsync(long userId);
        ValueTask<UserResultDto> CheckAsync(string email, string password = null);
        ValueTask<UserResultDto> UserVerify(string code);
    }
}
