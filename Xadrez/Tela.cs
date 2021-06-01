using System;
using Xadrez.Tabuleiro;

namespace Xadrez
{
    class Tela
    {
        public static void ImprimirTabuleiro(TabuleiroXadrez tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    Console.Write((tabuleiro.GetPeca(new Posicao(i,j)) != null) ? $"{tabuleiro.GetPeca(new Posicao(i, j))} " : $"- "); ;
                }
                Console.WriteLine();
            }
        }
    }
}
