﻿namespace LvvlStarterNetApi.SharedKernel.Interfaces
{
    public interface ILoggerService
    {
        void LogInfo(string message);

        void LogError(string message);

        void LogWarning(string message);

        void LogDebug(string message);
    }
}