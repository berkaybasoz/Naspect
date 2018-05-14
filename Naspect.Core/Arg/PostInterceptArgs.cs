namespace Naspect.Core.Arg
{
    public class PostInterceptArgs : InterceptArgs
    {

        public object Value { get; protected set; }

        public PostInterceptArgs(string methodName, object[] arguments)
            : base(methodName, arguments)
        {
        }

        public PostInterceptArgs(InterceptArgs e) : base(e) { }

        public PostInterceptArgs(InterceptArgs e, object val) : this(e)
        {
            Value = val;
        }
    }
}
