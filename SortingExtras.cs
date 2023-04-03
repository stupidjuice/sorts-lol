using System;

namespace SortingExtras
{
    public static class SortingExtensions
    {
        public static int[] CreateRandomArray(int length)
        {
            var rand = new Random();
            int[] temp = new int[length];

            for (int i = 0; i < length; i++)
            {
                temp[i] = i + 1;
            }
            for (int i = 1; i < length; i++)
            {
                Swap(temp, i - 1, rand.Next(i, length));
            }

            return temp;
        }

        public static void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }

        public static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}