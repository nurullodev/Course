namespace OLMS.Service.DTOs.Assigments;

public class AssigmentUpdateDto
{
    public long Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public short Term { get; set; }
    public long LessonId { get; set; }
}
