using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite dois números: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Diferença: {Math.Abs(num1 - num2)}");
    }
}
