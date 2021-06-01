using System;
using Xadrez.Jogo;
using Xadrez.Tabuleiro;
using Xadrez.Tabuleiro.Exceptions;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var tabuleiro = new TabuleiroXadrez(8, 8);
                tabuleiro.SetPeca(new Torre(Cor.Preta, tabuleiro), new Posicao(0, 0));
                tabuleiro.SetPeca(new Bispo(Cor.Preta, tabuleiro), new Posicao(0, 1));
                tabuleiro.SetPeca(new Cavalo(Cor.Preta, tabuleiro), new Posicao(0, 2));
                tabuleiro.SetPeca(new Rainha(Cor.Preta, tabuleiro), new Posicao(0, 3));
                tabuleiro.SetPeca(new Rei(Cor.Preta, tabuleiro), new Posicao(0, 4));
                tabuleiro.SetPeca(new Bispo(Cor.Preta, tabuleiro), new Posicao(0, 5));

                Tela.ImprimirTabuleiro(tabuleiro);
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
