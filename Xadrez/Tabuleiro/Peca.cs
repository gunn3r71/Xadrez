using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez.Tabuleiro
{
    public class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidadeMovimentos { get; protected set; }
        public TabuleiroXadrez Tabuleiro { get; protected set; }

        public Peca()
        {
        }

        public Peca(Posicao posicao, Cor cor, TabuleiroXadrez tabuleiro)
        {
            this.Posicao = posicao;
            this.Cor = cor;
            this.Tabuleiro = tabuleiro;
            this.QuantidadeMovimentos = 0;
        }
    }
}
