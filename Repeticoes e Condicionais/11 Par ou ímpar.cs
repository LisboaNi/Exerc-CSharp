using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(num % 2 == 0 ? "Par" : "Ímpar");
    }
}
