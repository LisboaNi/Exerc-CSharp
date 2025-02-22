using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite três números: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());
        double num3 = Convert.ToDouble(Console.ReadLine());

        double media = (num1 + num2 + num3) / 3;

        Console.WriteLine($"Média: {media:F2}");
    }
}
