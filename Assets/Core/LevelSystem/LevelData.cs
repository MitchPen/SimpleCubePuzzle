using System.Collections.Generic;
using System.Numerics;

namespace Core.LevelSystem
{
    public struct LevelData
    {
        public string Name;
        public Vector3 PlayerStartPosition;
        public List<BlockData> BlockAlignment;
        public List<BlockRelationData>  BlockRelations;
    }
}
