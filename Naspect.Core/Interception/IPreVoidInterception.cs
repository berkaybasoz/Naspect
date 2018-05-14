using Naspect.Core.Arg;

namespace Naspect.Core.Interception
{
    public interface IPreVoidInterception : IInterception
    {
        void OnPre(PreInterceptArgs e);
    }
}
