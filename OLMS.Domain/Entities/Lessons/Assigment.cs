using OLMS.Domain.Commons;

namespace OLMS.Domain.Entities.Lessons;

public class Assigment : Auditable
{
    public string Title { get; set; }
    public string Description { get; set; }
    public short Term { get;set; }
    public long LessonId { get; set; }
    public Lesson Lesson { get; set; }
}