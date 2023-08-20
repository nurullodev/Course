using OLMS.Service.DTOs.Assigments;

namespace OLMS.Service.Interfaces;

public interface IAssigmentService
{
    ValueTask<AssigmentResultDto> AddAsync(AssigmentCreationDto dto);
    ValueTask<AssigmentResultDto> ModifyAsync(AssigmentCreationDto dto);
    ValueTask<bool> DeleteAsync(long id);
    ValueTask<AssigmentResultDto> RetrieveByIdAsync(long id);
    ValueTask<IEnumerable<AssigmentResultDto>> RetrieveAllAsync();
    ValueTask<IEnumerable<AssigmentResultDto>> SearchByLessonIdAsync(long lessonId);
}