using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class DualPivotQuickSort
    {
        public int[] Sort(int[] numbers)
        {
            Sort(numbers, 0, numbers.Length - 1);

            return numbers;
        }


        /// <summary>
        /// Quicksort sorting
        /// Using dual-pivot quicksort, lo
        /// numbers[lo .. hi] using dual-pivot quicksort
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="lo"></param>
        /// <param name="hi"></param>
        private void Sort(int[] numbers, int lo, int hi)
        {
            // only pairs
            if (hi <= lo) return;

            // swaping numbers
            if ((numbers[hi] <= numbers[lo])) Exchange(numbers, lo, hi);

            int lt = lo + 1;
            int gt = hi - 1;
            int i = lo + 1;

            while (i <= gt)
            {
                if ((numbers[i] <= numbers[lo])) Exchange(numbers, lt++, i++);
                else if ((numbers[hi] <= numbers[i])) Exchange(numbers, i, gt--);
                else i++;
            }
            Exchange(numbers, lo, --lt);
            Exchange(numbers, hi, ++gt);

            // recursively sort three subarrays
            Sort(numbers, lo, lt - 1);
            if ((numbers[lt] <= numbers[gt])) Sort(numbers, lt + 1, gt - 1);
            Sort(numbers, gt + 1, hi);

        }
        /// <summary>
        /// Swap items in array
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        private void Exchange(int[] numbers, int i, int j)
        {
            int swap = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = swap;
        }
    }
}
