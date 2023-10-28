using System.Text.Json;

namespace BlazorTemplate.Server.Services
{
    public class StaticWebAssets : Rcl.Service.StaticWebAssets
    {
        public override async Task<T> ReadJsonAsync<T>(string relativePath)
        {
#if DEBUG
            var path = $"{AppContext.BaseDirectory}/wwwroot/{relativePath}";
#else
            var path = $"{AppContext.BaseDirectory}/wwwroot/_content/{RclAssemblyName}/{relativePath}";
#endif
            if (!File.Exists(path))
            {
                throw new Exception($"not find json {path}");
            }

            var contents = await File.ReadAllTextAsync(path).ConfigureAwait(false);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            return JsonSerializer.Deserialize<T>(contents, options) ?? throw new($"{path} deserialize fail");
        }
    }
}
