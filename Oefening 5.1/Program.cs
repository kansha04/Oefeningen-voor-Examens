// Oefening 5.1: Cijfer beoordeling //
/*  Vraag de gebruiker om een cijfer (0-10). Gebruik een if-else structuur om de beoordeling te tonen: 
0-4: Onvoldoende
5-6: Voldoende
7-8: Goed
9-10: Uitstekend */

// Input //
Console.Write("Cijfer: ");
double cijfer = double.Parse(Console.ReadLine());

// Condities // 
if (cijfer >= 0 && cijfer <= 4)
{
    Console.WriteLine("Onvoldoende");
}
else if (cijfer >= 5 && cijfer <= 6)
{
    Console.WriteLine("Voldoende");
}
else if (cijfer >= 7 && cijfer <= 8)
{
    Console.WriteLine("Goed");
}
else if (cijfer >= 9 && cijfer <= 10)
{
    Console.WriteLine("Uitstekend");
}
else
{
    Console.WriteLine("Error! Probeer opniuew.");
}