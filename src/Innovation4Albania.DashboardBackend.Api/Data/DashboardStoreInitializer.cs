namespace Innovation4Albania.DashboardBackend.Api.Data;

public sealed class DashboardStoreInitializer(InnovationDashboardStore store, ILogger<DashboardStoreInitializer> logger) : IHostedService
{
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        try
        {
            await store.InitializeAsync(cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, "Dashboard store initialization failed.");
        }
    }

    public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
}
