using System;

namespace atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual combústivel você deseja? (A = alcóol G = gasolina)");
            string combustivel = Console.ReadLine().ToLower();

            switch (combustivel)
            {
                case "a":
                Console.WriteLine("Quantos litros de alcóol você deseja?");
                int litroA = int.Parse(Console.ReadLine());
       
                 if (litroA <= 20)
                {
                    double precoLitrosA = 4.90 * litroA;

                    double precoFinalA = precoLitrosA * 0.97;

                    Console.WriteLine($"O preço a pagar é de {precoFinalA}!");
                }else
                {
                    double precoLitrosA = 4.90 * litroA;

                    double precoFinalA = precoLitrosA * 0.95;

                    Console.WriteLine($"O preço a pagar é de {precoFinalA}!");
                }

                    break;
                case "g":
                Console.WriteLine("Quantos litros de alcóol você deseja?");
                int litroG = int.Parse(Console.ReadLine());

                if (litroG <= 20)
                {
                    double precoLitrosG = 5.30 * litroG;

                    double precoFinalG = precoLitrosG * 0.96;

                    Console.WriteLine($"O preço a pagar é de {precoFinalG}!");
                }else
                {
                    double precoLitrosG = 5.30 * litroG;

                    double precoFinalG = precoLitrosG * 0.94;

                    Console.WriteLine($"O preço a pagar é de {precoFinalG}!");
                }
                
                    break;
                default:
                Console.WriteLine("Essa não é uma opção válida!!!");
                    break;
            }
            




        }
    }
}
