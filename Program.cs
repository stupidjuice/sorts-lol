using System;

namespace Sorts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();

            int length = 10;
            int[] randomArray = program.CreateRandomArray(length);

            for(int i = 0; i < length; i++)
            {
                Console.WriteLine(randomArray[i]);
            }
        }

        public int[] CreateRandomArray(int length)
        {
            var rand = new Random();
            int[] temp = new int[length];

            for(int i = 0; i < length; i++)
            {
                temp[i] = i + 1;
            }
            for (int i = 1; i < length; i++)
            {
                Swap(temp, i - 1, rand.Next(i - 1, length));
            }

            return temp;
        }

        public void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }

        public void SelectionSort(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                int lowestindex = i;

                for(int j = i + 1; j < array.Length; j++)
                {
                    if(array[j] < array[lowestindex])
                    {
                        lowestindex = j;
                    }
                }
                Swap(array, i, lowestindex);
            }
        }

    }
}