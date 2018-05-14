using Naspect.Core.Arg;
using Naspect.Core.Attribute;
using Naspect.Core.Extension;
using Naspect.Core.Interception;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Naspect.Attribute.Activity
{
    public class Type1 : Type
    {
        public override Guid GUID => throw new NotImplementedException();

        public override Module Module => throw new NotImplementedException();

        public override Assembly Assembly => throw new NotImplementedException();

        public override string FullName => throw new NotImplementedException();

        public override string Namespace => throw new NotImplementedException();

        public override string AssemblyQualifiedName => throw new NotImplementedException();

        public override Type BaseType => throw new NotImplementedException();

        public override Type UnderlyingSystemType => throw new NotImplementedException();

        public override string Name => throw new NotImplementedException();

        public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override object[] GetCustomAttributes(bool inherit)
        {
            throw new NotImplementedException();
        }

        public override object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        public override Type GetElementType()
        {
            throw new NotImplementedException();
        }

        public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override EventInfo[] GetEvents(BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override FieldInfo GetField(string name, BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override FieldInfo[] GetFields(BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override Type GetInterface(string name, bool ignoreCase)
        {
            throw new NotImplementedException();
        }

        public override Type[] GetInterfaces()
        {
            throw new NotImplementedException();
        }

        public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override Type GetNestedType(string name, BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override Type[] GetNestedTypes(BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
        {
            throw new NotImplementedException();
        }

        public override bool IsDefined(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        protected override TypeAttributes GetAttributeFlagsImpl()
        {
            throw new NotImplementedException();
        }

        protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
        {
            throw new NotImplementedException();
        }

        protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
        {
            throw new NotImplementedException();
        }

        protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
        {
            throw new NotImplementedException();
        }

        protected override bool HasElementTypeImpl()
        {
            throw new NotImplementedException();
        }

        protected override bool IsArrayImpl()
        {
            throw new NotImplementedException();
        }

        protected override bool IsByRefImpl()
        {
            throw new NotImplementedException();
        }

        protected override bool IsCOMObjectImpl()
        {
            throw new NotImplementedException();
        }

        protected override bool IsPointerImpl()
        {
            throw new NotImplementedException();
        }

        protected override bool IsPrimitiveImpl()
        {
            throw new NotImplementedException();
        }

        public Action OnBefore;
    }
    public class PreAction<T>
    {
        private Func<T> function;
        public PreAction(Func<T> function)
        {
            this.function = function;
        }
    }

    public class Run : InterceptAttribute//, IPreVoidInterception, IPostVoidInterception, IExceptionInterception
    {
        
        public System.Object OnBefore;

        public Run()
        {
         
        }

         
        #region Old
        //public delegate void BeforeEventHandler();
        //public event BeforeEventHandler OnBefore;

        //private BeforeEventHandler onBefore;
        //private Action onAfter;
        //private Action onException;

        //public Type1 type1;

        //public Run(Type1 type1) 
        //{

        //}
        //public Run(object[] setter)
        //{

        //}
        //public Run(Expression<Func<object>> expression)
        //{
        //}

        //private Type onBeforeT;
        /// <summary>
        ///  [Run(typeof(Run.BeforeEventHandler), "CallbackMethodName")]
        /// </summary>
        /// <param name="e"></param>
        //public Run(Type onBeforeT,string name)
        //{
        //    this.onBeforeT = onBeforeT;
        //}

        //public Action OnAfter { get => onAfter; set => onAfter = value; }

        //public Run(BeforeEventHandler onBefore = null, Action onAfter = null, Action onException = null)
        //{
        //    this.onBefore = onBefore;
        //    this.onAfter = onAfter;
        //    this.onException = onException;
        //}

        //public void OnPre(PreInterceptArgs e)
        //{
        //    //onBefore?.Invoke();
        //}

        //public void OnPost(PostInterceptArgs e)
        //{
        //    //OnAfter?.Invoke();
        //}

        //public void OnException(ExceptionInterceptArgs e)
        //{
        //    //onException?.Invoke();
        //} 
        #endregion
    }

    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public class PlaybackAttribute : System.Attribute
    {
        // See the attribute guidelines at 
        //  http://go.microsoft.com/fwlink/?LinkId=85236
        /// <summary>
        /// Test Flask Aspect 
        /// </summary>
        /// <param name="requestIdentiferType">A  type that implements IRequestIdentifer</param>
        /// <param name="responseIdentifierType">A type that implements IResponseIdentifier</param>
        public PlaybackAttribute(Type requestIdentiferType = null, Type responseIdentifierType = null)
        {
            //if (requestIdentiferType != null)
            //{
            //    if (!typeof(IRequestIdentifier).IsAssignableFrom(requestIdentiferType))
            //    {
            //        throw new ArgumentException("Request identifier type must implement IRequestIdentifer<T>");
            //    }
            //}

            //if (responseIdentifierType != null)
            //{
            //    if (!typeof(IResponseIdentifier<>).IsAssignableFrom(responseIdentifierType))
            //    {
            //        throw new ArgumentException("Response identifier type must implement IResponseIdentifier<T>");
            //    }
            //}
        }
    }
}
