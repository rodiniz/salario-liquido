using Application.Services;
using Domain.Models.Salary;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class SalariesController : ControllerBase
{

    private readonly ISalaryService _salaryService;

    public SalariesController(ISalaryService salaryService)
    {
        _salaryService = salaryService;
    }

    [HttpPost("calculate")]
    public IActionResult Calculate(RequestModel request)
    {
        try
        {
            var liquidSalary = _salaryService.CalculateSalary(request.Country, request.Salary);
            return Ok(liquidSalary);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}
