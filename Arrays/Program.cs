using System;
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
        Console.WriteLine(favourites[3]); // print out index

        string[] animes = new string[4];
        Console.Clear();
        Console.WriteLine("Type in four anime's: ");
        for (int i = 0; i < animes.Length; i++)
        {
            animes[i] = Console.ReadLine();
        }
        Console.Clear();
        Console.WriteLine("\nHere they are alphabetically: ");
        Array.Sort(animes);

        for (int i = 0; i < animes.Length; i++)
        {
            Console.WriteLine(animes[i]);
        }
    }
}