using System;
using OLMS.Domain.Commons;
using OLMS.Domain.Entities.Courses;

namespace OLMS.Domain.Entities.Users;

public class User : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime DateOfBirth { get; set; }
    public long CourseId { get; set; }
    public Course Course { get; set; }
}