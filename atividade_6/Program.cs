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

            foreach (string item in nomes)
            {
                if (item == procurar)
                {
                    Console.WriteLine("Achei! kk");
                }else
                {
                    Console.WriteLine("Num achei não parça! ;-;");
                }
                
            }
        }
    }
}
