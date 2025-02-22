using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de cópias: ");
        int copias = Convert.ToInt32(Console.ReadLine());

        double preco = copias > 200 ? copias * 0.30 : copias * 0.50;

        Console.WriteLine($"Valor a ser pago: R$ {preco:F2}");
    }
}
