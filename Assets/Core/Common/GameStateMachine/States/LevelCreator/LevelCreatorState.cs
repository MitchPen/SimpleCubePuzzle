using Zenject;

namespace Core.Common.GameStateMachine.States.LevelCreator
{
    public class LevelCreatorState: BaseState
    {
        [Inject]
        public LevelCreatorState(GameStateMachine stateMachine) : base(stateMachine)
        {
        }
    }
}