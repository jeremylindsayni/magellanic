using Autofac;

namespace Magellanic.Expansion.Ioc.Autofac.Interfaces
{
    public interface IComposable
    {
        ContainerBuilder Builder { get; set; }

        void RegisterType();
    }
}
