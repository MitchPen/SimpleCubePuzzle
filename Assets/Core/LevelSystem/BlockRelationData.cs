using System;
using System.Collections.Generic;
using System.Numerics;

namespace Core.LevelSystem
{
    [Serializable]
    public struct BlockRelationData
    {
        public Vector3 TargetBlockId;
        public List<Vector3> RelativeBlocks;
    }
}