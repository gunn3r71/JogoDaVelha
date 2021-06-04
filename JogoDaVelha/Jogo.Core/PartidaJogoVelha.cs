using JogoDaVelha.Jogo.Tabuleiro;
using JogoDaVelha.Jogo.Tabuleiro.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Jogo.Core
{
    public class PartidaJogoVelha : Partida
    {
        public TabuleiroJogoVelha Tabuleiro { get; private set; }

        public PartidaJogoVelha(int quantidadeRodadas)
        {
            this.Tabuleiro = new TabuleiroJogoVelha();
            this.PontosPlayerOne = 0;
            this.PontosPlayerTwo = 0;
            this.JogadorAtual = EnumJogador.PlayerOne;
            this.QuantidadeRodadas = quantidadeRodadas;
            this.RodadaAtual = 1;
            this.Finalizada = false;
        }

        public override void AdicionarPonto(EnumJogador jogador)
        {
            if (jogador == EnumJogador.PlayerOne)
                this.PontosPlayerOne++;
            if (jogador == EnumJogador.PlayerTwo)
                this.PontosPlayerTwo++;
        }

        public override void AlternarTurno()
        {
            if (this.JogadorAtual == EnumJogador.PlayerOne)
            {
                this.JogadorUltimoTurno = this.JogadorAtual;
                this.JogadorAtual = EnumJogador.PlayerTwo;
            } else
            {
                this.JogadorUltimoTurno = this.JogadorAtual;
                this.JogadorAtual = EnumJogador.PlayerOne;
            }
        }
    }
}
