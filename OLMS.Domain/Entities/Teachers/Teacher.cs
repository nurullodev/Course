using OLMS.Domain.Commons;

namespace OLMS.Domain.Entities.Teachers;

public class Teacher : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Experience { get; set; }
    public string Description { get; set; }
    public double Salary { get; set; }
}