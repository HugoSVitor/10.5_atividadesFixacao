using System;

namespace atividade_5
{
    class Program
    {
        static void Main(string[] args)
        {
                 
            for (var n1 = 1; n1 <= 10; n1++)
            {
                for (int n2 = 1; n2 <= 10; n2++)
                {
                    int resultado = n1 * n2;
                    Console.WriteLine($"{n1} x {n2} = {resultado}");
                }
            }
        }
    }
}
