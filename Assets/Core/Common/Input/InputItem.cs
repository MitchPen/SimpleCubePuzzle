using System;
using UnityEngine;

namespace Core.Common.Input
{
    [Serializable]
    public struct InputItem
    {
        public InputActionType Type;
        public KeyCode Key;
    }
}