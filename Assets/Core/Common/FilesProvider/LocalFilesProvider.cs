using UnityEngine;
using System.IO;

namespace Core.Common.FilesProvider
{
    public class LocalFilesProvider : IFilesProvider
    {
        private const string FILE_JSON_EXTENSION = ".json";
        private string DATA_PATH = Application.persistentDataPath;

        public LocalFilesProvider()
        {
            Debug.Log(Application.persistentDataPath);
        }

        public string ReadDataFromJson(string filename, string folder)
        {
            filename += FILE_JSON_EXTENSION;
            var dirPath = Path.Combine(DATA_PATH, folder);
            if (!Directory.Exists(dirPath)) return null;

            var filePath = Path.Combine(dirPath, filename);
            if (File.Exists(filePath))
                return File.ReadAllText(filePath);

            return null;
        }

        public void WriteDataToJson(string filename, string folder, string data)
        {
            filename += FILE_JSON_EXTENSION;
            var dirPath = Path.Combine(DATA_PATH, folder);
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
            var filePath = Path.Combine(dirPath, filename);
            File.WriteAllText(filePath, data);
        }
    }
}