namespace Naspect.Container
{
    public class BasicContainerFactory : IContainerFactory
    {
        public IContainer Create()
        {
            return new BasicContainer();
        }
    }
}
