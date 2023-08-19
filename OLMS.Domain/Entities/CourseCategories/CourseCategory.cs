using OLMS.Domain.Commons;
using System.Collections.Generic;
using OLMS.Domain.Entities.Courses;

namespace OLMS.Domain.Entities.CourseCategories;

public class CourseCategory : Auditable
{
    public string Name { get; set; }
    public ICollection<Course> Categories { get; set; }
}