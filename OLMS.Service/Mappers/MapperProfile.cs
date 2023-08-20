using AutoMapper;
using OLMS.Service.DTOs.Users;
using OLMS.Service.DTOs.Lessons;
using OLMS.Service.DTOs.Courses;
using OLMS.Service.DTOs.Quizzes;
using OLMS.Service.DTOs.Teachers;
using OLMS.Domain.Entities.Users;
using OLMS.Domain.Entities.Lessons;
using OLMS.Service.DTOs.Assigments;
using OLMS.Service.DTOs.Categories;
using OLMS.Domain.Entities.Courses;
using OLMS.Domain.Entities.Teachers;
using OLMS.Domain.Entities.CourseCategories;

namespace OLMS.Service.Mappers;

public class MapperProfile : Profile
{
    public MapperProfile()
    {

        CreateMap<User, UserCreationDto>().ReverseMap();
        CreateMap<User, UserUpdateDto>().ReverseMap();
        CreateMap<User, UserResultDto>().ReverseMap();

        CreateMap<Quiz, QuizCreationDto>().ReverseMap();
        CreateMap<Quiz, QuizUpdateDto>().ReverseMap();
        CreateMap<Quiz, QuizResultDto>().ReverseMap();

        CreateMap<Course, CourseCreationDto>().ReverseMap();
        CreateMap<Course, CourseUpdateDto>().ReverseMap();
        CreateMap<Course, CourseResultDto>().ReverseMap();

        CreateMap<Lesson, LessonCreationDto>().ReverseMap();
        CreateMap<Lesson, LessonUpdateDto>().ReverseMap();
        CreateMap<Lesson, LessonResultDto>().ReverseMap();

        CreateMap<Teacher, TeacherCreationDto>().ReverseMap();
        CreateMap<Teacher, TeacherUpdateDto>().ReverseMap();
        CreateMap<Teacher, TeacherResultDto>().ReverseMap();

        CreateMap<Assigment, AssigmentCreationDto>().ReverseMap();
        CreateMap<Assigment, AssigmentUpdateDto>().ReverseMap();
        CreateMap<Assigment, AssigmentResultDto>().ReverseMap();

        CreateMap<CourseCategory, CourseCategoryCreationDto>().ReverseMap();
        CreateMap<CourseCategory, CourseCategoryUpdateDto>().ReverseMap();
        CreateMap<CourseCategory, CourseCategoryResultDto>().ReverseMap();
    }
}
