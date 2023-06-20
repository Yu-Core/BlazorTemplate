using BlazorTemplate.Shared;
using System.Text.Json;

namespace BlazorTemplate.Maui.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        public async Task<WeatherForecast[]> GetForecastAsync()
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("wwwroot/_content/BlazorTemplate.Rcl/sample-data/weather.json");
            using var reader = new StreamReader(stream);
            var contents = reader.ReadToEnd();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            return JsonSerializer.Deserialize<WeatherForecast[]>(contents, options) ?? throw new("not find weather.json");
        }
    }
}
