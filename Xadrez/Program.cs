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
            var partida = new PartidaXadrez();
            try 
            {
                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tabuleiro);
                    Console.Write("Origem: ");
                    var origem = Tela.LerPosicaoXadrez();
                    Console.Write("Destino: ");
                    var destino = Tela.LerPosicaoXadrez();

                    partida.ExcecutaMovimento(origem,destino);
                }
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
