using System;

class Program
{
    static void Main()
    {
        Console.Write("Nome do vendedor: ");
        string nome = Console.ReadLine();

        Console.Write("Salário fixo: ");
        double salarioFixo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Total de vendas: ");
        double vendas = Convert.ToDouble(Console.ReadLine());

        double salarioFinal = salarioFixo + (vendas * 0.2);

        Console.WriteLine($"Vendedor: {nome}\nSalário fixo: {salarioFixo:C}\nSalário final: {salarioFinal:C}");
    }
}
