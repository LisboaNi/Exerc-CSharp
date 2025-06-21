using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a temperatura em Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        double celsius = ((fahrenheit - 32) * 5) / 9;

        Console.WriteLine($"Temperatura em Celsius: {celsius:F2}");
    }
}
