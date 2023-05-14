using TEntity.Service.DTOs.Users;

namespace TEntity.Service.Interfaces
{
    public interface IUserService
    {
        ValueTask<UserResultDto> CreateAsync(UserCreationDto dto);
        ValueTask<UserResultDto> UpdateAsync(UserUpdateDto dto);
        ValueTask<UserResultDto> DeleteAsync(long  id);
    }
}
