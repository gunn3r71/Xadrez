using System;
using Xadrez.Tabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tela.ImprimirTabuleiro(new TabuleiroXadrez(8, 8));
        }
    }
}
