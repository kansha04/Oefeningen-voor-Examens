// Oefening 3.4  Even of oneven //
 /* 
    Vraag de gebruiker om een getal. Gebruik de modulo operator (%) om te bepalen of het getal
    even of oneven is. Toon het resultaat.
 */

// Input 
Console.Write("Geef een getal: ");
double getal = double.Parse(Console.ReadLine());

// Modulo
if (getal % 2 == 0)
{
    Console.WriteLine($"Het getal {getal} is even");
} else
{
    System.Console.WriteLine($"Het getal {getal} is oneven");
}