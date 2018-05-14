using System;

namespace Naspect.Logger
{
    public abstract class Log
    {
    }

    public class InfoLog : Log
    {
        private string message;
        public InfoLog(string message)
        {
            this.Message = message;
        }

        public string Message { get => message; set => message = value; }

        public override string ToString() => $"{Message}";
    }

    public class ExceptionLog : Log
    {
        private Exception exception;
        public ExceptionLog(Exception exception)
        {
            this.Exception = exception;
        }

        public Exception Exception { get => exception; private set => exception = value; }

        public override string ToString() => $"{Exception.ToString()}";
    }
}
