using System;
using Xadrez.Tabuleiro;

namespace Xadrez
{
    class Tela
    {
        public static void ImprimirTabuleiro(TabuleiroXadrez tabuleiro)
        {
            int marcacaoTabuleiro = 8;
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                Console.Write($"{marcacaoTabuleiro--} ");
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    Peca peca = tabuleiro.GetPeca(new Posicao(i, j));
                    if (peca != null)
                    {
                        ImprimirPeca(peca);
                    } else
                    {
                        Console.Write(" -");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("   a b c d e f g h");
        }

        public static void ImprimirPeca(Peca peca)
        {
            if (peca.Cor == Cor.Branca)
            {
                Console.Write($" {peca}");
            } else
            {
                var aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($" {peca}");
                Console.ForegroundColor = aux;
            }
        }
    }
}
