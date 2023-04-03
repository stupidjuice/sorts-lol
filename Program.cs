using System;
using SortingExtras;

namespace Sorts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int length = 10;
            int[] randomArray = SortingExtensions.CreateRandomArray(length);

            Sorts sorts = new Sorts();
            SortingExtensions.PrintArray(sorts.SelectionSort(randomArray));
        }
    }
}