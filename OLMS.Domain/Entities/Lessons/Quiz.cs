using OLMS.Domain.Commons;

namespace OLMS.Domain.Entities.Lessons;

public class Quiz : Auditable
{
    public string Question { get; set; }
    public string VariantOne { get; set; }
    public string VariantTwo { get; set; }
    public string VariantThree { get; set; }
    public string Answer { get; set; }
    public long LessonId { get; set; }
    public Lesson Lesson { get; set; }
}