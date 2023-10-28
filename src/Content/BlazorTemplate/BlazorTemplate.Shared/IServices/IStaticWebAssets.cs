namespace BlazorTemplate.Shared
{
    public interface IStaticWebAssets
    {
        Task<T> ReadJsonAsync<T>(string relativePath);
    }
}
