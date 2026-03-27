using System;
using System.Collections.Generic;
using Core.Common.FilesProvider;
using Newtonsoft.Json;
using Zenject;

namespace Core.LevelSystem.LevelProvider
{
    public class LevelProvider: ILevelProvider
    {
        private IFilesProvider _filesProvider;
        private LevelProviderPathData _pathConfig;

        [Inject]
        public LevelProvider(IFilesProvider filesProvider, LevelProviderPathData pathData)
        {
            _filesProvider =  filesProvider;
            _pathConfig = pathData;
        }
        
        public List<LevelData> ReadLevels()
        {
            string jsonData = _filesProvider.ReadDataFromJson(_pathConfig.FileName, _pathConfig.FolderName);
            try
            {
                List<LevelData> levels =  JsonConvert.DeserializeObject<List<LevelData>>(jsonData);
                if(levels != null)
                    return levels;
                return new List<LevelData>();
            }
            catch (Exception e)
            {
                UnityEngine.Debug.LogError("Could not read levels from " + _pathConfig.FileName + ": " + e.Message);
                return new List<LevelData>();
            }
        }

        public void WriteLevels(List<LevelData> levels)
        {
            try
            {
                var jsonData = JsonConvert.SerializeObject(levels);
                _filesProvider.WriteDataToJson(_pathConfig.FileName, _pathConfig.FolderName, jsonData);
            }
            catch (Exception e)
            {
                UnityEngine.Debug.LogError("Could not write levels to " + _pathConfig.FileName + ": " + e.Message);
            }
        }
    }
}