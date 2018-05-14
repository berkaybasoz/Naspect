using System;
using System.Collections.Generic;
using System.Linq;

namespace Naspect.Container
{
    public  class BasicContainer : IContainer
    {
        #region Constructor
        private static object objLock = new object();
        private static BasicContainer container;
        public static BasicContainer Instance
        {
            get
            {
                lock (objLock)
                {
                    if (container == null)
                    {

                        if (container == null)
                            container = new BasicContainer();
                    }
                }

                return container;
            }
        }

        #endregion
        private readonly IList<RegisteredObject> registeredObjects = new List<RegisteredObject>();
        public IList<RegisteredObject> RegisteredObjects
        {
            get
            {
                return Instance.registeredObjects;
            }
        }

        public void Setup()
        {

        }

        public void Register<TTypeToResolve, TConcrete>(string key, LifeCycle lifeCycle = LifeCycle.Singleton) where    TConcrete:TTypeToResolve
        {
            RegisteredObjects.Add(new RegisteredObject(typeof(TTypeToResolve), typeof(TConcrete), lifeCycle));
        }

        public void Unregister<TTypeToResolve, TConcrete>(string key)
        {
            RegisteredObjects.Remove(new RegisteredObject(typeof(TTypeToResolve), typeof(TConcrete)));
        }

        public TTypeToResolve Resolve<TTypeToResolve>(string key)
        {
            return (TTypeToResolve)ResolveObject(typeof(TTypeToResolve));
        }
        public object Resolve(Type typeToResolve)
        {
            return ResolveObject(typeToResolve);
        }

        private object ResolveObject(Type typeToResolve)
        {
            var registeredObject = RegisteredObjects.FirstOrDefault(o => o.TypeToResolve == typeToResolve);
            if (registeredObject == null)
            {
                throw new TypeNotRegisteredException(string.Format(
                    "The type {0} has not been registered", typeToResolve.Name));
            }
            return GetInstance(registeredObject);
        }

        private object GetInstance(RegisteredObject registeredObject)
        {
            if (registeredObject.Instance == null ||
                registeredObject.LifeCycle == LifeCycle.Transient)
            {
                IEnumerable<object> parameters = ResolveConstructorParameters(registeredObject);
                object[] paramArray = parameters.ToArray();
                registeredObject.CreateInstance(paramArray);
            }
            return registeredObject.Instance;
        }

        private IEnumerable<object> ResolveConstructorParameters(RegisteredObject registeredObject)
        {
            var constructorInfo = registeredObject.ConcreteType.GetConstructors().First();
            foreach (var parameter in constructorInfo.GetParameters())
            {
                yield return ResolveObject(parameter.ParameterType);
            }
        }
         
    }

    public class TypeNotRegisteredException : Exception
    {
        public TypeNotRegisteredException(string message)
            : base(message)
        {
        }
    }
     
    public class RegisteredObject
    {
        public RegisteredObject(Type typeToResolve, Type concreteType, LifeCycle lifeCycle=LifeCycle.Singleton)
        {
            TypeToResolve = typeToResolve;
            ConcreteType = concreteType;
            LifeCycle = lifeCycle;
        }

        public Type TypeToResolve { get; private set; }

        public Type ConcreteType { get; private set; }

        public object Instance { get; private set; }

        public LifeCycle LifeCycle { get; private set; }

        public void CreateInstance(params object[] args)
        {
            this.Instance = Activator.CreateInstance(this.ConcreteType, args);
        }
    }
}
