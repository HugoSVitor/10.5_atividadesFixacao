using System;

namespace atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor insira o ano de seu nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            int idade = DateTime.Now.Year - anoNascimento;
            
            if (idade >= 16)
            {
                Console.WriteLine($"Parabéns, você possui {idade} anos, o suficiente para votar!!");
            }else
            {
                Console.WriteLine("Lamento mas você não possui a idade suficiente para votar!");
            }
        }
    }
}
