using AutoMapper;
using OLMS.DAL.IRepositories;
using OLMS.Service.Exceptions;
using OLMS.Service.Interfaces;
using OLMS.Service.DTOs.Teachers;
using OLMS.Domain.Entities.Teachers;

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

    public async ValueTask<TeacherResultDto> ModifyAsync(TeacherUpdateDto dto)
    {
        var existTeacher = await this.unitOfWork
            .TeacherRepository.SelectAsync(t => t.Id.Equals(dto.Id));
        if (existTeacher is null)
            throw new NotFoundException($"This teacher is not found with Id = {dto.Id}");

        var mapperTeacher = mapper.Map(dto, existTeacher);
        this.unitOfWork.TeacherRepository.Update(mapperTeacher);
        await this.unitOfWork.TeacherRepository.SaveAsync();

        return mapper.Map<TeacherResultDto>(mapperTeacher);
    }

    public async ValueTask<bool> RemoveAsync(long id)
    {
        var existTeachr = await this.unitOfWork.TeacherRepository.SelectAsync(t => t.Id.Equals(id));
        if (existTeachr is null)
            throw new NotFoundException($"This teacher is not found with Id = {id}");
        
        this.unitOfWork.TeacherRepository.Delete(existTeachr);
        await this.unitOfWork.TeacherRepository.SaveAsync();
        return true;
    }

    public async ValueTask<TeacherResultDto> RetrieveByIdAsync(long id)
    {
        var existTeachr = await this.unitOfWork.TeacherRepository.SelectAsync(t => t.Id.Equals(id));
        if (existTeachr is null)
            throw new NotFoundException($"This teacher is not found with Id = {id}");
        
        return mapper.Map<TeacherResultDto>(existTeachr);
    }

    public async ValueTask<IEnumerable<TeacherResultDto>> RetrieveAllAsync()
    {
        IQueryable<Teacher> teachers = this.unitOfWork.TeacherRepository.SelectAll();
        var mapperTeacher = mapper.Map<IEnumerable<TeacherResultDto>>(teachers);
        return mapperTeacher;
    }
}
