namespace OLMS.Service.DTOs.Teachers;

public class TeacherUpdateDto
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Experience { get; set; }
    public string Description { get; set; }
    public double Salary { get; set; }
}