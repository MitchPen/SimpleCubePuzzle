using System.Collections.Generic;
using UnityEngine;

namespace Core.Common.Input
{
    [CreateAssetMenu(fileName = "InputMapConfig", menuName = "Configs/InputMapConfig")]
    public class InputMapConfig : ScriptableObject
    {
        [SerializeField] private List<InputItem> Buttons = new List<InputItem>();
        [SerializeField] private List<InputItem> Scroll = new List<InputItem>();
        
        public List<InputItem>  GetButtonsSetup() => Buttons;
        public List<InputItem>  GetScrollSetup() => Scroll;
    }
}
