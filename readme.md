# Sefer.Backend.GeoIP.Lib
For statistical analysis, it is essential to understand the geographical location of students using an application 
built on the Sefer framework. However, many existing solutions either fail to comply with GDPR regulations or 
compromise user data control. This library, in conjunction with the GeoIP API, offers a reliable and compliant
way to access location information while ensuring that user privacy is respected. By leveraging this combination, 
developers can gather valuable insights without sacrificing data protection or user trust.

## Usage
In order to use this library in a Sefer API, use one of the following methods:

```c#
public static IServiceCollection AddGeoIPService(this IServiceCollection services, IConfiguration configuration, string section)
```

```c#
public static IHostApplicationBuilder AddGeoIPService(this IHostApplicationBuilder builder, string section)
```

```c#
public static IGeoIPService GetGeoIPService(this IServiceProvider serviceProvider)
```

Make sure that when you use this method, the configuration includes two values:
1. **Service**: The URL of the GeoIP API
2. **ApiKey**: The necessary API key to access the API

When utilizing the shared configuration library, this information is automatically included.

## License
GPL-3.0-or-later