using OLMS.Service.DTOs.Courses;

namespace OLMS.Service.DTOs.Categories;

public class CategoryWithCoursesDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<CourseResultDto> Courses { get; set; }
}