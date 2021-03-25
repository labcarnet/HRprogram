using System.IO;
using System.Xml.Serialization;

namespace HRprogram
{
    public class FileHelper<T> where T : new()
    {
        private string _filePath;

        public FileHelper(string filePath)
        {
            _filePath = filePath;
        }
        public void SerializeToFile(T workers)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var streamWriter = new StreamWriter(_filePath))
            {
                serializer.Serialize(streamWriter, workers);
                streamWriter.Close();
            }
        }

        public T DeserializerFormFile()
        {
            if (!File.Exists(_filePath)) return new T();

            var serializer = new XmlSerializer(typeof(T));

            using (var streamReader = new StreamReader(_filePath))
            {
                var workers = (T)serializer.Deserialize(streamReader);
                streamReader.Close();
                return workers;
            }
        }
    }
}
