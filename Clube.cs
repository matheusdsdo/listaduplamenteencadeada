using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDuplamenteEncadeada
{
    class Clube
    {
        private string nome;
        private string cidade;
        private double titulos;

        public string Nome { get => nome; set => nome = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public double Titulos { get => titulos; set => titulos = value; }

        public Clube(string nome, string cidade, double titulos)
        {
            this.nome = nome;
            this.cidade = cidade;
            this.titulos = titulos;
        }
    }
}
