using Naspect.Core.Extension;
using System;
using System.IO;

namespace Naspect.Logger
{
    public class BasicFileLogger : ILogger
    {
        public string LogPath { get; set; }
        public string DateTimePrefix { get; set; }

        public virtual string GetLogFileName()
        {
            return string.Format("{0}.txt", DateTime.Now.ToString(DateTimePrefix));
        }

        public void Debug(Log log)
        {
            WriteLine(log, CallerNameHelper.GetCurrentMethodName());
        }

        public void Warn(Log log)
        {
            WriteLine(log, CallerNameHelper.GetCurrentMethodName());
        }

        public void Error(Log log)
        {
            WriteLine(log, CallerNameHelper.GetCurrentMethodName());
        }

        public void Info(Log log)
        {
            WriteLine(log, CallerNameHelper.GetCurrentMethodName());
        }
        public void WriteLine(Log log, string prefix)
        {
            string logName = GetLogFileName();

            string path = System.IO.Path.Combine(LogPath, logName);

            if (!Directory.Exists((LogPath)))
                Directory.CreateDirectory(LogPath);

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(log.ToString());
                sw.Close();
            }
        }
    }
}
