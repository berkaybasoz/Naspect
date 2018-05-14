using Naspect.Core.Arg;

namespace Naspect.Core.Exception
{
    public interface IExceptionHandler
    {
        void Handle(System.Exception ex);
        void Handle(ExceptionInterceptArgs arg);
    }
}
