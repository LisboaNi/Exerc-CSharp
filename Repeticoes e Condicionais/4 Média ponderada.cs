using System;

class Program
{
    static void Main()
    {
        Console.Write("Nome do aluno: ");
        string nome = Console.ReadLine();

        Console.Write("Nota 1 (peso 2): ");
        double nota1 = Convert.ToDouble(Console.ReadLine()) * 2;

        Console.Write("Nota 2 (peso 4): ");
        double nota2 = Convert.ToDouble(Console.ReadLine()) * 4;

        Console.Write("Nota 3 (peso 6): ");
        double nota3 = Convert.ToDouble(Console.ReadLine()) * 6;

        double media = (nota1 + nota2 + nota3) / (2 + 4 + 6);

        Console.WriteLine($"Aluno: {nome}\nMédia ponderada: {media:F2}");
    }
}
