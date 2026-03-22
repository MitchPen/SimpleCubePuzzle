using UnityEngine;

namespace Core.LevelSystem
{
    public class BlockFactory
    {
        private BlocksContainer _container;
        
        public Block CreateBlock(BlockType type)
        {
            var blockPrefab = _container.GetBlock(type);
            if(blockPrefab == null) return null;
            
            var block = Object.Instantiate(blockPrefab);
            return block;
        }
    }
}
