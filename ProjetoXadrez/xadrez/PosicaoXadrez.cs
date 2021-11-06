using Tabuleiro;

namespace xadrez
{
    class PosicaoXadrez
    {

        public char coluna { get; set; }
        public int linha { get; set; }

        //Transforma os valores da matriz nos valores reais de um tabuleiro de xadrez.
        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        //Retorna a converção de um tabuleiro para matriz, para a matriz saber qual a posicao.
        //'a' por padrao do c# tem o valor 1
        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }
        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
