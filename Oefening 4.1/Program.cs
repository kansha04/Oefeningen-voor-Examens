// Oefening 4.1: Wiskundige berekeningen //

/* Vraag de gebruiker om een getal. Bereken en toon:
Het getal tot de macht 2, 3 en 4 (gebruik Math.Pow() )
De vierkantswortel van het getal (gebruik Math.Sqrt() )
Het getal afgerond naar boven en naar beneden */

// Input //
Console.Write("Geef een getal: ");
double getal = double.Parse(Console.ReadLine());

// Berekeningen 
double tweedeMacht = Math.Pow(getal, 2);
double derdeMacht = Math.Pow(getal, 3);
double vierdeMacht = Math.Pow(getal, 4);
double vierkantswortel = Math.Sqrt(getal);
double afgerond = Math.Round(getal);

// Output //
Console.Clear();

Console.WriteLine($"Het getal {getal} tot de 2de macht = {tweedeMacht}");
Console.WriteLine($"Het getal {getal} tot de 3de macht = {derdeMacht}");
Console.WriteLine($"Het getal {getal} tot de 4de macht = {vierdeMacht}");
Console.WriteLine($"Vierkantswortel {getal} = {Math.Round(vierkantswortel, 3)}");
Console.WriteLine($"Getal afgerond = {afgerond}");

