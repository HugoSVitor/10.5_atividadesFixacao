using System;

namespace atividade_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string [10];

            Console.WriteLine("Insira 10 nomes diferentes!");
            
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Insira o {i + 1}º nome: ");
                nomes[i] = Console.ReadLine();
            }
            
            Console.WriteLine("Insira um nome para que eu possa procurar!");
            string procurar = Console.ReadLine();
            
            if (procurar = nomes[i])
            {
                Console.WriteLine("ACHEI!");
            }else
            {
                
            }

        }
    }
}
