using System;
using System.IO;

namespace Calculator
{
    /// <summary>
    /// Фактическое использование принципа Single responsibility
    /// через реализацию получения данных только из файлов.
    /// </summary>
    public class FileDataSource : DataSource
    {
        private readonly string _fileName;

        public FileDataSource(string fileName)
        {
            if (!File.Exists(fileName))
            {
                throw new Exception("No such file.");
            }

            _fileName = fileName;
            _status = Status.Idle;
        }

        public override string GetData()
        {
            ReadFromFile();
            return _data;
        }

        private async void ReadFromFile()
        {
            _status = Status.Processing;
            _data = await File.ReadAllTextAsync(_fileName);
            _status = Status.Ready;
        }
    }
}