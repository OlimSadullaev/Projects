namespace SaleOrder.API
{
    public class BackgroundPrinter : IHostedService, IDisposable
    {
        private readonly ILogger logger;
        private int number = 0;
        private Timer timer;

        public BackgroundPrinter(ILogger<BackgroundPrinter> logger)
        {
            this.logger = logger;
        }

        public void Dispose()
        {
            timer?.Dispose();
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            timer = new Timer(o => logger.LogInformation("Printing From Worker"),
                null,
                TimeSpan.Zero,
                TimeSpan.FromSeconds(5));

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            logger.LogInformation("Printing worker stopped");
            return Task.CompletedTask;
        }
    }
}
