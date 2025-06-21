using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Digite três números: ");
        int[] numeros = new int[3];
        for (int i = 0; i < 3; i++)
            numeros[i] = Convert.ToInt32(Console.ReadLine());

        Array.Sort(numeros);
        Console.WriteLine("Números em ordem crescente: " + string.Join(", ", numeros));
    }
}
