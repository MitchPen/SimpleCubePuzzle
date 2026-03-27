using Zenject;

namespace Core.Common.GameStateMachine.States.LevelState
{
    public class LevelState: BaseState
    {
        [Inject]
        public LevelState(GameStateMachine stateMachine) : base(stateMachine)
        {
        }
    }
}