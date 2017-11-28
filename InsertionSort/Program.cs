using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = new int[] { 3,5,2,4,1 };
            Console.WriteLine("Unsorted Array:");
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Console.Write($"{unsortedArray[i]} ");
            }
            Console.WriteLine();

            int[] sortedArray = Sort(unsortedArray);
            Console.WriteLine("Sorted Array:");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write($"{sortedArray[i]} ");
            }
            Console.WriteLine();
        }

        public static int[] Sort(int[] numbers)
        {
            int length = numbers.Length;

            for (int i = 1; i < length; i++)    
            {
                for (int j = i; j > 0 && numbers[j-1] > numbers[j]; j--)
                {
                    //swap
                    int temp = numbers[j];
                    numbers[j] = numbers[j - 1];
                    numbers[j - 1] = temp;
                }
            }
            return numbers;
        }
    }
}
