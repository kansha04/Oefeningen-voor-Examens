// Oefening 2.1: Persoonlijke boodschap

/* Vraag de gebruiker om zijn/haar voornaam en achternaam. Maak een boodschap met string
interpolatie: "Welkom, [Voornaam] [Achternaam]!" */

// Input //
Console.Write("Voornaam: ");
string voornaam = Console.ReadLine();
Console.Write("Achternaam: ");
string achternaam = Console.ReadLine();

// Output // 
System.Console.WriteLine($"Welkom, {voornaam} {achternaam}!");