using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockDataGenerator
{
    public class MockNumberGenerator
    {

        private Random _random;

        public MockNumberGenerator()
        {
            _random = new Random();
        }

        public void WriteRandomNumbersInFile(MockDataSpecification dataSpecification)
        {
            var numbers = GetRandomNumbers(dataSpecification);

            WriteDataInFile(numbers);
        }
        private List<int> GetRandomNumbers(MockDataSpecification dataSpecification)
        {
            var data = new List<int>();

            for (int i = 0; i < dataSpecification.Count; i++)
            {
                var randomNumber = _random.Next(dataSpecification.ValueFrom, dataSpecification.ValueTo);
                data.Add(randomNumber);
            }

            return data;
        }
        private void WriteDataInFile(List<int> data, string path = "testData.txt")
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
