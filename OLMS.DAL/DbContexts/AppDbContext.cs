using System;
using OLMS.Domain.Entities.Users;
using OLMS.Domain.Entities.Courses;
using OLMS.Domain.Entities.Lessons;
using OLMS.Domain.Entities.Teachers;
using Microsoft.EntityFrameworkCore;
using OLMS.Domain.Entities.CourseCategories;

namespace OLMS.DAL.DbContexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }
    public DbSet<CourseCategory> CourseCategories { get; set;}
    public DbSet<Course> Courses { get; set;}
    public DbSet<Teacher> Teachers { get; set;}
    public DbSet<Lesson> Lessons { get; set;}
    public DbSet<Quiz> Quizzes { get; set;}
    public DbSet<Assigment> Assigments { get; set;}
    public DbSet<User> Users { get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Fluent API relations
        modelBuilder.Entity<Course>()
            .HasOne(c => c.CourseCategory)
            .WithMany()
            .HasForeignKey(c => c.CategoryId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Course>()
            .HasOne(t => t.Teacher)
            .WithMany()
            .HasForeignKey(t => t.TeacherId)
            .OnDelete(DeleteBehavior.NoAction);
        
        modelBuilder.Entity<Lesson>()
            .HasOne(c =>c.Course)
            .WithMany()
            .HasForeignKey(c => c.CourseId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Assigment>()
            .HasOne(l => l.Lesson)
            .WithMany()
            .HasForeignKey(l => l.LessonId)
            .OnDelete(DeleteBehavior.NoAction);
        
        modelBuilder.Entity<Quiz>()
            .HasOne(l => l.Lesson)
            .WithMany()
            .HasForeignKey(l => l.LessonId)
            .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region Seed data
        modelBuilder.Entity<CourseCategory>().HasData(
            new CourseCategory 
            { 
                Id = 1, 
                Name = "Programming", 
                CreatedAt = DateTime.UtcNow, 
                UpdatedAt = null 
            });
        
        modelBuilder.Entity<Course>().HasData(
            new Course 
            {
                Id = 1, 
                Name = ".net", 
                ShortDescription = "Good", 
                Description = "This course is very good",
                Price = 2000000,
                CategoryId = 1, 
                TeacherId = 1,
                CreatedAt = DateTime.UtcNow, 
                UpdatedAt = null
            });

        modelBuilder.Entity<Lesson>().HasData(
            new Lesson
            {
                Id = 1,
                CourseId = 1,
                Name = "Kirish",
                Description = ". net ga kirish",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = null
            });

        modelBuilder.Entity<Quiz>().HasData(
            new Quiz
            {
                Id = 1,
                Question = ". net nima ?",
                VariantOne = "Framework",
                VariantTwo = "Library",
                VariantThree = "Programming language",
                Answer = "Framework",
                LessonId = 1,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = null
            });

        modelBuilder.Entity<Assigment>().HasData(
            new Assigment
            {
                Id = 1,
                Title = "read a documentation",
                Description = "birichi mavzu boycha qoshimcha malumot topish!",
                LessonId = 1,
                Term = 4,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = null
            });

        modelBuilder.Entity<Teacher>().HasData(
            new Teacher
            {
                Id = 1,
                FirstName = "Aqilbek",
                LastName = "Aqilov",
                Description = "Very good teacher",
                Experience = "4 yil",
                Phone = "+998992002526",
                Salary = 50000751,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = null
            });

        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                FirstName = "Krasavchik",
                LastName = "Ikromov",
                Phone = "+998992002526",
                DateOfBirth = DateTime.UtcNow,
                CourseId = 1,
                CoursePayment = 50000751,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = null
            });
        #endregion
    }
}
