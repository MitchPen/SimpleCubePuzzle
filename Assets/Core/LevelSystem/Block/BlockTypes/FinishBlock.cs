using System;
using UnityEngine;

namespace Core.LevelSystem.Block.BlockTypes
{
    public class FinishBlock : CollisionHandlingBaseBlock, IInteractable
    {
        public event Action<IInteractable> OnInteract;

        protected override void OnCollisionEnter(Collision collision)
        {
            base.OnCollisionEnter(collision);
            if(!collision.gameObject.TryGetComponent(out BaseBlock block)) return;
            if(block.BlockType == BlockType.Player)
                Interact();
        }

        public void Interact() => OnInteract?.Invoke(this);
    }
}