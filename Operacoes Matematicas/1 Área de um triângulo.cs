using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a base do triângulo: ");
        double baseTriangulo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a altura do triângulo: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double area = (baseTriangulo * altura) / 2;

        Console.WriteLine($"Área do triângulo: {area:F2}");
    }
}
