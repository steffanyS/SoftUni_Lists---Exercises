using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_ArrayManipulator
{
    class Manipulator
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> commands = new List<string>();
            commands = Console.ReadLine().Split(' ').ToList();
            while (commands[0] != "print")
            {
                if (commands[0] == "add")
                {
                    numbers.Insert(int.Parse(commands[1]), int.Parse(commands[2]));
                }
                else if (commands[0] == "addMany")
                {
                    List<int> elements = new List<int>();
                    for (int i = 2; i < commands.Count; i++)
                    {
                        elements.Add(int.Parse(commands[i]));
                    }

                    numbers.InsertRange(int.Parse(commands[1]), elements);
                }
                else if (commands[0] == "contains")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers.Contains(int.Parse(commands[1])))
                        {
                            Console.WriteLine(i);
                            break;
                        }
                        else
                        {
                            if (i == numbers.Count - 1)
                            {
                                Console.WriteLine(-1);
                            }

                        }
                    }
                }

                else if (commands[0] == "remove")
                {
                    numbers.RemoveAt(int.Parse(commands[1]));
                }
                else if (commands[0] == "shift")
                {
                    //(i + r) % n

                    List<int> helper = new List<int>();

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        helper.Add(numbers[((i + int.Parse(commands[1])) % numbers.Count)]);
                    }

                    numbers = helper;
                }
                else if (commands[0] == "sumPairs")
                {
                    List<int> helper = new List<int>();

                    for (int j = 0; j < numbers.Count; j += 2)
                    {
                        helper.Add(numbers[j] + numbers[j + 1]);
                    }

                    numbers = helper;
                }

                commands = Console.ReadLine().Split(' ').ToList();
            }

            if (commands[0] == "print")
            {
                Console.Write("[");
                Console.Write(string.Join(", ", numbers));
                Console.Write("]");
            }
        }
    }
}
