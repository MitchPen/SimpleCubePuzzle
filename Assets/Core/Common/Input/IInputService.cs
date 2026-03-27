using System;
using UnityEngine;

namespace Core.Common.Input
{
    public interface IInputService
    {
        public event Action<InputActionType> ButtonPressed;
        public event Action<InputActionType> ButtonReleased;
        public event Action<InputActionType> Scroll;
        public Vector2 GetPointerPosition();
    }
}