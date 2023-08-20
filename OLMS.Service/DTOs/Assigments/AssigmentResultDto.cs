using OLMS.Service.DTOs.Lessons;

namespace OLMS.Service.DTOs.Assigments;

public class AssigmentResultDto
{
    public long Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public short Term { get; set; }
    public LessonCreationDto Lesson { get; set; }
}