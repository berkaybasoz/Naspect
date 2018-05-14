using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naspect.Container.Unity
{
    public class UnityContainerFactory : IContainerFactory
    {
        public   IContainer Create()
        {
            return new Naspect.Container.Unity.UnityContainer();
        }
    }
}
