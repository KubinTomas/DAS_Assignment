using System;

namespace InsertSortPr
{
    public class InsertSort
    {
        public int[] Sort(int[] numbers)
        {
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
                numbers[j + 1] = item;
            }

            return numbers;
        }
    }
}
