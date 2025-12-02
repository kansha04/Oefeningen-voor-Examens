// Oefening 1.2: Constanten gebruiken //

/* Maak een programma dat de omtrek en oppervlakte van een cirkel berekent. Gebruik een
constante voor PI (3.14159). Vraag de gebruiker om de straal in te voeren. */

/* Omtrek = 2 × PI × straal
Oppervlakte = PI × straal² */

// Input //
// Vraag de gebruiker om de straal in te voeren.
System.Console.WriteLine("Geef een straal: ");
double straal = Convert.ToDouble(Console.ReadLine());

// Berekeningen //

// Constanten
const double pi = 3.14159;
// Formules omtrek en oppervlakte
double omtrek = Math.Round(2 * pi * straal, 2);
double oppervlakte = Math.Round(pi * Math.Pow(straal, 2), 2);

// Output // 
System.Console.WriteLine($"Omtrek: {omtrek}");
System.Console.WriteLine($"Oppervlakte: {oppervlakte}");