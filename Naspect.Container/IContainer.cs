using System;

namespace Naspect.Container
{
    public interface IContainer
    {
        void Setup(); 
        void Register<TTypeToResolve, TConcrete>(string key, LifeCycle lifeCycle= LifeCycle.Singleton) where TConcrete : TTypeToResolve ;

        void Unregister<TTypeToResolve, TConcrete>(string key);
        TTypeToResolve Resolve<TTypeToResolve>(string key);

        object Resolve(Type typeToResolve);
    }
    public enum LifeCycle
    {
        Singleton,
        Transient
    } 

   
}
