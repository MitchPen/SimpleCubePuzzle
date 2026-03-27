using UnityEngine;

namespace Core.Common.FilesProvider
{
    public class LocalFilesProvider: IFilesProvider
    {
        public const string FILE_EXTENSION = ".json";
        public string DATA_PATH = Application.dataPath;
        
        
        public string ReadDataFromJson(string filepath)
        {
            throw new System.NotImplementedException();
        }

        public string WriteDataToJson(string filepath)
        {
            throw new System.NotImplementedException();
        }
    }
}