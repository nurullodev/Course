namespace OLMS.Service.DTOs.Assigments;

public class AssigmentCreationDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public short Term { get; set; }
    public long LessonId { get; set; }
}
