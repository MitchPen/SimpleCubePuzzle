using System;

namespace Core.LevelSystem.Block
{
    public interface IInteractable
    {
        public event Action <IInteractable> OnInteract;
        
        public void Interact();
    }
}