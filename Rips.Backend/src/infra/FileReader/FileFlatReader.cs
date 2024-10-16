using Rips.Backend.src.core.interfaces;
using System.IO;

namespace Rips.Backend.src.infra.FileReader
{
    public class FileFlatReader : IFileFlatReader
    {
        public List<string[]> ReadFile(string filePath)
        {
            EnsureFileExist(filePath);

            var values = new List<string[]>();
            using (var reader = new StreamReader(filePath))
            {
                string line;

                while ((line = reader.ReadLine()!) != null)
                {
                    values.Add(line.Split(","));
                }

            }
            return values;

        }
        private bool EnsureFileExist(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"El archivo ubicado en la ruta ({filePath}) no existe.");

            return true;
        }
    }
}
