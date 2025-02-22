using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Soma: {num1 + num2}");
        Console.WriteLine($"Subtração: {num1 - num2}");
        Console.WriteLine($"Multiplicação: {num1 * num2}");
        Console.WriteLine($"Divisão: {(num2 != 0 ? (num1 / (double)num2) : double.NaN):F2}");
    }
}
