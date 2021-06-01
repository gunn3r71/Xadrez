using System;
using System.Collections.Generic;
using System.Text;
using Xadrez.Tabuleiro;

namespace Xadrez.Jogo
{
    class Rainha : Peca
    {
        public Rainha(Cor cor, TabuleiroXadrez tabuleiro) : base(cor, tabuleiro)
        {
        }

        public override string ToString()
        {
            return "r";
        }
    }
}
