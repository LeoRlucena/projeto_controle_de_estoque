using System;
using System.Collections.Generic;
using System.Globalization;

namespace ControleEstoque
{
    class Estoque
    {
        private List<Produto> produtos = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
            Console.WriteLine("\nProduto adicionado!");
        }

        public void ListarProdutos()
        {
            for (int i = 0; i < produtos.Count; i++)
            {
                Console.WriteLine($"\n{i + 1}. {produtos[i].Nome} ({produtos[i].AnoLancamento}) - Plataforma: ({produtos[i].Plataforma}) - Gênero: ({produtos[i].Genero}) - Distribuidora: ({produtos[i].Distribuidora}) (R$ {produtos[i].Preco.ToString("F2", CultureInfo.InvariantCulture)}) - {produtos[i].QuantidadeEmEstoque} no estoque");
            }
            if (produtos.Count == 0)
            {
                Console.WriteLine("\nNenhum item listado!");
            }
        }

        public void RemoverProduto(int posicao)
        {
            if (posicao >= 1 && posicao <= produtos.Count)
            {
                produtos.RemoveAt(posicao - 1);
                Console.WriteLine("\nProduto removido!");
            }
            else
            {
                Console.WriteLine("\nPosição inválida!");
            }
        }

        public void EntradaEstoque(int posicao, int quantidade)
        {
            if (posicao >= 1 && posicao <= produtos.Count)
            {
                produtos[posicao - 1].QuantidadeEmEstoque += quantidade;
                Console.WriteLine("\nEntrada de estoque realizada!");
            }
            else
            {
                Console.WriteLine("\nPosição inválida!");
            }
        }

        public void SaidaEstoque(int posicao, int quantidade)
        {
            if (posicao >= 1 && posicao <= produtos.Count)
            {
                if (quantidade <= produtos[posicao - 1].QuantidadeEmEstoque)
                {
                    produtos[posicao - 1].QuantidadeEmEstoque -= quantidade;
                    Console.WriteLine("\nSaída de estoque realizada!");
                }
                else
                {
                    Console.WriteLine("\nQuantidade solicitada maior do que a disponível no estoque!");
                }
            }
            else
            {
                Console.WriteLine("\nPosição inválida!");
            }
        }
    }
}
