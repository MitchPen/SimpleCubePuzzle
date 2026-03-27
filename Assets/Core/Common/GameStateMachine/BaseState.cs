using Zenject;

namespace Core.Common.GameStateMachine
{
    public abstract class BaseState
    {
        protected GameStateMachine _stateMachine;
        
        [Inject]
        public BaseState(GameStateMachine stateMachine)
        {
            _stateMachine =  stateMachine;
        }

        public virtual void Entry(BaseStateArgs state = null)
        {
            UnityEngine.Debug.Log($"Entry {GetType().Name}");
        }

        public virtual void Exit(BaseStateArgs state = null)
        {
            UnityEngine.Debug.Log($"Exit {GetType().Name}");
        }
    }
}