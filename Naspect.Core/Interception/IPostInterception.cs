using Naspect.Core.Arg;

namespace Naspect.Core.Interception
{
    public interface IPostInterception : IInterception
    {
        object OnPost(PostInterceptArgs e);
    }
}
