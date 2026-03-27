using Core.Common.FilesProvider;
using Core.Common.GameStateMachine;
using UnityEngine;
using Zenject;

namespace Core.Common
{
    public class BootInstaller: MonoInstaller<BootInstaller>
    {
        [SerializeField] private GameObject _bootConfig;
        
        public override void InstallBindings()
        {
            GameStateMachineInstaller.Install(Container);
            FileProviderInstaller.Install(Container);
           
            Container
                .Bind<Bootstraper>()
                .AsSingle()
                .NonLazy();
        }
    }
}