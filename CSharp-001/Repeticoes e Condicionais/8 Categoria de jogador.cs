using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a idade do jogador: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade <= 13)
            Console.WriteLine("Categoria: Infantil");
        else if (idade <= 17)
            Console.WriteLine("Categoria: Juvenil");
        else
            Console.WriteLine("Categoria: Sênior");
    }
}
