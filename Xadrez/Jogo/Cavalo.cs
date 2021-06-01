using System;
using System.Collections.Generic;
using System.Text;
using Xadrez.Tabuleiro;

namespace Xadrez.Jogo
{
    class Cavalo : Peca
    {
        public Cavalo(Cor cor, TabuleiroXadrez tabuleiro) : base(cor, tabuleiro)
        {
        }

        public override string ToString()
        {
            return "C";
        }
    }
}
