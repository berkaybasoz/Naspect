using System.Text;

namespace Naspect.Core.Arg
{
    public class ExceptionInterceptArgs : InterceptArgs
    {

        public System.Exception Ex { get; set; }

        public ExceptionInterceptArgs(string methodName, object[] arguments)
            : base(methodName, arguments)
        {
        }

        public ExceptionInterceptArgs(InterceptArgs e) : base(e) { }

        public ExceptionInterceptArgs(InterceptArgs e, System.Exception ex)
            : this(e)
        {
            Ex = ex;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append(string.Format(" Ex : {0}", Ex.ToString()));
            return sb.ToString();
        }
    }
}
