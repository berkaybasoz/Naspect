using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Microsoft.Practices.Unity.Configuration;
using Unity.Lifetime;

namespace Naspect.Container.Unity
{
    public class UnityContainer : IContainer
    {
        private readonly global::Unity.UnityContainer container;

        public UnityContainer()
        {
            container = new global::Unity.UnityContainer();
        }

        public void Setup()
        {
            container.LoadConfiguration();
        }
         
        public void Register<TTypeToResolve, TConcrete>(string key, LifeCycle lifeCycle = LifeCycle.Singleton)
            where TConcrete  : TTypeToResolve
        {
            LifetimeManager lifetimeManager = CreateLifeTime(lifeCycle);

            container.RegisterType<TTypeToResolve, TConcrete>(key, lifetimeManager);
        }
         
        public T Resolve<T>(string key)
        {
            return container.Resolve<T>(key, null);
        } 
        public void Unregister<T, K>(string key)
        {
            throw new NotImplementedException();
        }

        public object Resolve(Type typeToResolve)
        {
            throw new NotImplementedException();
        }

        private static LifetimeManager CreateLifeTime(LifeCycle lifeCycle)
        {
            LifetimeManager lifetimeManager = null;
            switch (lifeCycle)
            {
                case LifeCycle.Singleton:
                default:
                    lifetimeManager = new SingletonLifetimeManager();
                    break;
                case LifeCycle.Transient:
                    lifetimeManager = new TransientLifetimeManager();
                    break; 
              
            }

            return lifetimeManager;
        }
    }
}
