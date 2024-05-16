using System.Globalization;

namespace ControleEstoque
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        public string Plataforma { get; set; }
        public string Genero { get; set; }
        public string Distribuidora { get; set; }
        public int AnoLancamento { get; set; }

        public Produto(string nome, double preco, string plataforma, string genero, string distribuidora, int anolancamento)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEmEstoque = 0; 
            Plataforma = plataforma;
            Genero = genero;
            Distribuidora = distribuidora;
            AnoLancamento = anolancamento;
        }
    }
}
