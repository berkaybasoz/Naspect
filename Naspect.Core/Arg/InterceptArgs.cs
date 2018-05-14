using System;
using System.Text;

namespace Naspect.Core.Arg
{
    public class InterceptArgs : EventArgs
    {
        public string MethodName { get; protected set; }
        public object[] Arguments { get; protected set; }

        public InterceptArgs(string methodName, object[] arguments)
        {
            MethodName = methodName;
            Arguments = arguments;
        }

        public InterceptArgs(InterceptArgs e)
            : this(e.MethodName, e.Arguments)
        {

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("Method : {0}", MethodName));
            sb.Append(string.Format(" Args : {0}", string.Join(",", Arguments)));
            return sb.ToString();
        }
    }
}
