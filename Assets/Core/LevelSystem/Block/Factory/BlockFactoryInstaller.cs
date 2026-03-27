using Core.LevelSystem.Configs;
using UnityEngine;
using Zenject;

namespace Core.LevelSystem.Block.Factory
{
    public class BlockFactoryInstaller: MonoInstaller<BlockFactoryInstaller>
    {
        [SerializeField] private BlockSetupConfig _config;
        public override void InstallBindings()
        {
            Container
                .Bind<BlockSetupConfig>()
                .FromInstance(_config)
                .AsSingle();
            Container
                .BindInterfacesAndSelfTo<BlockFactory>()
                .AsSingle()
                .NonLazy();
        }
    }
}