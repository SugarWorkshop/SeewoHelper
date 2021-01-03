using SeewoHelper.Utilities;
using System;
using System.IO;
using System.Text.Json;

namespace SeewoHelper
{
    public class Configuration<T> : IDisposable
    {
        private readonly string _name;

        private readonly string _directoryPath = null;

        private static readonly string _suffix = ".json";

        private string FileName => _name + _suffix;

        private string Path => System.IO.Path.Combine(_directoryPath, FileName);

        public T Content { get; set; }

        private void Read()
        {
            string data = File.ReadAllText(Path);

            if (!string.IsNullOrWhiteSpace(data))
            {
                Content = JsonSerializer.Deserialize<T>(data);
            }
        }

        private void Save() => File.WriteAllText(Path, JsonSerializer.Serialize(Content));

        public void Dispose()
        {
            Save();
            GC.SuppressFinalize(this);
        }

        public Configuration(string name, string directoryPath, T defaultValue)
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

                Content ??= defaultValue;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
