using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_SumReversedNumbers
{
    class SumReversed
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').ToList();
            List<int> reversedNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                char[] element = numbers[i].ToCharArray();
                char[] reversed = element.Reverse().ToArray();
                reversedNumbers.Add(int.Parse(string.Join("", reversed)));
            }
            Console.WriteLine(reversedNumbers.Sum());

        }
    }
}
