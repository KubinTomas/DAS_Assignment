using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortPr
{
    public class BubbleSort
    {
        public int[] Sort(int[] numbers)
        {
            int j = numbers.Length - 2, temp;
            // kontrola prohozeni
            bool isSwapped = true;
            while (isSwapped)
            {
                isSwapped = false;
                for (int i = 0; i <= j; i++)
                {
                    // swap
                    if (numbers[i] > numbers[i + 1])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                        isSwapped = true;
                    }
                }
                j--;
            }

            return numbers;
        }
    }
}
