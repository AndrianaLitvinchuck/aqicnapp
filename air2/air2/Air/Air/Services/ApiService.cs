using Air.Models;
using Air.Models.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Air.Services
{
    public class ApiService : IHostedService, IDisposable
    {
        private int executionCount = 0;
        private readonly ILogger<ApiService> _logger;
        private Timer _timer;
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly AQICN _aQ;
        private readonly APIUrls _urls;

        public ApiService(
            ILogger<ApiService> logger,
            IServiceScopeFactory scopeFactory,
            IOptions<APIUrls> urls)
        {
            _logger = logger;
            _scopeFactory = scopeFactory;            
            _aQ = new AQICN();
            _urls = urls.Value;
        }

        public Task StartAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Timed Hosted Service running.");

            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromSeconds(3600));

            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            var count = Interlocked.Increment(ref executionCount);
            foreach (var url in _urls.Urls)
            {
                using (var scope = _scopeFactory.CreateScope())
                {
                    var _ctx = scope.ServiceProvider.GetRequiredService<AppCtx>();

                    var x = _aQ.GetData(url);
                    if (x.Status == "ok")
                    {
                        var storage = new Storage(_ctx);
                        storage.WriteData(x.Data);
                    }
                }
            }

            _logger.LogInformation(
                "Timed Hosted Service is working. Count: {Count}", count);
        }

        public Task StopAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Timed Hosted Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
