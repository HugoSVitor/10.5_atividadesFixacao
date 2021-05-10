using System;

namespace atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor insira o nome do preduto , a quantidade de produtos e seu preço unitário: ");
            string nomeProduto = Console.ReadLine();
            int quantidadeProduto = int.Parse(Console.ReadLine());
            double precoProduto = double.Parse(Console.ReadLine());

            double precoTotal;
            double precoPagar;

            if (quantidadeProduto <= 5)
            {
                precoTotal = quantidadeProduto * precoProduto;
                precoPagar = precoTotal * 0.98;

                Console.WriteLine($"O preço total a pagar é de {precoPagar}!!");
            }else if (quantidadeProduto <=10)
            {
                precoTotal = quantidadeProduto * precoProduto;
                precoPagar = precoTotal * 0.97;

                Console.WriteLine($"O preço total a pagar é de {precoPagar}!!");
            }else
            {
                precoTotal = quantidadeProduto * precoProduto;
                precoPagar = precoTotal * 0.90;

                Console.WriteLine($"O preço total a pagar é de {precoPagar}!!");
            }

        }
    }
}
