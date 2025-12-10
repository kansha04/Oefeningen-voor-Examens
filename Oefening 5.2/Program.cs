// Oefening 5.2: Grootste van drie
/* Vraag de gebruiker om drie getallen in te voeren. Bepaal en toon welk getal het grootste is.
Tip: Gebruik geneste if-statements of logische operatoren! */

internal class Program
{
    private static void Main(string[] args)
    {
        // Input //
        Console.WriteLine("=== Grootste van drie ===");
        int[] getallen = new int[3];
        // for loop voor 3 drie getallen
        Console.WriteLine("Voer in 3 getallen: ");
        for (int i = 0; i < getallen.Length; i++)
        {
            getallen[i] = int.Parse(Console.ReadLine());
        }
        // check if input works
        /* for (int i = 0; i < getallen.Length; i++)
        {
            Console.WriteLine(getallen[i]);
        } */
        int grootste = getallen[0];
        // Conditionals //
        for (int i = 0; i < getallen.Length; i++)
        {
            if (getallen[i] > grootste)
            {
                grootste = getallen[i];
            }
            
        }
        Console.WriteLine($"\nHet grootste getal is: {grootste}");
    }
}