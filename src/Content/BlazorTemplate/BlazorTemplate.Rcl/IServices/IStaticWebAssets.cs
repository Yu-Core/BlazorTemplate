namespace BlazorTemplate.Rcl.IService
{
    public interface IStaticWebAssets
    {
        Task<T> ReadJsonAsync<T>(string relativePath);
    }
}
