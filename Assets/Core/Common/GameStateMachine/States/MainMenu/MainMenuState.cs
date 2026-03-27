using UnityEngine.SceneManagement;
using Zenject;

namespace Core.Common.GameStateMachine.States
{
    public class MainMenuState: BaseState
    {
        [Inject]
        public MainMenuState(GameStateMachine stateMachine) : base(stateMachine) { }

        public override void Entry(BaseStateArgs state = null)
        {
            base.Entry(state);
            SceneManager.LoadScene(1, LoadSceneMode.Single);
        }
    }
}