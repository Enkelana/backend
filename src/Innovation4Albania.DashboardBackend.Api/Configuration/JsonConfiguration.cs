using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using System.Text.Unicode;

namespace Innovation4Albania.DashboardBackend.Api.Configuration;

public static class JsonConfiguration
{
    public static IServiceCollection AddApiJsonConfiguration(this IServiceCollection services)
    {
        services.ConfigureHttpJsonOptions(options =>
        {
            options.SerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
            options.SerializerOptions.WriteIndented = true;
            options.SerializerOptions.Encoder = JavaScriptEncoder.Create(UnicodeRanges.All);
        });

        return services;
    }
}
