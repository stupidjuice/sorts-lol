using System;
using SortingExtras;

namespace Sorts
{
    public class Sorts
    {
        public int[] SelectionSort(int[] array) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                int lowestindex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[lowestindex])
                    {
                        lowestindex = j;
                    }
                }
                SortingExtensions.Swap(array, i, lowestindex);
            }

            return array;
        }
    }
}