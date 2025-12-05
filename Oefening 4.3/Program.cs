// Oefening 4.3: Leeftijd berekenen

/*
Vraag de gebruiker om zijn geboortedatum (bijvoorbeeld: "1990-05-15"). Bereken en toon:
Hoeveel jaar oud de persoon is
Op welke dag van de week hij geboren is
Hoeveel dagen het nog duurt tot zijn volgende verjaardag
Tip: Gebruik DateTime.Parse() en DateTime.Now . 
*/

// Input // 
Console.WriteLine("Geboortedatum (bijvoorbeeld: \"1990-05-15\"): ");
DateTime geboortedatum = DateTime.Parse(Console.ReadLine() ?? "");

DateTime vandaag = DateTime.Now;

// Leeftijd // 
int leeftijd = vandaag.Year - geboortedatum.Year;
if (geboortedatum.Date > vandaag.AddYears(-leeftijd)) leeftijd--;

// dagVanWeek //
string dagVanWeek = geboortedatum.DayOfWeek.ToString();

// Dagen tot volgende verjaardag //
DateTime volgendeVerjaardag = new DateTime(vandaag.Year, geboortedatum.Month, geboortedatum.Day);
if (volgendeVerjaardag < vandaag) volgendeVerjaardag = volgendeVerjaardag.AddYears(1);
int dagenTotVerjaardag = (int)(volgendeVerjaardag - vandaag).TotalDays;

Console.WriteLine($"Leeftijd: {leeftijd} jaar\nGeboren op: {dagVanWeek}\nDagen tot verjaardag: {dagenTotVerjaardag}");