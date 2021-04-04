using LvvlStarterNetApi.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LvvlStarterNetApi.Core.Services
{
    public class ExampleService : IExampleService
    {
        private readonly ILoggerService _logger;
        public ExampleService(ILoggerService loggerService)
        {
            _logger = loggerService;
        }
        public void Add()
        {
            _logger.LogDebug("Add");
        }

        public void Delete()
        {
            _logger.LogDebug("Delete");
        }

        public void Get()
        {
            _logger.LogDebug("Get");
        }

        public void Update()
        {
            _logger.LogDebug("Update");
        }
    }
}
