using OLMS.Service.DTOs.Users;

namespace OLMS.Service.Interfaces;

public interface IUserService
{
    ValueTask<UserResultDto> AddAsync(UserCreationDto dto);
    ValueTask<UserResultDto> ModifyAsync(UserCreationDto dto);
    ValueTask<bool> RemoveAsync(long  id);
    ValueTask<UserResultDto> RetrieveByIdAsync(long id);
    ValueTask<IEnumerable<UserResultDto>> RetrieveAllAsync();
}
