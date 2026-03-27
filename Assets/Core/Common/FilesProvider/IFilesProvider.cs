namespace Core.Common.FilesProvider
{
    public interface IFilesProvider
    {
        public string ReadDataFromJson(string filepath);
        public string WriteDataToJson(string filepath);
    }
}