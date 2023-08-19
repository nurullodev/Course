using OLMS.Domain.Commons;
using System.Collections.Generic;
using OLMS.Domain.Entities.Lessons;
using OLMS.Domain.Entities.Teachers;
using OLMS.Domain.Entities.CourseCategories;

namespace OLMS.Domain.Entities.Courses;

public class Course : Auditable
{
    public string Name { get; set; }
    public string ShortDescription { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

    public ICollection<Lesson> Lessons { get; set; }

    public long CategoryId { get; set; }
    public CourseCategory CourseCategory { get; set; }

    public long TeacherId { get; set; }
    public Teacher Teacher { get; set; }
}