using System;
using System.Numerics;
using Core.LevelSystem.Block.BlockTypes;

namespace Core.LevelSystem.Block
{
    [Serializable]
    public struct BlockData
    {
        public Vector3 Id;
        public BlockType BlockType;
    }
}