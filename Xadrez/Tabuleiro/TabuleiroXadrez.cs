using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez.Tabuleiro
{
    public class TabuleiroXadrez
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public TabuleiroXadrez()
        {
        }

        public TabuleiroXadrez(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca GetPeca(int linha, int coluna)
        {
            return pecas[linha,coluna];
        }
    }
}
