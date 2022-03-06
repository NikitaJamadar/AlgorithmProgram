using System;

namespace AlgorithmProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Anagram 2.Binary Search 3.Bubble sort 4.Insertion sort 5.prime number 6.permutation");
            Console.WriteLine("enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Anagram.AnagramDetection();
                    break;

                case 2:
                    BinarySearch.Result();
                    break;

                case 3:
                    BubbleSort.bubbleSort();
                    break;

                case 4:
                    InsertionSort.insertionSort();
                    break;

                case 5:
                    PrimeNumber.Prime();
                    break;

                case 6:
                    Permutation.Result();
                    break;
            }


            

           

           

          

           
        }
    }
}
