using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManipulator
{
    public class Reader
    {
        public int[] Read(string path = Settings.Values.mockDataFilePath)
        {
            var lines = File.ReadAllLines(path);

            var values = new int[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                values[i] = Int32.Parse(lines[i]);
            }

            return values;
        }

    }
}
