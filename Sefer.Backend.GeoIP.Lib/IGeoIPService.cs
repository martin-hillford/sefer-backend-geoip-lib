namespace Sefer.Backend.GeoIP.Lib;

public interface IGeoIPService
{
    public Task<GeoIPInfo?> GetInfo(string ipAddress, bool store = true);
}