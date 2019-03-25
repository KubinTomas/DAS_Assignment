using System;

namespace InsertSortPr
{
    public class InsertionSort
    {

        public int SwapCounter { get; set; }

        public InsertionSort()
        {
            SwapCounter = 0;
        }

        public int[] Sort(int[] numbers)
        {
            SwapCounter = 0;

            int item, j;

            for (int i = 1; i <= (numbers.Length - 1); i++)
            {
                item = numbers[i];
                j = i - 1;
                while ((j >= 0) && (numbers[j] > item))
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                SwapCounter++;
                numbers[j + 1] = item;
            }

            return numbers;
        }
    }
}
