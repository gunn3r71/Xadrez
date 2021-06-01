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
            while (true)
            {
                try
                {
        
                    Tela.ImprimirTabuleiro(partida.Tabuleiro);

                    Console.Write("Posição origem, ex(a 2): ");
                    var origem = Console.ReadLine().Split(" ");
                    Console.Write("Posição destino, ex(a 4): ");
                    var destino = Console.ReadLine().Split(" ");

                    partida.ExcecutaMovimento(new PosicaoXadrez(char.Parse(origem[0]),int.Parse(origem[1])), new PosicaoXadrez(char.Parse(destino[0]), int.Parse(destino[1])));
                    Console.Clear();
                }
                catch (TabuleiroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
