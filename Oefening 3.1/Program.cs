// Oefening 3.1: Rekenmachine basis //

/* Maak een simpel programma dat twee getallen vraagt en alle basisoperaties uitvoert: optellen,
aftrekken, vermenigvuldigen, delen en modulo. Toon alle resultaten. */

internal class Program
{
    private static void Main(string[] args)
    {
        // Input // 
        Console.Write("Voer getal 1 in: ");
        double getal1 = double.Parse(Console.ReadLine());
        Console.Write("Voer getal 2 in: ");
        double getal2 = double.Parse(Console.ReadLine());

        // Berekeningen //
        double som = getal1 + getal2;
        double min = getal1 - getal2;
        double product = getal1 * getal2;
        double quotient = getal1 / getal2;
        double modulo = getal1 % getal2;

        // Output // 
        Console.WriteLine
        ($"Getal 1: {getal1}; Getal 2; {getal2}");
        Console.WriteLine($"De som van {getal1} en {getal2} = {som}");
        Console.WriteLine($"De verschil tussen {getal1} en {getal2} = {min}");
        Console.WriteLine($"De product van {getal1} en {getal2} = {product}");
        Console.WriteLine($"De quotient van {getal1} en {getal2} = {Math.Floor(quotient)}");
        Console.WriteLine($"De restnadeling van {getal1} en {getal2} = {modulo}");
    }
}

// Versie 2
