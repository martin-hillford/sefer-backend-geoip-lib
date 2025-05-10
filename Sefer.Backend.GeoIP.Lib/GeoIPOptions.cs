namespace Sefer.Backend.GeoIP.Lib;

/// <summary>
/// Class to contain the options to contact the GeoIP service
/// </summary>
public class GeoIPOptions
{
    /// <summary>
    /// The endpoint of the service itself (without the /generate)
    /// </summary>
    public string? Service { get; set; }

    /// <summary>
    /// The ApiKey used to contact the GeoIP service
    /// </summary>
    public string? ApiKey { get; set; }
}