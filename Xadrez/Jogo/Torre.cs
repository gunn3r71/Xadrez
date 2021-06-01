using System;
using System.Collections.Generic;
using System.Text;
using Xadrez.Tabuleiro;

namespace Xadrez.Jogo
{
    class Torre : Peca
    {
        public Torre(Cor cor, TabuleiroXadrez tabuleiro) : base(cor, tabuleiro)
        {
        }

        public override string ToString()
        {
            return "T";
        }

    }
}
