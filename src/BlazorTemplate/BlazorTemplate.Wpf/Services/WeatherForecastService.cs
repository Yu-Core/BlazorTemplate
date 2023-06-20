using BlazorTemplate.Shared;
using System.IO;
using System.Text.Json;

namespace BlazorTemplate.Wpf.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        public async Task<WeatherForecast[]> GetForecastAsync()
        {
            using var reader = new StreamReader("wwwroot/sample-data/weather.json");
            var contents = await reader.ReadToEndAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            return JsonSerializer.Deserialize<WeatherForecast[]>(contents, options) ?? throw new("not find weather.json");
        }
    }
}
