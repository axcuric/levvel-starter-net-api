using LvvlStarterNetApi.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LvvlStarterNetApi.SharedKernel.Services
{
    public class LoggerService : ILoggerService
    {
        public void LogError()
        {
            Console.WriteLine("Error Log");
        }

        public void LogInfo()
        {
            Console.WriteLine("Info Log");
        }

        public void LogWarning()
        {
            Console.WriteLine("Warning Log");
        }
    }
}
