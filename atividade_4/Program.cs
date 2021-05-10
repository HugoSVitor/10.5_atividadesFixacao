using System;

namespace atividade_4
{
    class Program
    {
        static void Main(string[] args)
        { 

           int[] numeros = null;

           int quantidadeNumeros = 10;

           numeros = new int [quantidadeNumeros];

           Console.WriteLine("Insira 10 números diferentes em forma crescente");

            for (var i = 0; i < quantidadeNumeros; i++)
            {
                Console.WriteLine($"Isira o {i + 1} número");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"O menor número que você inseriu foi o {numeros[0]}");

            Console.WriteLine($"O maior número que você inseriu foi o {numeros[9]}");
        }
    }
}

