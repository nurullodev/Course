using OLMS.Service.Models;
using OLMS.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using OLMS.Service.DTOs.Teachers;

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
        => Ok(new Response
        {
            Status = 200,
            Message = "Success",
            Data = await this.teacherService.AddAsync(dto)
        });

    [HttpPut("update")]
    public async Task<IActionResult> UpdateAsync(TeacherUpdateDto dto)
        => Ok(new Response
        {
            Status = 200,
            Message = "Success",
            Data = await this.teacherService.ModifyAsync(dto)
        });

    [HttpDelete("Delete")]
    public async Task<IActionResult> DeleteAsync(long id)
        => Ok(new Response
        {
            Status = 200,
            Message = "Success",
            Data = await this.teacherService.RemoveAsync(id)
        });

    [HttpGet("get/{id:long}")]
    public async Task<IActionResult> GetByIdAsync(long id)
       => Ok(new Response
       {
           Status = 200,
           Message = "Success",
           Data = await this.teacherService.RetrieveByIdAsync(id)
       });

    [HttpGet("get-all")]
    public async Task<IActionResult> GetAllAsync()
        => Ok(new Response
        {
            Status = 200,
            Message = "Success",
            Data = await this.teacherService.RetrieveAllAsync()
        });
}
