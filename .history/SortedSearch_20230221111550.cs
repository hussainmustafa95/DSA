using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{

    public class SortedSearch
    {
        public static int CountNumbers(int[] sortedArray, int lessThan)
        {
            int start = 0;
            int end = sortedArray.Length - 1;
            int mid;

            // Perform binary search to find the index of the first element
            // in the array that is greater than or equal to lessThan.
            while (start <= end)
            {
                mid = (start + end) / 2; // 2 // 1
                if (sortedArray[mid] < lessThan) // 5< 4 = false // 1< 4 true;
                {
                    start = mid + 1; // 1+1 = 2
                }
                else
                {
                    end = mid - 1; // end =  1;
                }
            }

            // The number of elements less than lessThan is the index of the first
            // element in the array that is greater than or equal to lessThan.
            return start;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4));
        }
    }
}