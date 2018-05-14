using Naspect.Core.Arg;
using Naspect.Core.Attribute;
using Naspect.Core.Interception;
using System.Threading;

namespace Naspect.Attribute.Thread
{
    public class ThreadLockAttribute : InterceptAttribute, IPreVoidInterception, IPostVoidInterception
    {
        private Mutex mutex = new Mutex();

        public void OnPre(PreInterceptArgs e)
        {
            mutex.WaitOne();//Thread lock
        }

        public void OnPost(PostInterceptArgs e)
        {
            mutex.ReleaseMutex();//Thread release
        }
    }
}
