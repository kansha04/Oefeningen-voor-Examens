// Oefening 2.2 Gebruikersnaam generator //

/* Vraag de gebruiker om zijn voornaam en achternaam. Maak een gebruikersnaam door:

    De eerste 3 letters van de voornaam (in kleine letters)
    De eerste 3 letters van de achternaam (in hoofdletters)
    Voorbeeld: Jan Peeters → janPEE

Tip: Gebruik .Substring(), .ToLower() en .ToUpper(). */
System.Console.WriteLine("=== Gebruikersnaam Generator ===");
// Input //

// Vraag de gebruiker om zijn voornaam en achternaam //
Console.Write("Voornaam: ");
string voornaam = Console.ReadLine();
Console.Write("Achternaam: ");
string achternaam = Console.ReadLine();

// String manipulatie //
string eerste3voornaam = voornaam.Substring(0, 3);
string eerste3achternaam = achternaam.Substring(0, 3);

// Output //
Console.Write($"Uw gebruikersnaam is: {eerste3voornaam.ToLower()}{eerste3achternaam.ToUpper()}");