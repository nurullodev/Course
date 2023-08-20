using Microsoft.AspNetCore.Mvc;
using OLMS.Service.DTOs.Teachers;
using OLMS.Service.Interfaces;

namespace OLMS.API.Controllers;

[ApiController]
[Route("api/[controller]")] 
public class TeacherController : Controller 
{
    private readonly ITeacherService teacherService;

    public TeacherController(ITeacherService service)
    {
        this.teacherService = service;
    }

    [HttpPost("Create")]
    public async Task<IActionResult> PostAsync(TeacherCreationDto dto)
    {
        var result = await this.teacherService.AddAsync(dto);
        return Ok(result);
    }
}
