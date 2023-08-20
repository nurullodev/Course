namespace OLMS.Service.DTOs.Courses;

public class CourseUpdateDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string ShortDescription { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public long CategoryId { get; set; }
    public long TeacherId { get; set; }
}