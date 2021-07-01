

using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrez
    {

        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            ColocarPecas();
        }

        public void ExecutaMovimento(Posicao origin, Posicao destino)
        {
            Peca p = tab.RetirarPeca(origin);
            p.IncrementarQteMovimentos();
            Peca PecaCapturada = tab.RetirarPeca(destino);
            tab.ColocarPeca(p, destino);
        }

        private void ColocarPecas()
        {
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c', 1).ToPosicao());
        }
    }
}
