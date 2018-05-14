using Unity.Attributes;

namespace Naspect.Logger.Unity
{
    public class CompositeLogger : ILogger
    {
        [Dependency("FirstLogger")]
        public ILogger FirstLogger { get; set; }

        [Dependency("SecondLogger")]
        public ILogger SecondLogger { get; set; }

      
        public void Debug(Log log)
        {
            FirstLogger.Debug(log);
            SecondLogger.Debug(log);
        }

        public void Error(Log log)
        {
            FirstLogger.Error(log);
            SecondLogger.Error(log);
        }

        public void Info(Log log)
        {
            FirstLogger.Info(log);
            SecondLogger.Info(log);
        }

        public void Warn(Log log)
        {
            FirstLogger.Warn(log);
            SecondLogger.Warn(log);
        } 
         
    }
}
