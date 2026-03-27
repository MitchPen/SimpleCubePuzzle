using Core.Common.GameStateMachine;
using Core.Common.GameStateMachine.States.Boot;
using Zenject;

namespace Core.Common
{
    public class Bootstraper
    {
        [Inject]   
        public Bootstraper(IStateMachine<BaseState> stateMachine, BootConfig bootConfig)
        {
            UnityEngine.Debug.Log("Bootstraper Created");
            stateMachine.Boot();
            stateMachine.ChangeState<BootState>(new BootStateArgs()
            {
                BootConfig =  bootConfig
            });
        }
    }
}