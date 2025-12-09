// Oefening 4.4: Wachtwoord validatie //
/*  Vraag de gebruiker om een wachtwoord in te voeren. Controleer:
Of het wachtwoord minstens 8 karakters lang is (.Length )
Of het spaties bevat (.Contains(" ") )
Toon of het wachtwoord geldig is of niet */ 

// Input //
Console.Write("Voer een wachtwoord in (minstens 8 karakters): ");
string wachtwoord = Console.ReadLine();

// Controleren //

if (wachtwoord.Length >= 8 && !wachtwoord.Contains(" "))
{
    Console.WriteLine("Uw wachtwoord is geldig.");
}
else
{
    if (wachtwoord.Contains(" "))
    {
        System.Console.WriteLine("Uw wachtwoord mag geen spacies bevatten.");
    }
    if (wachtwoord.Length < 8)
    {
        System.Console.WriteLine("Uw wachtwoord moet minstens 8 karakters hebben.");
    }
}
