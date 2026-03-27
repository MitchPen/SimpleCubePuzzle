using Zenject;

namespace Core.Common.Input
{
    public class InputServiceInstaller: Installer<InputServiceInstaller>
    {
        public override void InstallBindings()
        {
           Container
               .BindInterfacesAndSelfTo<InputService>()
               .AsSingle()
               .NonLazy();;
        }
    }
}