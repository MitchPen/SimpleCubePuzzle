using System.Collections.Generic;
using Core.LevelSystem.Block;
using Core.LevelSystem.Block.BlockTypes;
using UnityEngine;

namespace Core.LevelSystem.Configs
{
    [CreateAssetMenu(fileName = "BlocksContainer", menuName = "Configs/BlocksContainer")]
    public class BlockSetupConfig : ScriptableObject
    {
        [SerializeField] private List<BlocksContainerItem> Blocks = new List<BlocksContainerItem>();

        public BaseBlock GetBlock(BlockType type)
        {
            return Blocks.Find(i => i.Type == type)?.Prefab;
        }
    }
}