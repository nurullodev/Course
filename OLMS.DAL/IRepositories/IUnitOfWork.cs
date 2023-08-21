using System;
using System.Threading.Tasks;
using OLMS.Domain.Entities.Users;
using OLMS.Domain.Entities.Courses;
using OLMS.Domain.Entities.Lessons;
using OLMS.Domain.Entities.Teachers;
using OLMS.Domain.Entities.CourseCategories;

namespace OLMS.DAL.IRepositories;

public interface IUnitOfWork : IDisposable
{
    IRepository<User> UserRepository { get; }
    IRepository<Course> CourseRepository { get; }
    IRepository<CourseCategory> CourseCategoryRepository { get; }
    IRepository<Teacher> TeacherRepository { get; }
    IRepository<Lesson> LessonRepository { get; }
    IRepository<Quiz> QuizRepository { get; }
    IRepository<Assigment> AssigmentRepository { get; }
}