using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Exercicio1();
        Exercicio2();
        Exercicio3();
        Exercicio4();
        Exercicio5();
        Exercicio6();
        Exercicio7();
        Exercicio8();
        Exercicio9();
    }

    static void Exercicio1()
    {
        double[] numeros = new double[15];
        double[] cubos = new double[15];
        
        for (int i = 0; i < 15; i++)
        {
            Console.Write($"Digite um número {i + 1}: ");
            numeros[i] = Convert.ToDouble(Console.ReadLine());
            cubos[i] = Math.Pow(numeros[i], 3);
        }
        
        Console.WriteLine("Números digitados: " + string.Join(", ", numeros));
        Console.WriteLine("Cubos dos números: " + string.Join(", ", cubos));
    }

    static void Exercicio2()
    {
        int[] array = new int[20];
        
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Digite um número {i + 1}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.Write("Digite a posição A (0-19): ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a posição B (0-19): ");
        int B = Convert.ToInt32(Console.ReadLine());
        
        double media = (array[A] + array[B]) / 2.0;
        Console.WriteLine("Média dos valores nas posições A e B: " + media);
    }

    static void Exercicio3()
    {
        int[] valores = new int[99];
        for (int i = 0; i < 99; i++)
        {
            Console.Write($"Digite um número {i + 1}: ");
            valores[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.WriteLine("Valores na ordem inversa: " + string.Join(", ", valores.Reverse()));
    }

    static void Exercicio4()
    {
        double[] notas = new double[20];
        double soma = 0, maiorNota = 0;
        
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Digite a nota do aluno {i + 1}: ");
            notas[i] = Convert.ToDouble(Console.ReadLine());
            soma += notas[i];
            if (notas[i] > maiorNota)
                maiorNota = notas[i];
        }
        
        Console.WriteLine("Média geral: " + (soma / 20));
        Console.WriteLine("Maior nota: " + maiorNota);
    }

    static void Exercicio5()
    {
        int[] array = new int[20];
        
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Digite um número {i + 1}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        var duplicados = array.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key);
        Console.WriteLine("Valores repetidos: " + string.Join(", ", duplicados));
    }

    static void Exercicio6()
    {
        int[] array = new int[10];
        
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite um número {i + 1}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
            if (array[i] % 2 == 0)
                array[i] = 99;
        }
        
        Console.WriteLine("Array modificado: " + string.Join(", ", array));
    }

    static void Exercicio7()
    {
        double totalCedulas = 0, totalCheques = 0, totalCartao = 0;
        for (int i = 0; i < 300; i++)
        {
            Console.Write("Digite o valor pago e o método (1-cedula, 2-cheque, 3-cartão): ");
            string[] input = Console.ReadLine().Split(' ');
            double valor = Convert.ToDouble(input[0]);
            int metodo = Convert.ToInt32(input[1]);
            
            if (metodo == 1) totalCedulas += valor;
            else if (metodo == 2) totalCheques += valor;
            else if (metodo == 3) totalCartao += valor;
        }
        
        Console.WriteLine($"Total em cédulas: R${totalCedulas}");
        Console.WriteLine($"Total em cheques: R${totalCheques}");
        Console.WriteLine($"Total em cartão: R${totalCartao}");
        Console.WriteLine($"Receita total: R${totalCedulas + totalCheques + totalCartao}");
    }

    static void Exercicio8()
    {
        int votos1 = 0, votos2 = 0, brancos = 0, nulos = 0;
        for (int i = 0; i < 500; i++)
        {
            Console.Write("Digite o voto (1, 2, 3-branco, 4-nulo): ");
            int voto = Convert.ToInt32(Console.ReadLine());
            
            if (voto == 1) votos1++;
            else if (voto == 2) votos2++;
            else if (voto == 3) brancos++;
            else if (voto == 4) nulos++;
        }
        
        Console.WriteLine("Total de votos candidato 1: " + votos1);
        Console.WriteLine("Total de votos candidato 2: " + votos2);
        Console.WriteLine("Total de votos brancos: " + brancos);
        Console.WriteLine("Total de votos nulos: " + nulos);
        Console.WriteLine("Candidato vencedor: " + (votos1 > votos2 ? "Candidato 1" : "Candidato 2"));
    }
    
    static void Exercicio9()
    {
        const int totalPessoas = 800;
        int[] idades = new int[totalPessoas];
        double[] alturas = new double[totalPessoas];
        int[] sexos = new int[totalPessoas];

        int somaIdadeGrupo = 0;
        int somaIdadeHomens = 0, qtdHomens = 0;
        double somaAlturaMulheres = 0;
        int qtdMulheres = 0;
        int qtdIdade18_35 = 0;

        for (int i = 0; i < totalPessoas; i++)
        {
            Console.WriteLine($"Informe os dados da pessoa {i + 1}:");

            Console.Write("Sexo (0 - Feminino, 1 - Masculino): ");
            sexos[i] = int.Parse(Console.ReadLine());

            Console.Write("Idade: ");
            idades[i] = int.Parse(Console.ReadLine());

            Console.Write("Altura (em metros): ");
            alturas[i] = double.Parse(Console.ReadLine());

            // Acumulando valores para os cálculos
            somaIdadeGrupo += idades[i];

            if (sexos[i] == 1) // Homens
            {
                somaIdadeHomens += idades[i];
                qtdHomens++;
            }
            else if (sexos[i] == 0) // Mulheres
            {
                somaAlturaMulheres += alturas[i];
                qtdMulheres++;
            }

            if (idades[i] >= 18 && idades[i] <= 35)
            {
                qtdIdade18_35++;
            }
        }

        // Cálculos finais
        double mediaIdadeGrupo = (double)somaIdadeGrupo / totalPessoas;
        double mediaIdadeHomens = qtdHomens > 0 ? (double)somaIdadeHomens / qtdHomens : 0;
        double mediaAlturaMulheres = qtdMulheres > 0 ? somaAlturaMulheres / qtdMulheres : 0;
        double percentualIdade18_35 = (double)qtdIdade18_35 / totalPessoas * 100;

        // Exibindo os resultados
        Console.WriteLine("\n--- RESULTADOS ---");
        Console.WriteLine($"Média da idade do grupo: {mediaIdadeGrupo:F2} anos");
        Console.WriteLine($"Média da altura das mulheres: {mediaAlturaMulheres:F2} m");
        Console.WriteLine($"Média da idade dos homens: {mediaIdadeHomens:F2} anos");
        Console.WriteLine($"Percentual de pessoas entre 18 e 35 anos: {percentualIdade18_35:F2}%");
    }
}