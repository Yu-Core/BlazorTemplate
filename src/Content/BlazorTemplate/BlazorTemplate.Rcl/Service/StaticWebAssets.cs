using BlazorTemplate.Rcl.IService;

namespace BlazorTemplate.Rcl.Service
{
    public abstract class StaticWebAssets : IStaticWebAssets
    {
        private readonly Lazy<string?> _rclAssemblyName = new(() => typeof(StaticWebAssets).Assembly.GetName().Name);

        protected string? RclAssemblyName => _rclAssemblyName.Value;

        public abstract Task<T> ReadJsonAsync<T>(string relativePath);
    }
}
