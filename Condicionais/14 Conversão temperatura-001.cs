using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a temperatura em Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (9 * celsius + 160) / 5;

        Console.WriteLine($"Temperatura em Fahrenheit: {fahrenheit:F2}");
    }
}
