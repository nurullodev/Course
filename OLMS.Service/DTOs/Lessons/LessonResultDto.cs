using OLMS.Service.DTOs.Courses;

namespace OLMS.Service.DTOs.Lessons;

public class LessonResultDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public CourseResultDto Course { get; set; }
}
