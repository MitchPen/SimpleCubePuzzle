using UnityEngine;

namespace Core.LevelSystem.Block
{
    [RequireComponent(typeof(BoxCollider))]
    public class CollisionHandlingBaseBlock : BaseBlock
    {
        [SerializeField] protected BoxCollider _boxCollider;

        protected virtual void OnCollisionEnter(Collision collision) { }

        protected virtual void OnCollisionExit(Collision collision) { }
    }
}