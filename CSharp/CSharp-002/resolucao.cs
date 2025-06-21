// Exercício 1
using System;

class Program {
    static void Main() {
        int[] numeros = new int[10];
        int somaNegativos = 0;
        int countNegativos = 0;

        for (int i = 0; i < 10; i++) {
            Console.WriteLine("Digite um número:");
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] < 0) {
                Console.WriteLine("Valor negativo: " + numeros[i]);
                somaNegativos += numeros[i];
                countNegativos++;
            }
        }

        double mediaNegativos = countNegativos > 0 ? (double)somaNegativos / countNegativos : 0;
        Console.WriteLine($"Média dos valores negativos: {mediaNegativos:F2}");
    }
}

// Exercício 2
using System;

class Program {
    static void Main() {
        double[] numeros = new double[10];
        double[] quadrados = new double[10];

        for (int i = 0; i < 10; i++) {
            Console.WriteLine("Digite um número real:");
            numeros[i] = double.Parse(Console.ReadLine());
            quadrados[i] = numeros[i] * numeros[i];
        }

        Console.WriteLine("Conjunto original:");
        foreach (var numero in numeros) {
            Console.WriteLine(numero);
        }

        Console.WriteLine("Quadrados dos números:");
        foreach (var quadrado in quadrados) {
            Console.WriteLine(quadrado);
        }
    }
}

// Exercício 3
using System;

class Program {
    static void Main() {
        int[] arr = new int[8];
        Console.WriteLine("Digite os 8 valores do array:");

        for (int i = 0; i < 8; i++) {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite o valor de X (posição inicial):");
        int X = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de Y (posição final):");
        int Y = int.Parse(Console.ReadLine());

        Console.WriteLine($"Soma dos valores em X ({X}) e Y ({Y}): {arr[X] + arr[Y]}");
    }
}

// Exercício 4
using System;

class Program {
    static void Main() {
        int[] valores = new int[10];
        Console.WriteLine("Digite 10 valores inteiros:");

        for (int i = 0; i < 10; i++) {
            valores[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Valores na ordem inversa:");
        for (int i = 9; i >= 0; i--) {
            Console.WriteLine(valores[i]);
        }
    }
}

// Exercício 5
using System;

class Program {
    static void Main() {
        double[] notas = new double[15];
        double soma = 0;
        int abaixoMedia = 0;

        Console.WriteLine("Digite as notas dos 15 alunos:");

        for (int i = 0; i < 15; i++) {
            notas[i] = double.Parse(Console.ReadLine());
            soma += notas[i];
        }

        double media = soma / 15;
        Console.WriteLine($"Média geral: {media:F2}");

        foreach (var nota in notas) {
            if (nota < media) {
                abaixoMedia++;
            }
        }

        Console.WriteLine($"Alunos abaixo da média: {abaixoMedia}");
    }
}

// Exercício 6
using System;

class Program {
    static void Main() {
        int[] arr = new int[10];
        bool encontrados = false;

        Console.WriteLine("Digite 10 números:");

        for (int i = 0; i < 10; i++) {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++) {
            for (int j = i + 1; j < 10; j++) {
                if (arr[i] == arr[j]) {
                    Console.WriteLine($"Valor duplicado encontrado: {arr[i]}");
                    encontrados = true;
                }
            }
        }

        if (!encontrados) {
            Console.WriteLine("Nenhum valor duplicado encontrado.");
        }
    }
}

// Exercício 7
using System;

class Program {
    static void Main() {
        int[] arr = new int[10];
        Console.WriteLine("Digite 10 números:");

        for (int i = 0; i < 10; i++) {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++) {
            if (arr[i] < 0) {
                arr[i] = 0;
            }
        }

        Console.WriteLine("Array após a alteração:");
        foreach (var valor in arr) {
            Console.WriteLine(valor);
        }
    }
}

// Exercício 8
using System;

class Program {
    static void Main() {
        int[] arr = new int[10];
        int somaPares = 0;

        Console.WriteLine("Digite 10 números maiores que zero:");

        for (int i = 0; i < 10; i++) {
            arr[i] = int.Parse(Console.ReadLine());
            if (arr[i] % 2 == 0) {
                somaPares += arr[i];
            }
        }

        Console.WriteLine($"Soma dos números pares: {somaPares}");
    }
}

// Exercício 9
using System;

class Program {
    static void Main() {
        int[] arr = new int[10];
        int somaImpares = 0;
        int countImpares = 0;

        Console.WriteLine("Digite 10 números maiores que zero:");

        for (int i = 0; i < 10; i++) {
            arr[i] = int.Parse(Console.ReadLine());
            if (arr[i] % 2 != 0) {
                somaImpares += arr[i];
                countImpares++;
            }
        }

        double mediaImpares = countImpares > 0 ? (double)somaImpares / countImpares : 0;
        Console.WriteLine($"Média dos números ímpares: {mediaImpares:F2}");
    }
}

// Exercício 10
using System;

class Program {
    static void Main() {
        int[] arr = new int[10];
        Console.WriteLine("Digite 10 números maiores que zero:");

        for (int i = 0; i < 10; i++) {
            arr[i] = int.Parse(Console.ReadLine());

            if (arr[i] < 0) {
                arr[i] = 99;
            } else if (arr[i] % 2 == 0) {
                arr[i] = 33;
            }
        }

        Console.WriteLine("Array modificado:");
        foreach (var valor in arr) {
            Console.WriteLine(valor);
        }
    }
}