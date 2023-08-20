using System;
using OLMS.DAL.DbContexts;
using OLMS.DAL.Repositories;
using OLMS.DAL.IRepositories;
using System.Threading.Tasks;
using OLMS.Domain.Entities.Users;
using OLMS.Domain.Entities.Courses;
using OLMS.Domain.Entities.Lessons;
using OLMS.Domain.Entities.Teachers;
using OLMS.Domain.Entities.CourseCategories;

namespace OLMS.DAL.UOW;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext appDbContext;

    public UnitOfWork(AppDbContext appDbContext)
    {
        this.appDbContext = appDbContext;
        UserRepository = new Repository<User>(this.appDbContext);
        CourseRepository = new Repository<Course>(this.appDbContext);
        CourseCategoryRepository = new Repository<CourseCategory>(this.appDbContext);
        LessonRepository = new Repository<Lesson>(this.appDbContext);
        QuizRepository = new Repository<Quiz>(this.appDbContext);
        TeacherRepository = new Repository<Teacher>(this.appDbContext);
        AssigmentRepository = new Repository<Assigment>(this.appDbContext);
    }

    public IRepository<Quiz> QuizRepository { get; }

    public IRepository<User> UserRepository { get; }

    public IRepository<Course> CourseRepository { get; }

    public IRepository<Teacher> TeacherRepository { get; }

    public IRepository<Lesson> LessonRepository { get; }

    public IRepository<Assigment> AssigmentRepository { get; }

    public IRepository<CourseCategory> CourseCategoryRepository { get; }

    public async Task SaveAsync()
    {
        await appDbContext.SaveChangesAsync();
    }

    public void Dispose()
    {
        GC.SuppressFinalize(true);
    }
}
