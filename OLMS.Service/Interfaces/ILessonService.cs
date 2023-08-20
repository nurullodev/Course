using OLMS.Service.DTOs.Lessons;

namespace OLMS.Service.Interfaces;

public interface ILessonService
{
    ValueTask<LessonResultDto> AddAsync(LessonCreationDto dto);
    ValueTask<LessonResultDto> ModifyAsync(LessonCreationDto dto);
    ValueTask<bool> RemoveAsync(long id);
    ValueTask<bool> DeleteAsync(long id);
    ValueTask<LessonResultDto> RetrieveByIdAsync(long id);
    ValueTask<IEnumerable<LessonResultDto>> RetrieveAllAsync();
}