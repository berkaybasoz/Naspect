using Naspect.Core.Arg;

namespace Naspect.Core.Interception
{
    public interface IExceptionInterception : IInterception
    {
        void OnException(ExceptionInterceptArgs e);
    }
}
