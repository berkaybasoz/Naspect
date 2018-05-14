using System.Reflection;
using System.Runtime.CompilerServices;

namespace Naspect.Core.Extension
{
    public static class CallerNameHelper
    {
        public static string GetCurrentMethodName(string message, [CallerMemberName] string memberName = "")
        {
            return string.Format("{0}->{1}", memberName, message);
        } 

        public static string GetCurrentMethodName([CallerMemberName] string memberName = "")
        {
            return MethodInfo.GetCurrentMethod().Name; 
        } 
    } 
}
