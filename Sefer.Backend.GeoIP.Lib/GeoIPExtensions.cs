namespace Sefer.Backend.GeoIP.Lib;

public static class GeoIPExtensions
{
    public static IServiceCollection AddGeoIPService(this IServiceCollection services, IConfiguration configuration, string section)
    {
        var options = configuration.GetSection(section);
        services.Configure<GeoIPOptions>(options);
        services.AddSingleton<IGeoIPService, GeoIPService>();
        return services;
    }

    public static IHostApplicationBuilder AddGeoIPService(this IHostApplicationBuilder builder, string section)
    {
        builder.Services.AddGeoIPService(builder.Configuration, section);
        return builder;
    }

    public static IGeoIPService GetGeoIPService(this IServiceProvider serviceProvider)
    {
        return serviceProvider.GetService<IGeoIPService>()!;
    }
}