using System.Net.Http.Json;
using System.Text.Json;

namespace BlazorTemplate.WebAssembly.Services
{
    public class StaticWebAssets : Rcl.Service.StaticWebAssets
    {
        private readonly HttpClient _httpClient;

        public StaticWebAssets(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        protected override async Task<T> ReadJsonAsyncCore<T>(string relativePath, JsonSerializerOptions options)
        {
            return await _httpClient.GetFromJsonAsync<T>(relativePath, options).ConfigureAwait(false)
                ?? throw new JsonException($"Failed to deserialize json from '{relativePath}'.");
        }
    }
}
