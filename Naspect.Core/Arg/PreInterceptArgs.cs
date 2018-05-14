namespace Naspect.Core.Arg
{
    public class PreInterceptArgs : InterceptArgs
    {
        public bool OverrideReturnValue { get; set; }

        public PreInterceptArgs(string methodName, object[] arguments)
            : base(methodName, arguments)
        {
        }

        public PreInterceptArgs(InterceptArgs e) : base(e) { }

    }
}
