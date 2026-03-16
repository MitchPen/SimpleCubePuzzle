using System;
using System.Collections.Generic;
using UnityEngine;

namespace Core.LevelSystem
{
    [CreateAssetMenu(fileName = "BlocksContainer", menuName = "Configs/BlocksContainer")]
    public class BlocksContainer : ScriptableObject
    {
        [SerializeField] private List<BlocksContainerItem> Blocks = new List<BlocksContainerItem>();

        public Block GetBlock(BlockType  type)
        {
            return Blocks.Find(i=>i.Type == type)?.Prefab;
        }
    }

    [Serializable]
    public class BlocksContainerItem
    {
        public BlockType Type;
        public Block Prefab;
    }
}
