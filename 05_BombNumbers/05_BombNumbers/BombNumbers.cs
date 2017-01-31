using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bombDemage = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> result = new List<int>();
            int bomb = bombDemage[0];
            int damage = bombDemage[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    if (i - damage >= 0 && i + damage < numbers.Count)
                    {
                        for (int j = i - damage; j <= i + damage; j++)
                        {
                            numbers[j] = -100;
                        }
                    }
                    else if (i - damage < 0)
                    {
                        for (int j = 0; j <= i + damage; j++)
                        {
                            numbers[j] = -100;
                        }
                    }
                    else if (i + damage >= numbers.Count)
                    {
                        for (int j = i - damage; j < numbers.Count; j++)
                        {
                            numbers[j] = -100;
                        }
                    }
                    else
                    {
                        for (int j = 0; j < numbers.Count; j++)
                        {
                            numbers[j] = -100;
                        }
                    }
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] != -100)
                {
                    result.Add(numbers[i]);
                }
            }
            Console.WriteLine(result.Sum());

        }
    }
}
