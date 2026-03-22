using System;

namespace Core.LevelSystem
{
    public interface IInteractable
    {
        public event Action <IInteractable> OnInteract;
        
        public void Interact();
    }
}