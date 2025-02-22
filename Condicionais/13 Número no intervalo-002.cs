using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num >= 100 && num <= 200)
            Console.WriteLine("O número está no intervalo entre 100 e 200.");
        else
            Console.WriteLine("O número NÃO está no intervalo entre 100 e 200.");
    }
}
