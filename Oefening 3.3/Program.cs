// Oefening 3.3 BTW berekenen //

/* Vraag de gebruiker om een prijs exclusief BTW. Bereken en toon:
    Het BTW-bedrag (21%)
    De totaalprijs inclusief BTW
    Gebruik de += operator om de BTW bij de prijs op te tellen! 
*/

// Input //
Console.Write("Prijs exclusief btw: ");
double prijsExclusief = double.Parse(Console.ReadLine());

// BTW berekening //
double btw = 0.21;
double prijsIncusief = prijsExclusief + (prijsExclusief * btw);

// Output //
Console.WriteLine($"Prijs zonder btw = {prijsExclusief}");
Console.WriteLine($"Prijs met btw = {prijsIncusief}");
