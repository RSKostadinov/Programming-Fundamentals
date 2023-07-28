using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "Finish")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string commandType = command[0];


                switch (commandType)
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        break;

                    case "Remove":
                        int numberToRemove = int.Parse(command[1]);
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numberToRemove == numbers[i])
                            {
                                numbers.Remove(numbers[i]);
                                break;
                            }
                        }
                        break;

                    case "Replace":
                        int numberToBeReplaced = int.Parse(command[2]);
                        int numberToReplace = int.Parse(command[1]);
                        int indexOfElement = -1;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numberToReplace == numbers[i])
                            {
                                indexOfElement = i;
                            }

                            if (indexOfElement >= 0)
                            {
                                numbers[indexOfElement] = numberToBeReplaced;
                                break;
                            }
                        }
                        break;
                    case "Collapse":
                        int numberToCollapse = int.Parse(command[1]);
                        List<int> numberesCopy = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {

                            if (numbers[i] >= numberToCollapse)
                            {
                                numberesCopy.Add(numbers[i]);
                            }
                        }
                        numbers = numberesCopy;
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}