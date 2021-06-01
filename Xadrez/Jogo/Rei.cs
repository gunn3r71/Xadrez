using System;
using System.Collections.Generic;
using System.Text;
using Xadrez.Tabuleiro;

namespace Xadrez.Jogo
{
    public class Rei : Peca
    {
        public Rei(Cor cor, TabuleiroXadrez tabuleiro) : base(cor,tabuleiro)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
