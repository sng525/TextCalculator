using Microsoft.AspNetCore.Mvc;
using TextCalculatorApi;

namespace TextCalculatorWebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly CalculatorService _calculatorService;

    public CalculatorController(CalculatorService calculatorService)
    {
        _calculatorService = calculatorService;
    }

    // public IActionResult Add(string number)
    [HttpGet("{number}")]
    // [HttpGet]
    public string Add(string number)
    {
        var result = _calculatorService.Add(number);
        return result;
    }
}

