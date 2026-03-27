using Zenject;

namespace Core.Common.GameStateMachine
{
    public class GameStateMachineInstaller: Installer<GameStateMachineInstaller>
    {
        public override void InstallBindings()
        {
            Container
                .BindInterfacesAndSelfTo<GameStateMachine>()
                .AsSingle()
                .NonLazy();
        }
    }
}