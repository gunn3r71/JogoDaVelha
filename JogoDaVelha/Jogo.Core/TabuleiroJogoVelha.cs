using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JogoDaVelha.Jogo.Tabuleiro;

namespace JogoDaVelha.Jogo.Core
{
    public class TabuleiroJogoVelha : Tabuleiro.Tabuleiro
    {
        public TabuleiroJogoVelha() : base(3,3)
        {
            this.ConfiguraTabuleiro();
        }
    }
}
