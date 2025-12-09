using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = new List<string>();

            shoppingList.Add("Kobe 6 Grinches");
            shoppingList.Add("Nocta Nike Tech");
            shoppingList.Add("Airpods Max");
            shoppingList.Add("Arc'teryx SL Beta");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                System.Console.WriteLine(shoppingList[i]);
            }

            shoppingList.RemoveAt(0);

            System.Console.WriteLine("----------------------");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                System.Console.WriteLine(shoppingList[i]);
            }
        }
    }
}