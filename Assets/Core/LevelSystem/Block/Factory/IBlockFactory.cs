using Core.LevelSystem.Block.BlockTypes;

namespace Core.LevelSystem.Block.Factory
{
    public interface IBlockFactory
    {
        public BaseBlock CreateBlock(BlockType type);
    }
}