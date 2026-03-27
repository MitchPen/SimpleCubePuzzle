using Core.LevelSystem.Block.BlockTypes;
using UnityEngine;

namespace Core.LevelSystem.Block
{
    public class BaseBlock : MonoBehaviour
    {
        [SerializeField] protected BlockType _blockType;
        
        public BlockType BlockType => _blockType;
    }
}
