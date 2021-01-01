using SeewoHelper.Utilities;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace SeewoHelper
{
    public class Logger : ObservableCollection<Log>, IDisposable
    {
        private readonly string _path;

        private void Save() => File.WriteAllText(_path, ToString());

        private bool TrySave()
        {
            try
            {
                Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Dispose() => Save();

        public override string ToString() => string.Join(Environment.NewLine, this);

        public Logger(string path)
        {
            _path = path ?? throw new ArgumentNullException(nameof(path));

            if (IOUtilities.IsProperPath(_path) && !Directory.Exists(_path))
            {
                IOUtilities.CreateFile(_path);
                CollectionChanged += (sender, e) => TrySave();
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
