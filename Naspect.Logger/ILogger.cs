namespace Naspect.Logger
{
    public interface ILogger
    {
        void Debug(Log log);
        void Info(Log log);
        void Warn(Log log);
        void Error(Log log);
    }
}
