using System.IO;
using System.Net.Http;

namespace TesteWebMotors.HTTP.Content
{
    class FileContent : MultipartFormDataContent
    {
        public FileContent(string filePath, string apiParamName)
        {
            var filestream = File.Open(filePath, FileMode.Open);
            var filename = Path.GetFileName(filePath);

            this.Add(new StreamContent(filestream), apiParamName, filename);
        }
    }
}
