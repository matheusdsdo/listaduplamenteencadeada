using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDuplamenteEncadeada
{
    class Elemento
    {
        private Clube clube;
        private Elemento proximo;
        private Elemento anterior;

        public Elemento(Clube clube)
        {
            this.clube = clube;
        }

        public Clube GetClube()
        {
            return this.clube;
        }

        public Elemento GetProximo()
        {
            return this.proximo;
        }

        public void SetProximo(Elemento elemento)
        {
            this.proximo = elemento;
        }

        public Elemento GetAnterior()
        {
            return this.anterior;
        }

        public void setAnterior(Elemento elemento)
        {
            this.anterior = elemento;
        }
    }
}
