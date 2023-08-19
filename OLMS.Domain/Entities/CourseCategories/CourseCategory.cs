using OLMS.Domain.Commons;
using System.Collections.Generic;

namespace OLMS.Domain.Entities.CourseCategories;

public class CourseCategory : Auditable
{
    public string Name { get; set; }
    public ICollection<Course> Categories { get; set; }
}

public class Course : Auditable
{
    public string Name { get; set; }
    public string ShortDescription { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

    public long CourseId { get; set; }
    public CourseCategory CourseCategory { get; set; }
}
