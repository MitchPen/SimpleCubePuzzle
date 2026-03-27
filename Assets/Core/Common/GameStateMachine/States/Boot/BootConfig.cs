using UnityEngine;

namespace Core.Common.GameStateMachine.States.Boot
{
    [CreateAssetMenu(fileName = "BootConfig", menuName = "Configs/BootConfig")]
    public class BootConfig : ScriptableObject
    {
        public int TargetFrameRate;
        public FullScreenMode FullScreenMode;
        public ScreenOrientation ScreenOrientation;
        public int Width;
        public int Height;
    }
}
