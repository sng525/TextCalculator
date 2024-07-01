using System.Text.Json;
using TextCalculatorWebApp.Models;

namespace TextCalculatorWebApp.Helpers
{
    public class HttpClientHelper
    {
        public HttpClient _httpClient;
        public const string LocalPath = "http://localhost:5267/api/Calculator";

        public HttpClientHelper(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<string> AddNumber(string number)
        {
            var url = $"{LocalPath}?number={Uri.EscapeDataString(number)}";
            var response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            return "Error";
        }
    }
}

