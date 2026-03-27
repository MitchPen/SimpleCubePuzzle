using Zenject;

namespace Core.Common.GameStateMachine.States.Boot
{
    public class BootState: BaseState
    {
        private BootStateArgs _args;
        
        [Inject]
        public BootState(GameStateMachine stateMachine) : base(stateMachine) { }

        public override void Entry(BaseStateArgs state = null)
        {
            base.Entry(state);
            
            _args = state as BootStateArgs;
            if (_args != null)
                SetBootOptions();
            _stateMachine.ChangeState<MainMenuState>(null);
        }

        private void SetBootOptions()
        {
            //add settings applier 
            UnityEngine.Debug.Log("Set Boot options:");
            UnityEngine.Debug.Log($"###|Target FrameRate = {_args.BootConfig.TargetFrameRate}");
            UnityEngine.Debug.Log($"###|Target FullScreenMode = {_args.BootConfig.FullScreenMode}");
            UnityEngine.Debug.Log($"###|Target ScreenOrientation = {_args.BootConfig.ScreenOrientation}");
            UnityEngine.Debug.Log($"###|Target Resolution = {_args.BootConfig.Width} x {_args.BootConfig.Height}");
        }
    }
}