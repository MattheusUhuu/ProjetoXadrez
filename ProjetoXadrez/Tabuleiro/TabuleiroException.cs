using System;

namespace ProjetoXadrez.Tabuleiro
{
    class TabuleiroException : Exception
    {
        public TabuleiroException(string mensagem) : base(mensagem) { }
    }
}
