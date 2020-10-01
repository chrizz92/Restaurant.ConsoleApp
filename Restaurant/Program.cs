using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Restaurant
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<string, int> drinks = new Dictionary<string, int>();
            string[] drinksFromFile = File.ReadAllLines("orders.csv", Encoding.UTF8);
            string[] data;

            for (int i = 0; i < drinksFromFile.Length; i++)
            {
                data = drinksFromFile[i].Split(';');
                if (drinks.ContainsKey(data[0]))
                {
                    drinks[data[0]]++;
                }
                else
                {
                    drinks.Add(data[0], 1);
                }
            }

            foreach (string drink in drinks.Keys)
            {
                Console.WriteLine($"{drink,-8}:{drinks[drink],2}");
            }
        }
    }
}