using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite quatro notas: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        double nota2 = Convert.ToDouble(Console.ReadLine());
        double nota3 = Convert.ToDouble(Console.ReadLine());
        double nota4 = Convert.ToDouble(Console.ReadLine());

        double media = (nota1 + nota2 + nota3 + nota4) / 4;

        Console.WriteLine($"Média: {media:F2}");
        Console.WriteLine(media >= 5 ? "Aprovado" : "Reprovado");
    }
}
