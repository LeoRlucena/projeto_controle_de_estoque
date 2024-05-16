using System;
using System.Globalization;

namespace ControleEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Estoque estoque = new Estoque();
            Menu menu = new Menu();

            int escolha;
            do 
            {
                escolha = Menu.OpcoesMenu();

                switch (escolha)
                {
                    case 1:
                        Console.Write("\nInforme o nome do Game: ");
                        string nome = Console.ReadLine();
                        Console.Write("\nInforme o preço: ");
                        double preco = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("\nInforme a plataforma: ");
                        string plataforma = Console.ReadLine();
                        Console.Write("\nInforme o Gênero: ");
                        string genero = Console.ReadLine();
                        Console.Write("\nInforme a Distribuidora: ");
                        string distribuidora = Console.ReadLine();
                        Console.Write("\nInforme o ano de lançamento: ");
                        int anolancamento = Convert.ToInt32(Console.ReadLine());
                        Produto novoProduto = new Produto(nome, preco, plataforma, genero, distribuidora, anolancamento);
                        estoque.AdicionarProduto(novoProduto);
                        break;
                    case 2:
                        estoque.ListarProdutos();
                        break;
                    case 3:
                        Console.Write("\nInforme a posição do game a ser removido: ");
                        int posicaoRemover = Convert.ToInt32(Console.ReadLine());
                        estoque.RemoverProduto(posicaoRemover);
                        break;
                    case 4:
                        Console.Write("\nInforme a posição do game: ");
                        int posicaoEntrada = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nInforme a quantidade de Entrada: ");
                        int quantidadeEntrada = Convert.ToInt32(Console.ReadLine());
                        estoque.EntradaEstoque(posicaoEntrada, quantidadeEntrada);
                        break;
                    case 5:
                        Console.Write("\nInforme a posição do game: ");
                        int posicaoSaida = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nInforme a quantidade de Saída: ");
                        int quantidadeSaida = Convert.ToInt32(Console.ReadLine());
                        estoque.SaidaEstoque(posicaoSaida, quantidadeSaida);
                        break;
                    case 0:
                        Console.WriteLine("\nSaindo do programa...");                     
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida. Por favor, escolha uma opção válida.");
                        break;
                }
            } while (escolha != 0);
        }
    }
}
