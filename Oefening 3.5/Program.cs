// Oefening 3.5: Toegangscontrole //

/* Vraag de gebruiker om zijn leeftijd en of hij een toegangspas heeft (true/false). Gebruik logische
operatoren om te bepalen of de persoon toegang krijgt:
Je moet 18 jaar of ouder zijn ÉN een toegangspas hebben
Toon "Toegang verleend" of "Toegang geweigerd". */

// Input // 

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Leeftijd: ");
        int leeftijd = int.Parse(Console.ReadLine());

        // Conditional //

        if (leeftijd > 18)
        {
            Console.WriteLine("Toegang verleend");
        }
        else
        {
            Console.WriteLine("Toegang geweigerd");
        }
    }
}