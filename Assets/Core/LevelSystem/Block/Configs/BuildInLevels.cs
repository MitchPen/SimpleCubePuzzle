using System.Collections.Generic;
using UnityEngine;

namespace Core.LevelSystem.Configs
{
    [CreateAssetMenu(fileName = "BuildInLevels", menuName = "Configs/BuildInLevels")]
    public class BuildInLevels : ScriptableObject
    {
        public List<LevelData> DefaultLevels = new List<LevelData>();
    }
}