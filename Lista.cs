using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDuplamenteEncadeada
{
    class Lista
    {
        private Elemento inicio;
        
        public void adicionar(Clube clube)
        {
            if (this.inicio == null)
            {
                this.inicio = new Elemento(clube);
            } else
            {
                Elemento elemento = this.inicio;
                while(elemento.GetProximo() != null)
                {
                    elemento = elemento.GetProximo();
                }
                elemento.SetProximo(new Elemento(clube));
                elemento.GetProximo().setAnterior(elemento);
            }
        }

        public void listar()
        {
            Elemento elemento = this.inicio;
            Console.WriteLine(elemento.GetClube().Nome);
            while(elemento.GetProximo() != null)
            {
                elemento = elemento.GetProximo();
                Console.WriteLine(elemento.GetClube().Nome);
            }
            while(elemento.GetAnterior() != null)
            {
                elemento = elemento.GetAnterior();
                Console.WriteLine(elemento.GetClube().Nome);
            }
        }

        public void remover(string nome)
        {
            Elemento elemento = this.inicio;
            if (elemento.GetClube().Nome.Equals(nome))
            {
                this.inicio = elemento.GetProximo();
                this.inicio.setAnterior(null);
            } else
            {
                while (elemento != null)
                {
                    if (elemento.GetClube().Nome.Equals(nome))
                    {
                        if (elemento.GetProximo() != null)
                        {
                            elemento.GetAnterior().SetProximo(elemento.GetProximo());
                            elemento.GetProximo().setAnterior(elemento.GetAnterior());
                        } else
                        {
                            elemento.GetAnterior().SetProximo(null);
                        }
                    }
                    elemento = elemento.GetProximo();
                }
            }
            Console.WriteLine("Clube removido: "+nome);
        }
    }
}
