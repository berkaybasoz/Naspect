using Naspect.Core.Arg;
using Naspect.Core.Attribute;
using Naspect.Core.Container;
using Naspect.Core.Exception;
using Naspect.Core.Interception;

namespace Naspect.Attribute.Exception
{
    public class ExceptionAttribute : InterceptAttribute, IExceptionInterception
    {
        private readonly IExceptionHandler handler;
        private bool reThrow = true;

        public ExceptionAttribute(bool reThrowException = true)
        {
            reThrow = reThrowException;
            handler = ContainerContext.Resolve<IExceptionHandler>();
        }

        public bool ReThrow { get => reThrow; private set => reThrow = value; }

        public void OnException(ExceptionInterceptArgs e)
        {
            handler.Handle(e.Ex);
             
            //e.Ex = new ApplicationException("Unable to process your request");
        }
    }
}
