using OLMS.Service.DTOs.Courses;

namespace OLMS.Service.Interfaces;

public interface ICourseService
{
    ValueTask<CourseResultDto> AddAsync(CourseCreationDto dto);
    ValueTask<CourseResultDto> ModifyAsync(CourseUpdateDto dto);
    ValueTask<bool> RemoveAsync(long id);
    ValueTask<bool> DeleteAsync(long id);
    ValueTask<CourseWithLessonsDto> GetbyId(long courseId);
    ValueTask<CourseResultDto> RetrieveByIdAsync(long id);
    ValueTask<IEnumerable<CourseResultDto>> RetrieveAllAsync();
}