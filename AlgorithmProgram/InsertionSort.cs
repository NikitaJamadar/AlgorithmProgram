using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProgram
{
    class InsertionSort
    {
        public static void insertionSort()
        {
            int[] arr = { 12, 11, 13, 15 ,14};
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;


                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }

            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + "  ");

            Console.Write("\n ");
        }
    }
}
