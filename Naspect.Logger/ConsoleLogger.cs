using System;

namespace Naspect.Logger
{
    public class ConsoleLogger : ILogger
    {
        public void Debug(Log log)
        {
            if (log != null)
                Log(log, "Debug");
        }

        public void Error(Log log)
        {
            if (log != null)
                Log(log, "Error");
        }

        public void Info(Log log)
        {
            if (log != null)
                Log(log);
        }

        public void Warn(Log log)
        {
            if (log != null)
                Log(log, "Warn");
        }

        private void Log(Log log, string prefix = "Info")
        {
            Console.WriteLine(GetMessage(log, prefix));
        }

        private string GetMessage(Log log, string prefix)
        {
            return $"{prefix} :{log.ToString()}";
        }
    }
}
