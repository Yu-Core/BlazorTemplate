using System.Text.Json;

namespace BlazorTemplate.Winforms.Services
{
    public class StaticWebAssets : Rcl.Service.StaticWebAssets
    {
        protected override async Task<T> ReadJsonAsyncCore<T>(string relativePath, JsonSerializerOptions options)
        {
            var path = Path.Combine(AppContext.BaseDirectory, "wwwroot", relativePath);

            if (!File.Exists(path))
                throw new FileNotFoundException($"Json file not found.", path);

            await using var stream = File.OpenRead(path);

            return await JsonSerializer.DeserializeAsync<T>(stream, options).ConfigureAwait(false)
                   ?? throw new JsonException($"Failed to deserialize json file: {path}");
        }
    }
}
