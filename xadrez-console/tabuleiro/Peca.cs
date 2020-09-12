using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor cor { get; protected set; }
        public int QtnMovimentos { get; protected set; }
        public tabuleiro tab { get; set; }
    }
}
