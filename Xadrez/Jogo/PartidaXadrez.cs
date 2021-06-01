using System;
using System.Collections.Generic;
using System.Text;
using Xadrez.Tabuleiro;

namespace Xadrez.Jogo
{
    class PartidaXadrez
    {
        public TabuleiroXadrez Tabuleiro { get; set; }
        private int _turno;
    
        private Cor _jogadorAtual;

        public PartidaXadrez()
        {
            this.Tabuleiro = new TabuleiroXadrez(8, 8);
            _turno = 1;
            _jogadorAtual = Cor.Branca;
            this.InserirPecasTabuleiro();
        }

        public void ExcecutaMovimento(PosicaoXadrez origem, PosicaoXadrez destino)
        {
            var peca = this.Tabuleiro.RetirarPeca(origem.ConverterPosicao());
            peca.IncrementarMovimentos();

            var pecaCapturada = this.Tabuleiro.RetirarPeca(destino.ConverterPosicao());
            this.Tabuleiro.SetPeca(peca,destino.ConverterPosicao());
        }

        private void InserirPecasTabuleiro()
        {
            this.Tabuleiro.SetPeca(new Torre(Cor.Preta, this.Tabuleiro), new PosicaoXadrez('a', 8).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Bispo(Cor.Preta, this.Tabuleiro), new PosicaoXadrez('b', 8).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Cavalo(Cor.Preta, this.Tabuleiro), new PosicaoXadrez('c', 8).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Rainha(Cor.Preta, this.Tabuleiro), new PosicaoXadrez('d', 8).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Rei(Cor.Preta, this.Tabuleiro), new PosicaoXadrez('e', 8).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Bispo(Cor.Preta, this.Tabuleiro), new PosicaoXadrez('f', 8).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Cavalo(Cor.Preta, this.Tabuleiro), new PosicaoXadrez('g', 8).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Torre(Cor.Preta, this.Tabuleiro), new PosicaoXadrez('h', 8).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Peao(Cor.Preta, this.Tabuleiro), new PosicaoXadrez('a', 7).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Peao(Cor.Preta, this.Tabuleiro), new PosicaoXadrez('b', 7).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Peao(Cor.Preta, this.Tabuleiro), new PosicaoXadrez('c', 7).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Peao(Cor.Preta, this.Tabuleiro), new PosicaoXadrez('d', 7).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Peao(Cor.Preta, this.Tabuleiro), new PosicaoXadrez('e', 7).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Peao(Cor.Preta, this.Tabuleiro), new PosicaoXadrez('f', 7).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Peao(Cor.Preta, this.Tabuleiro), new PosicaoXadrez('g', 7).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Peao(Cor.Preta, this.Tabuleiro), new PosicaoXadrez('h', 7).ConverterPosicao());

            this.Tabuleiro.SetPeca(new Peao(Cor.Branca, this.Tabuleiro), new PosicaoXadrez('a', 2).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Peao(Cor.Branca, this.Tabuleiro), new PosicaoXadrez('b', 2).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Peao(Cor.Branca, this.Tabuleiro), new PosicaoXadrez('c', 2).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Peao(Cor.Branca, this.Tabuleiro), new PosicaoXadrez('d', 2).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Peao(Cor.Branca, this.Tabuleiro), new PosicaoXadrez('e', 2).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Peao(Cor.Branca, this.Tabuleiro), new PosicaoXadrez('f', 2).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Peao(Cor.Branca, this.Tabuleiro), new PosicaoXadrez('g', 2).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Peao(Cor.Branca, this.Tabuleiro), new PosicaoXadrez('h', 2).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Torre(Cor.Branca, this.Tabuleiro), new PosicaoXadrez('a', 1).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Cavalo(Cor.Branca, this.Tabuleiro), new PosicaoXadrez('b', 1).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Bispo(Cor.Branca, this.Tabuleiro), new PosicaoXadrez('c', 1).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Rainha(Cor.Branca, this.Tabuleiro), new PosicaoXadrez('d', 1).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Rei(Cor.Branca, this.Tabuleiro), new PosicaoXadrez('e', 1).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Bispo(Cor.Branca, this.Tabuleiro), new PosicaoXadrez('f', 1).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Cavalo(Cor.Branca, this.Tabuleiro), new PosicaoXadrez('g', 1).ConverterPosicao());
            this.Tabuleiro.SetPeca(new Torre(Cor.Branca, this.Tabuleiro), new PosicaoXadrez('h', 1).ConverterPosicao());

        }
    }
}
