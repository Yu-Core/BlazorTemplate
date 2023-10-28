using System.Text.Json;

namespace BlazorTemplate.Maui.Services
{
    public class StaticWebAssets : Rcl.Service.StaticWebAssets
    {
        public override async Task<T> ReadJsonAsync<T>(string relativePath)
        {
            string path = $"wwwroot/_content/{RclAssemblyName}/{relativePath}";
            bool exists = await FileSystem.AppPackageFileExistsAsync(path).ConfigureAwait(false);
            if (!exists)
            {
                throw new Exception($"not find json {path}");
            }

            using var stream = await FileSystem.OpenAppPackageFileAsync(path).ConfigureAwait(false);
            using var reader = new StreamReader(stream);
            var contents = await reader.ReadToEndAsync().ConfigureAwait(false);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            return JsonSerializer.Deserialize<T>(contents, options) ?? throw new($"{path} deserialize fail");
        }
    }
}
