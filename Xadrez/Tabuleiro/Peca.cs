﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez.Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidadeMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca()
        {
        }

        public Peca(Posicao posicao, Cor cor,Tabuleiro tabuleiro)
        {
            this.Posicao = posicao;
            this.Cor = cor;
            this.Tabuleiro = tabuleiro;
            this.QuantidadeMovimentos = 0;
        }
    }
}
