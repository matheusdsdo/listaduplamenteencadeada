using System;

namespace ListaDuplamenteEncadeada
{
    class Principal
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            lista.adicionar(new Clube("Grêmio","Porto Alegre-RS",6));
            lista.adicionar(new Clube("Internacional", "Porto Alegre-RS", 6));
            lista.adicionar(new Clube("São Paulo", "São Paulo-SP", 6));
            lista.adicionar(new Clube("Flamengo", "Rio de Janeiro-RS", 6));
            lista.adicionar(new Clube("Cruzeiro", "Belo Horizonte-MG", 6));

            lista.listar();

            lista.remover("Internacional");

            lista.listar();
        }
    }
}
