// Arrays allow us to store multiple values in a single variable //
using System;
using System.Collections.Generic;

/* namespace Arrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Arrays allow us to store multiple values in a single variable //
            // Syntax //
            string[] favourites =
            {
                "Shevon", // index 0
                "Jim Legxacy", // index 1...
                "Lebron",
                "Shai Gilgeous-Alexander"
            };

            // Console.WriteLine(favourites[2]);

            string[] animes = new string[4];

            Console.WriteLine("Write in 4 animes: ");

            for (int i = 0; i < animes.Length; i++)
            {
                animes[i] = Console.ReadLine();
            }

            Console.WriteLine("Here they are in alphabetical order: ");

            Array.Sort(animes);

            for (int i = 0; i < animes.Length; i++)
            {
                Console.WriteLine(animes[i]);
            }
        }
    }
} */

/*namespace Lists
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
} */

namespace challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input // 
            Console.WriteLine("How many students are in your class?: ");
            string[] students = new string[int.Parse(Console.ReadLine())];
            System.Console.WriteLine("Please enter your students names: ");
            // for loop for entering students
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = Console.ReadLine();
            }
            Console.Clear();
            // Output 
            Console.WriteLine("Class List");
            Console.WriteLine("----------");
            Array.Sort(students);
            // for loop to display students to console
            for (int i = 0; i < students.Length; i++)
            {
                int order = i + 1;
                Console.WriteLine(order + ". " + students[i]);
            }
        }
    }
}
