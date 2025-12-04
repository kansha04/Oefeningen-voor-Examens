// Oefening 3.2 //

/* Vraag de gebruiker om een temperatuur in Celsius. Bereken en toon de temperatuur in Fahrenheit
en Kelvin.
*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Temperaatuur convertor ===");
        // Input //
        Console.Write("Geef een temperatuur in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        // Formules //
        double fahrenheit = celsius * 9 / 5 + 32;
        double kelvin = celsius + 273.15;

        // Output //
        Console.Clear();
        Console.WriteLine($"Celsius: {celsius}\n Fahrenheit: {fahrenheit}\n Kelvin: {kelvin}");
    }
}