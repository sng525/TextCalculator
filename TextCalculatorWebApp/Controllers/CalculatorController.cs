using Microsoft.AspNetCore.Mvc;
using TextCalculatorWebApp.Helpers;
using TextCalculatorWebApp.Models;

namespace TextCalculatorWebApp.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly HttpClientHelper _client;

        public CalculatorController(HttpClientHelper client)
        {
            _client = client;
        }

        [HttpGet]
        public async Task<IActionResult> Index(CalculatorModel calculator)
        {
            if (ModelState.IsValid) {
                var result = await _client.AddNumber(calculator.number);
                calculator.result = result;
            }
            return View(calculator);
        }
    }
}

