using Microsoft.AspNetCore.Mvc;
using TextCalculatorApi;

namespace TextCalculatorWebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly CalculatorService _calculatorService;

    public CalculatorController()
    {
        _calculatorService = new CalculatorService();
    }

    [HttpGet]
    public string Add(string number)
    {
        var result = _calculatorService.Add(number);
        return result;
    }
}

