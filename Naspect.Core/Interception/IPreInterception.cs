using Naspect.Core.Arg;

namespace Naspect.Core.Interception
{
    public interface IPreInterception : IInterception
    {
        object OnPre(PreInterceptArgs e);
    }
}
