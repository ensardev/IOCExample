using Microsoft.Extensions.Logging;
using System;

namespace IOCExample.Web.Models
{
    public class DateService : ISingletonDataService, IScopedDateService, ITransientDateService
    {
        private readonly ILogger<DateService> _logger;

        public DateService(ILogger<DateService> logger)
        {
            _logger = logger;

            _logger.LogWarning("DateService instance created.");
        }

        public DateTime GetDateTime { get; } = DateTime.Now;
    }
}
