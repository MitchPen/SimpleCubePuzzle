using Core.LevelSystem.Block.BlockTypes;
using Core.LevelSystem.Configs;
using UnityEngine;

namespace Core.LevelSystem.Block.Factory
{
    public class BlockFactory: IBlockFactory
    {
        private BlockSetupConfig _container;
        
        public BaseBlock CreateBlock(BlockType type)
        {
            var blockPrefab = _container.GetBlock(type);
            if(blockPrefab == null) return null;
            
            var block = Object.Instantiate(blockPrefab);
            return block;
        }
    }
}
