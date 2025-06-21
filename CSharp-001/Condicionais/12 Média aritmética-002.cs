using System;

class Program
{
    static void Main()
    {
        Console.Write("Nome do aluno: ");
        string nome = Console.ReadLine();

        Console.Write("Digite três notas: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        double nota2 = Convert.ToDouble(Console.ReadLine());
        double nota3 = Convert.ToDouble(Console.ReadLine());

        double media = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine($"Aluno: {nome}\nMédia: {media:F2}");
    }
}
