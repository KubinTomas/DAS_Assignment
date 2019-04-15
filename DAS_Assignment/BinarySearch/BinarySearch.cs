using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchDll
{
    public class BinarySearch
    {
        /// <summary>
        /// Return count of specific number in arrays
        /// </summary>
        /// <param name="searchedNumber"></param>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int GetNumberCountInNumbers(int searchedNumber, int[] numbers)
        {
            int startIndex = 0;
            int endIndex = numbers.Length - 1;
            int count = 0;

            if (numbers[startIndex] == searchedNumber)
            {
                count++;
                int pointer = startIndex + 1;
                while (pointer <= numbers.Length - 1 && numbers[pointer] == searchedNumber)
                {
                    count++;
                    pointer++;
                }
                return count;
            }
            if (numbers[endIndex] == searchedNumber)
            {
                count++;
                int pointer = endIndex - 1;
                while (pointer >= 0 && numbers[pointer] == searchedNumber)
                {
                    count++;
                    pointer--;
                }
                return count;
            }

            while (endIndex - startIndex != 1)
            {
                int middle = (startIndex + endIndex) / 2;

                if (numbers[middle] < searchedNumber)
                {
                    startIndex = middle;
                }
                else if (numbers[middle] > searchedNumber)
                {
                    endIndex = middle;
                }

                if (numbers[middle] == searchedNumber)
                {
                    count++;
                    int pointer = middle - 1;

                    while (pointer >= 0 && numbers[pointer] == searchedNumber)
                    {
                        count++;
                        pointer--;
                    }

                    pointer = middle + 1;
                    while (pointer <= numbers.Length - 1 && numbers[pointer] == searchedNumber)
                    {
                        count++;
                        pointer++;
                    }
                    return count;
                }

            }

            return count;
        }
    }
}
