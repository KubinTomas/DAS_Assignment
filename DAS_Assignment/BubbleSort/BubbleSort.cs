using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortPr
{
    public class BubbleSort
    {

        public int SwapCounter { get; set; }

        public BubbleSort()
        {
            SwapCounter = 0;
        }

        public int[] Sort(int[] numbers)
        {
            SwapCounter = 0;

            int j = numbers.Length - 2;
            int temp;
          
            bool isSwapped = true;
            while (isSwapped)
            {
                isSwapped = false;
                for (int i = 0; i <= j; i++)
                {
                    
                    if (numbers[i] > numbers[i + 1])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                        isSwapped = true;
                        SwapCounter++;
                    }
                }
                j--;
            }

            return numbers;
        }
    }
}
