using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_MaxSequenceEqualElements
{
    class MaxSequence
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int count = 1;
            int start = -1;
            int maxCount = 1;
            int bestStart = -1;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                    start = i;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        bestStart = start;
                    }
                }
                else
                {
                    count = 1;
                    start = -1;
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write("{0} ", numbers[bestStart]);
            }
        }
    }
}
