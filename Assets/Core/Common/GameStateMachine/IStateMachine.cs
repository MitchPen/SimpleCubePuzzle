using System;

namespace Core.Common.GameStateMachine
{
    public interface IStateMachine<T> where T : BaseState
    {
        public void Boot();
        public void ChangeState<T>(BaseStateArgs args);
    }
}