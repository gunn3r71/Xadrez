using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez.Tabuleiro
{
    public class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao()
        {
        }

        public Posicao(int linha, int coluna)
        {
            this.Linha = linha;
            this.Coluna = coluna;
        }

        public override string ToString()
        {
            return $"Posição: {Linha}, {Coluna}";
        }
    }
}
