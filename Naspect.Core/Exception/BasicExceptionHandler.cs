using Naspect.Core.Arg;
using Naspect.Core.Container;
using Naspect.Logger;

namespace Naspect.Core.Exception
{
    public class BasicExceptionHandler : IExceptionHandler
    {
        private readonly ILogger logger;

        public BasicExceptionHandler()
        {
            logger = ContainerContext.Resolve<ILogger>();
        }

        public void Handle(System.Exception ex)
        {
            logger.Error(new ExceptionLog(ex));
        }

        public void Handle(ExceptionInterceptArgs arg)
        {
            logger.Error(new ExceptionLog(arg.Ex));
        }

    }
}
