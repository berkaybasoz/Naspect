using Naspect.Core.Arg;

namespace Naspect.Core.Interception
{
    public interface IPostVoidInterception : IInterception
    {
        void OnPost(PostInterceptArgs e);
    }
}
