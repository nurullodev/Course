using OLMS.Domain.Commons;
using OLMS.Domain.Entities.Courses;

namespace OLMS.Domain.Entities.Lessons;

public class Lesson : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
    public long CourseId { get; set; }
    public Course Course { get; set; }
}