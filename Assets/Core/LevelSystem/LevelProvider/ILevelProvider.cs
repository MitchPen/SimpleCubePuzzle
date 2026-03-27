using System.Collections.Generic;

namespace Core.LevelSystem.LevelProvider
{
    public interface ILevelProvider
    {
        public List<LevelData> ReadLevels();
        public void WriteLevels(List<LevelData> levels);
    }
}