using System;
using SortingExtras;

namespace Sorts
{
    public class Sorts
    {
        public void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }

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
                Swap(array, i, lowestindex);
            }

            return array;
        }

        public int[] DoubleSelectionSort(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;

            int lowestindex = 0;
            int highestindex = 0;

            while(left <= right)
            {
                for (int i = left; i <= right; i++)
                {
                    if(array[i] > array[highestindex])
                    {
                        highestindex = i;
                    }
                    if (array[i] < array[lowestindex])
                    {
                        lowestindex = i;
                    }
                }

                if(highestindex == left)
                {
                    highestindex = lowestindex;
                }

                Swap(array, left, lowestindex);
                Swap(array, right, highestindex);

                left++;
                right--;

                lowestindex = left;
                highestindex = right;
            }

            return array;
        }
    }
}