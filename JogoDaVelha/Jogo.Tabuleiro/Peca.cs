using JogoDaVelha.Jogo.Tabuleiro.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Jogo.Tabuleiro
{
    public abstract class Peca
    {
        public EnumCor Cor { get; set; }
        public Posicao Posicao { get; set; }
    }
}
