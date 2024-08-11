using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System.Threading;
using System.Threading.Tasks;

namespace Alex.Service.Processor
{
    public class DataProcessor : IHostedService
    {
        private readonly ILogger<DataProcessor> _logger;
        private readonly IConfiguration _configuration;

        public DataProcessor(ILogger<DataProcessor> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Data Processor started.");
            // Initialization code here
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Data Processor stopped.");
            // Cleanup code here
            return Task.CompletedTask;
        }
    }
}
