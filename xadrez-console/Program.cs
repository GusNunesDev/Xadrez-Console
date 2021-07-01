using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.ImprimeirTabuleiro(partida.tab);

                    Console.Write("Origem: ");                    
                    Posicao origem = Tela.lerPosicaoXadrez().ToPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().ToPosicao();

                    partida.ExecutaMovimento(origem, destino);
                }

                Tela.ImprimeirTabuleiro(partida.tab);
            }

            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
