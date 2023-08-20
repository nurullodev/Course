namespace OLMS.Service.DTOs.Users;

public class UserCreationDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime DateOfBirth { get; set; }
    public double CoursePayment { get; set; }
    public long CourseId { get; set; }
}
