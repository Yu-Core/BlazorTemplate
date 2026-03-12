using System.Text.Json;

namespace BlazorTemplate.Rcl.Service
{
    public interface IStaticWebAssets
    {
        Task<T> ReadRclJsonAsync<T>(string relativePath, string? assemblyName = null, JsonSerializerOptions? options = null);
        Task<T> ReadJsonAsync<T>(string relativePath, JsonSerializerOptions? options = null);
    }
}
