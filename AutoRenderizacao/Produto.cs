using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRenderizacao
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set;}

        public int Quantidade { get; set; }
        public string Descricao { get; set; }

        public Produto()
        {}

        public Produto(string nome, double preco, int quantidade, string descricao)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            Descricao = descricao;
        }

        public double calcularEstoque()
        {
            return this.Preco * this.Quantidade;
        }
    }
}
