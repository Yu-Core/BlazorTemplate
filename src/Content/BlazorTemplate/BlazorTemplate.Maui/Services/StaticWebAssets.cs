using System.Text.Json;

namespace BlazorTemplate.Maui.Services
{
    public class StaticWebAssets : Rcl.Service.StaticWebAssets
    {
        protected override async Task<T> ReadJsonAsyncCore<T>(string relativePath, JsonSerializerOptions options)
        {
            string path = Path.Combine("wwwroot", relativePath);
            bool exists = await FileSystem.AppPackageFileExistsAsync(path).ConfigureAwait(false);
            if (!exists)
                throw new FileNotFoundException($"Json file not found.", path);

            using var stream = await FileSystem.OpenAppPackageFileAsync(path).ConfigureAwait(false);

            return await JsonSerializer.DeserializeAsync<T>(stream, options).ConfigureAwait(false)
                   ?? throw new JsonException($"Failed to deserialize json file: {path}");
        }
    }
}
