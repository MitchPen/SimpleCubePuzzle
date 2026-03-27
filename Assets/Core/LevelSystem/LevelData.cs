using System;
using System.Collections.Generic;
using System.Numerics;
using Core.LevelSystem.Block;

namespace Core.LevelSystem
{
    [Serializable]
    public struct LevelData
    {
        public string Name;
        public Vector3 PlayerStartPosition;
        public List<BlockData> BlockAlignment;
        public List<BlockRelationData> BlockRelations;
    }
}