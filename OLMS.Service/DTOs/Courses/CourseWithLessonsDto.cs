using OLMS.Service.DTOs.Categories;
using OLMS.Service.DTOs.Lessons;
using OLMS.Service.DTOs.Teachers;

namespace OLMS.Service.DTOs.Courses;

public class CourseWithLessonsDto
{
    public CourseCategoryResultDto Category { get; set; }
    public long Id { get; set; }
    public string Name { get; set; }
    public string ShortDescription { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public TeacherResultDto Teacher { get; set; }
    public IEnumerable<LessonCreationDto> Lessons { get; set; }
}