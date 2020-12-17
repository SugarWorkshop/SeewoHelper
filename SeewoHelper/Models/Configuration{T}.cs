using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SeewoHelper.Utilities;
using System;
using System.IO;

namespace SeewoHelper
{
    public partial class Configuration<T> : IDisposable
    {
        private readonly string _name;

        private readonly string _directoryPath = null;

        private static readonly string _suffix = ".json";

        private string FileName => _name + _suffix;

        private string Path => IOUtilities.PathAppend(_directoryPath, FileName);

        public T Content { get; set; }

        private void Read()
        {
            string data = File.ReadAllText(Path);

            if (!string.IsNullOrWhiteSpace(data))
            {
                Content = JToken.Parse(data).ToObject<T>();
            }
        }

        private void Save() => File.WriteAllText(Path, JsonConvert.SerializeObject(Content));

        public void Dispose() => Save();

        public Configuration(string name, string directoryPath)
        {
            if (directoryPath == null)
            {
                throw new ArgumentNullException(nameof(directoryPath));
            }

            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (IOUtilities.IsProperPath(directoryPath) && IOUtilities.GetPathType(directoryPath, true) == PathType.Directionary)
            {
                _name = name;
                _directoryPath = directoryPath;

                IOUtilities.CreateFile(Path, false);
                Read();
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
