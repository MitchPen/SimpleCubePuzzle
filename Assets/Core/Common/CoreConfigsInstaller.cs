using Core.Common.GameStateMachine.States.Boot;
using Core.Common.Input;
using UnityEngine;
using Zenject;

namespace Core.Common
{
    public class CoreConfigsInstaller: MonoInstaller<CoreConfigsInstaller>
    {
        [SerializeField] private BootConfig _bootConfig;
        [SerializeField] private InputMapConfig _inputConfig;
        
        public override void InstallBindings()
        {
            Container
                .Bind<BootConfig>()
                .FromInstance(_bootConfig)
                .AsSingle();
            Container
                .Bind<InputMapConfig>()
                .FromInstance(_inputConfig)
                .AsSingle();
        }
    }
}