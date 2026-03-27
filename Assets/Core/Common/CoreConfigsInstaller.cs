using Core.Common.GameStateMachine.States.Boot;
using Core.Common.Input;
using Core.LevelSystem.LevelProvider;
using UnityEngine;
using Zenject;

namespace Core.Common
{
    public class CoreConfigsInstaller: MonoInstaller<CoreConfigsInstaller>
    {
        [SerializeField] private BootConfig _bootConfig;
        [SerializeField] private InputMapConfig _inputConfig;
        [SerializeField] private LevelProviderPathData _pathDataConfig;
        
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
            Container
                .Bind<LevelProviderPathData>()
                .FromInstance(_pathDataConfig)
                .AsSingle();
        }
    }
}