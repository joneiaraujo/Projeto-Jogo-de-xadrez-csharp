using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtnMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            QtnMovimentos = 0;

        }

        
        public void incrementaQtdMovimento()
        {
            QtnMovimentos++;
        }
        public abstract bool[,] movimentosPossiveis();
    }
}
