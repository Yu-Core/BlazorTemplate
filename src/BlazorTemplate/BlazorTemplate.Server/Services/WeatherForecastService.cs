using BlazorTemplate.Shared;
using System.Text.Json;

namespace BlazorTemplate.Server.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        public async Task<WeatherForecast[]> GetForecastAsync()
        {
            using var reader = new StreamReader($"{AppContext.BaseDirectory}/wwwroot/sample-data/weather.json");
            var contents = await reader.ReadToEndAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            return JsonSerializer.Deserialize<WeatherForecast[]>(contents, options) ?? throw new("not find weather.json");
        }
    }
}
