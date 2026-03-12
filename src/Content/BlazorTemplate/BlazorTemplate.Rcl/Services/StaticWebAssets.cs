using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlazorTemplate.Rcl.Service
{
    public abstract class StaticWebAssets : IStaticWebAssets
    {
        public static string AssemblyName { get; } = typeof(StaticWebAssets).Assembly.GetName().Name!;

        protected virtual JsonSerializerOptions DefaultJsonSerializerOptions { get; set; } = new()
        {
            PropertyNameCaseInsensitive = true,
            Converters =
            {
                new JsonStringEnumConverter()
            }
        };

        public Task<T> ReadRclJsonAsync<T>(string relativePath, string? assemblyName = null, JsonSerializerOptions? options = null)
            => ReadJsonAsync<T>($"_content/{assemblyName ?? AssemblyName}/{relativePath}", options);

        public Task<T> ReadJsonAsync<T>(string relativePath, JsonSerializerOptions? options = null)
            => ReadJsonAsyncCore<T>(NormalizePath(relativePath), options ?? DefaultJsonSerializerOptions);

        protected abstract Task<T> ReadJsonAsyncCore<T>(string relativePath, JsonSerializerOptions options);

        private static string NormalizePath(string filename) =>
            filename
                .Replace('\\', Path.DirectorySeparatorChar)
                .Replace('/', Path.DirectorySeparatorChar);
    }
}
