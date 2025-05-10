namespace Sefer.Backend.GeoIP.Lib;

public class GeoIPService(IHttpClientFactory httpClientFactory, IOptions<GeoIPOptions> options) : IGeoIPService
{
    protected readonly GeoIPOptions? Options = options?.Value;

    private readonly IHttpClientFactory? _httpClientFactory = httpClientFactory;

    public async Task<GeoIPInfo?> GetInfo(string ipAddress, bool store = true)
    {
        try
        {
            var value = store ? "true" : "false";
            var requestUri = $"{Options?.Service}/{ipAddress}?apiKey={Options?.ApiKey}&store={value}";
            return await GetJsonAsync<GeoIPInfo>(requestUri);
        }
        catch (Exception) { return null; }
    }

    public async Task<T?> GetJsonAsync<T>(string requestUri)
    {
        var client = (_httpClientFactory?.CreateClient()) ?? throw new NullReferenceException("No HttpClientFactory configured.");
        var response = await client.GetAsync(requestUri);
        if (!response.IsSuccessStatusCode) return default;

        var json = await response.Content.ReadAsStringAsync();
        var options = DefaultJsonOptions.GetOptions();
        return JsonSerializer.Deserialize<T>(json, options);
    }
}