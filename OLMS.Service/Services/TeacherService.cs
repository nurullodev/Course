using AutoMapper;
using OLMS.DAL.IRepositories;
using OLMS.DAL.UOW;
using OLMS.Domain.Entities.Teachers;
using OLMS.Service.DTOs.Teachers;
using OLMS.Service.Exceptions;
using OLMS.Service.Interfaces;

namespace OLMS.Service.Services;

public class TeacherService : ITeacherService
{
    private readonly IMapper mapper;
    private readonly IUnitOfWork unitOfWork;
    public TeacherService(IMapper mapper, IUnitOfWork unitOfWork)
    {
        this.mapper = mapper;
        this.unitOfWork = unitOfWork;
    }

    public async ValueTask<TeacherResultDto> AddAsync(TeacherCreationDto dto)
    {
        Teacher existingTeacher = await this.unitOfWork
                                .TeacherRepository.SelectAsync(t => t.Phone.Equals(dto.Phone));
        if (existingTeacher is not null)
            throw new NotFoundException($"This teacher already exist with phone = {dto.Phone}");

        var mapperTeacher = mapper.Map<Teacher>(dto);   
        await this.unitOfWork.TeacherRepository.CreateAsync(mapperTeacher);
        await this.unitOfWork.TeacherRepository.SaveAsync();

        return mapper.Map<TeacherResultDto>(mapperTeacher);
    }

    public ValueTask<TeacherResultDto> ModifyAsync(TeacherCreationDto dto)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> RemoveAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<IEnumerable<TeacherResultDto>> RetrieveAllAsync()
    {
        throw new NotImplementedException();
    }

    public ValueTask<TeacherResultDto> RetrieveByIdAsync(long id)
    {
        throw new NotImplementedException();
    }
}
