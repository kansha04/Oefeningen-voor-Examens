using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Programma dat een leerkracht vraagt hoeveel leerlingen er in haar klas zitten en wat hun namen zijn, en vervolgens de klassenlijst opstelt. //
        System.Console.WriteLine("==== Klassenlijst Maker ====");
        // Input // 
        Console.Write("Aantal Kinderen: ");
        string[] leerlingen = new string[int.Parse(Console.ReadLine())];

        Console.WriteLine("Geef in de naam van u leerlingen");
        // for-loop om namen in te geven
        for (int i = 0; i < leerlingen.Length; i++)
        {
            leerlingen[i] = Console.ReadLine();
        }
        Array.Sort(leerlingen);

        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.Clear();

        // Output //
        Console.WriteLine("==== Klaslijst ====");
        for (int i = 0; i < leerlingen.Length; i++)
        {
            int rank = i + 1;
            Console.WriteLine(rank + ". " +leerlingen[i]);
        }
    }
}