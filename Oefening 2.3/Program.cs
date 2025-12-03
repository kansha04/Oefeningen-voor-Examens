// Oefening 2.3: Tekstverwerking //
/* Vraag de gebruiker om een zin in te voeren. Toon:
    De lengte van de zin
    De zin in hoofdletters
    De zin in kleine letters
    De zin zonder spaties aan het begin en einde 
*/

// Input vragen aan user //
Console.Write("Geef een zin: ");
string userZin = Console.ReadLine();

// Tekst verwerkingen // 

// Lengte van de zin //
int zinLengte = userZin.Length;

// Zin in hoofdletters //
string zinHoofdlettters = userZin.ToUpper();

// Zin in kleine letters //
string zinKleineLetters = userZin.ToLower();

// Zin zonder spaties //
string geenSpaties = userZin.Trim();

// Output //
System.Console.WriteLine
($"Uw zin: '{userZin}'\n De lengte van jouw zin: {zinLengte} karakters\n Uw zin in hoofdletters :'{zinHoofdlettters}'\n Uw zin in kleine letters: '{zinKleineLetters}'\n Uw zin zonder spaties: '{geenSpaties}'");