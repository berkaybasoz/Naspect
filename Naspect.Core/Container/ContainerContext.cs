using Naspect.Container;
using System;

namespace Naspect.Core.Container
{
    public class ContainerContext
    {
        #region Fields
        private static IContainerFactory containerFactory = new BasicContainerFactory();
        #endregion

        #region Singleton
        private static object objLock = new object();
        private static Naspect.Container.IContainer instance;
        #endregion

        #region Constructors

        #endregion

        #region Properties
        public static Naspect.Container.IContainer Instance
        {
            get
            {
                CheckOrCreateInstance();

                return instance;
            }
            set { instance = value; }
        }

        private static void CheckOrCreateInstance(bool enforce = false)
        {
            lock (objLock)
            {
                if (instance == null || enforce)
                {
                    instance = ContainerFactory.Create();
                }
            }
        }

        public static IContainerFactory ContainerFactory
        {
            get => containerFactory;
            set
            {
                if (containerFactory == null)
                    throw new ArgumentNullException($"{nameof(ContainerFactory)} can not be null.");

                containerFactory = value;

                CheckOrCreateInstance(true);
            }
        }
        #endregion

        #region Public Methods


        public static TSource Resolve<TSource>(string key=null)
        {
            return Instance.Resolve<TSource>(key);
        }

        #endregion

    }
}
