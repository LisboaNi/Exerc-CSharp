using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num >= 200 && num <= 300)
            Console.WriteLine("O número está no intervalo entre 200 e 300.");
        else
            Console.WriteLine("O número NÃO está no intervalo entre 200 e 300.");
    }
}
