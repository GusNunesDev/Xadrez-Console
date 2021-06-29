using System;
using xadrez_console;

namespace tabuleiro
{
    class Program
    {
        static void Main(string[] args)
        {

            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.ImprimeirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
