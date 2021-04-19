using LvvlStarterNetApi.SharedKernel.Interfaces;
using NLog;

namespace LvvlStarterNetApi.SharedKernel.SharedServices
{
    public class LoggerService : ILoggerService
    {
        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();

        public LoggerService()
        {
        }

        public void LogError(string message)
        {
            logger.Error(message);
        }

        public void LogInfo(string message)
        {
            logger.Info(message);
        }

        public void LogWarning(string message)
        {
            logger.Warn(message);
        }

        public void LogDebug(string message)
        {
            logger.Debug(message);
        }
    }
}