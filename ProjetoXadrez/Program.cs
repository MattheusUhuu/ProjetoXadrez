using System;
using Tabuleiro.xadrez;
using ProjetoXadrez.Tabuleiro;
using xadrez;

namespace Tabuleiro
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
        }
    }
}
