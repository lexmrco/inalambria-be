using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Inalambria.WebApi.NLog
{
    public interface ILoggerManager
    {
        void LogInfo(string message);
        void LogInfo(ModelStateDictionary modelState);
        void LogError(object obj);
        void LogWarn(string message);
        void LogDebug(string message);
        void LogError(string message);
    }
}
