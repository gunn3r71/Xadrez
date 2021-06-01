using System;
using System.Collections.Generic;
using System.Text;
using Xadrez.Tabuleiro.Exceptions;

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

        public Peca GetPeca(Posicao posicao)
        {
            return pecas[posicao.Linha,posicao.Coluna];
        }

        public void SetPeca(Peca peca, Posicao posicao)
        {
            if (ExistePeca(posicao))
                throw new TabuleiroException("Já existe uma peça nessa posição");
            pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.Posicao = posicao;
        }

        public Peca RetirarPeca(Posicao posicao)
        {
            if (GetPeca(posicao) == null)
                return null;
            var aux = GetPeca(posicao);
            aux.Posicao = null;
            pecas[posicao.Linha, posicao.Coluna] = null;

            return aux;
        }

        public bool ExistePeca(Posicao posicao)
        {
            this.ValidaPosicao(posicao);
            return  GetPeca(posicao) != null;
        }

        public bool PosicaoValida(Posicao posicao)
        {
            if (posicao.Linha < 0 || posicao.Linha > this.Linhas || posicao.Coluna > this.Colunas)
                return false;
            return true;
        }

        public void ValidaPosicao(Posicao posicao)
        {
            if (!this.PosicaoValida(posicao))
                throw new TabuleiroException("Posição escolhida é inválida");
        }
    }
}
