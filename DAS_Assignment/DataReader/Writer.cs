using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReader
{
    public class Writer
    {
        public void WriteDataInFile(int[] data, string path = Settings.Values.mockDataFilePath)
        {
            WriteDataInFile(data.ToList(), path);
        }
        public void WriteDataInFile(List<int> data, string path = Settings.Values.mockDataFilePath)
        {
            using (StreamWriter file = new StreamWriter(path))
            {
                foreach (var line in data)
                {
                    file.WriteLine(line);
                }
            }
        }
    }
}
