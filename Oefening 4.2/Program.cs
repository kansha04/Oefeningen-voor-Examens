// Oefening 4.2: Dobbelsteenworp simulatie

/* Simuleer het werpen van twee dobbelstenen. Toon:
Het resultaat van dobbelsteen 1
Het resultaat van dobbelsteen 2
Het totaal
Of de gebruiker een "dubbel" heeft gegooid (beide dobbelstenen hetzelfde getal)
Tip: Gebruik Random.Next(1, 7) voor getallen tussen 1 en 6. */

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Dobbelsteen werper");

        // Variabelen //

        Random randomGen = new Random();

        int roll1 = 0;
        int roll2 = 1;
        int attempts = 0;

        Console.WriteLine("Druk op enter om de dobbelsteen te gooien.");
        // While loop //

        do
        {
            Console.ReadKey();

            roll1 = randomGen.Next(1, 7);
            roll2 = randomGen.Next(1, 7);

            Console.WriteLine($"Dobbelsteen 1: {roll1}");
            Console.WriteLine($"Dobbelsteen 2: {roll2}");
            attempts++;
        } while (roll1 != roll2);

        Console.WriteLine($"Er waren in totaal {attempts} worpen nodig om een dubbel te gooien.");
    }
}