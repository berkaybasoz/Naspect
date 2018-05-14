using Naspect.Core.Interception;
using System;

namespace Naspect.Core.Attribute
{
    [AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = true)]
    public abstract class InterceptAttribute : System.Attribute, IInterception
    {

    }
}
