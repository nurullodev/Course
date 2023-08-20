using OLMS.Service.DTOs.Categories;

namespace OLMS.Service.Interfaces;

public interface ICourseCategoryService
{
    ValueTask<CourseCategoryResultDto> AddAsync(CourseCategoryCreationDto dto);
    ValueTask<CourseCategoryResultDto> ModifyAsync(CourseCategoryUpdateDto dto);
    ValueTask<bool> RemoveAsync(long id);
    ValueTask<bool> DeleteAsync(long id);
    ValueTask<CategoryWithCoursesDto> GetByUserIdAsync(long userId);
    ValueTask<CourseCategoryResultDto> RetrieveByIdAsync(long id);
    ValueTask<IEnumerable<CourseCategoryResultDto>> RetrieveAllAsync();
}