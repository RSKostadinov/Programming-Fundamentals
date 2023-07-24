using System;
using System.Collections.Generic;

namespace P02AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, uint> resourceMap = new Dictionary<string, uint>();

            string resource;
            uint quantity;
            while ((resource = Console.ReadLine()) != "stop") 
            {
                quantity = uint.Parse(Console.ReadLine());

                if (!resourceMap.ContainsKey(resource))
                {
                    resourceMap.Add(resource, 0);
                }
                resourceMap[resource] += quantity;
            }

            foreach (var kvp in resourceMap)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
