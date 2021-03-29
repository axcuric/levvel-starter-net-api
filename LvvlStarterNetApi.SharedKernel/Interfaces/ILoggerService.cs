using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LvvlStarterNetApi.SharedKernel.Interfaces
{
    public interface ILoggerService
    {
        void LogInfo();
        void LogError();
        void LogWarning();
    }
}
