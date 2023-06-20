using BlazorTemplate.Shared;
using System.Text.Json;

namespace BlazorTemplate.Photino.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        public async Task<WeatherForecast[]> GetForecastAsync()
        {
            string path = "wwwroot/sample-data/weather.json";
            if (!File.Exists(path))
            {
                path = "wwwroot/_content/BlazorTemplate.Rcl/sample-data/weather.json";
            }

            var json = await File.ReadAllTextAsync(path);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            return JsonSerializer.Deserialize<WeatherForecast[]>(json, options) ?? throw new("not find weather.json");
        }
    }
}
