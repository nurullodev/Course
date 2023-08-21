using OLMS.Service.DTOs.Teachers;

namespace OLMS.Service.Interfaces;

public interface ITeacherService
{
    ValueTask<TeacherResultDto> AddAsync(TeacherCreationDto dto);
    ValueTask<TeacherResultDto> ModifyAsync(TeacherUpdateDto dto);
    ValueTask<bool> RemoveAsync(long id);
    ValueTask<TeacherResultDto> RetrieveByIdAsync(long id);
    ValueTask<IEnumerable<TeacherResultDto>> RetrieveAllAsync();
}