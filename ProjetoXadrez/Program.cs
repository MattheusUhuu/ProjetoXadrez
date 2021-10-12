using ProjetoXadrez.Tabuleiro;
using System;

namespace ProjetoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;

            P = new Posicao(3, 4);

            Console.WriteLine("Posiçao:" + P);
        }
    }
}
