// Oefening 1.3: Type conversies
/* Vraag de gebruiker om twee getallen (als string). Converteer ze naar integers, bereken de som, en
toon het resultaat.
Let op: Gebruik Convert.ToInt32() of int.Parse(). */

// Input // 
System.Console.Write("Geef getal 1: ");
int getal1 = int.Parse(Console.ReadLine());
System.Console.Write("Geef getal 2: ");
int getal2 = int.Parse(Console.ReadLine());

// Som berekenen //
int som = getal1 + getal2;

// Output // 
System.Console.WriteLine($"Som van {getal1} en {getal2} is {som}");