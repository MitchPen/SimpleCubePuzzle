using System;
using Core.LevelSystem.Block.BlockTypes;

namespace Core.LevelSystem.Configs
{
    [Serializable]
    public class BlocksContainerItem
    {
        public BlockType Type;
        public Block.BaseBlock Prefab;
    }
}