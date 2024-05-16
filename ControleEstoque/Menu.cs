using System;
using System.Globalization;

namespace ControleEstoque
{
    public class Menu()
    {
        public static int OpcoesMenu()
        {
            Console.WriteLine("\nCONTROLE DE ESTOQUE - GAMERANDO\n");
            Console.WriteLine("[1] Novo");
            Console.WriteLine("[2] Listar Produtos");
            Console.WriteLine("[3] Remover Produto");
            Console.WriteLine("[4] Entrada Estoque");
            Console.WriteLine("[5] Saída Estoque");
            Console.WriteLine("[0] Sair\n");

            Console.Write("Escolha uma opção: ");
            int escolha = Convert.ToInt32(Console.ReadLine());

            return escolha;
        }
    }
}
    

     