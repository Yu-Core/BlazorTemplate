using BlazorTemplate.Shared;
using System.Net.Http.Json;

namespace BlazorTemplate.WebAssembly.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private HttpClient HttpClient { get; set; }

        public WeatherForecastService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<WeatherForecast[]> GetForecastAsync()
        {
            var result = await HttpClient.GetFromJsonAsync<WeatherForecast[]>("_content/BlazorTemplate.Rcl/sample-data/weather.json");
            return result ?? throw new Exception("not find weather.json");
        }
    }
}
