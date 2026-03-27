using System.Collections.Generic;
using Core.LevelSystem.Block;
using UnityEngine;

namespace Core.LevelSystem
{
    public class Level : MonoBehaviour
    {
        private IInteractable _finish;
        private List<BaseBlock>  _blocks;
        private Dictionary<IInteractable, List<IInteractable>> _blockRelation;

        public void ConstructLevel(LevelData data)
        {
            
        }

        public void DestructLevel()
        {
            
        }
    }
}
