namespace Core.Common.FilesProvider
{
    public interface IFilesProvider
    {
        public string ReadDataFromJson(string filename, string folder);
        public void WriteDataToJson(string filename, string folder, string data);
    }
}