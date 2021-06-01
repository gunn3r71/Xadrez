using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez.Tabuleiro
{
    public abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidadeMovimentos { get; protected set; }
        public TabuleiroXadrez Tabuleiro { get; protected set; }

        public Peca(Cor cor, TabuleiroXadrez tabuleiro)
        {
            this.Posicao = null;
            this.Cor = cor;
            this.Tabuleiro = tabuleiro;
            this.QuantidadeMovimentos = 0;
        }

        public void IncrementarMovimentos()
        {
            this.QuantidadeMovimentos++;
        }
    }
}
