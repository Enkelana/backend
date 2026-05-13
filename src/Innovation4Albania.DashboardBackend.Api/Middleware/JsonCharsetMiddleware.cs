namespace Innovation4Albania.DashboardBackend.Api.Middleware;

public sealed class JsonCharsetMiddleware(RequestDelegate next)
{
    private const string Utf8JsonContentType = "application/json; charset=utf-8";

    public async Task InvokeAsync(HttpContext context)
    {
        context.Response.OnStarting(() =>
        {
            var contentType = context.Response.ContentType;
            if (!string.IsNullOrWhiteSpace(contentType) &&
                contentType.StartsWith("application/json", StringComparison.OrdinalIgnoreCase) &&
                !contentType.Contains("charset=", StringComparison.OrdinalIgnoreCase))
            {
                context.Response.ContentType = Utf8JsonContentType;
            }

            return Task.CompletedTask;
        });

        await next(context);
    }
}
