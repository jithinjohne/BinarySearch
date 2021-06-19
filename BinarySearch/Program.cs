using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int.TryParse(Console.ReadLine(), out int searchCandidate);

            //Binary Search
            var low = 0;
            var high = listOfNumbers.Length - 1;
            int mid =0;
            var numberFound = false;
            while (low <= high && !numberFound)
            {
                mid = (int)Math.Floor((decimal)((low + high) / 2));
                if (searchCandidate == listOfNumbers[mid])
                {
                    numberFound = true;
                }
                else if (searchCandidate < listOfNumbers[mid])
                {
                    high = mid - 1;
                }
                else if (searchCandidate > listOfNumbers[mid])
                {
                    low = mid + 1;
                }
            }

            if (numberFound)
            {
                Console.WriteLine($"Number found at : {mid + 1}");
            }
            else
            {
                Console.WriteLine("Number not found :(");
            }
        }
    }
}
