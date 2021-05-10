using System;

namespace atividade_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[15];

            Console.WriteLine("Digite 15 números diferentes em forma crescente");

            for (var i = 0; i < 15; i++)
            {
                Console.WriteLine($"Escreva o {i + 1} número");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(numeros);

            int c = 0;

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
                c++;
            }
        }
    }
}
