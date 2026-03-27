using UnityEngine;

namespace Core.LevelSystem.LevelProvider
{
    [CreateAssetMenu(fileName = "LevelProviderPathData", menuName = "Configs/LevelProviderPathData")]
    public class LevelProviderPathData : ScriptableObject
    {
        public string FolderName;
        public string FileName;
    }
}
