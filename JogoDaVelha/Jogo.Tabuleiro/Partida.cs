using JogoDaVelha.Jogo.Tabuleiro.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Jogo.Tabuleiro
{
    public abstract class Partida
    {
        public int PontosPlayerOne { get; protected set; }
        public int PontosPlayerTwo { get; protected set; }
        public int QuantidadeRodadas { get; set; }
        public int RodadaAtual { get; protected set; }
        public EnumJogador JogadorAtual { get; protected set; }
        public EnumJogador JogadorUltimoTurno { get; protected set; }
        public bool Finalizada { get; protected set; }

        public abstract void AdicionarPonto(EnumJogador jogador);
        public abstract void AlternarTurno();

        public string ExibirGanhador()
        {
            var ganhador = (PontosPlayerOne > PontosPlayerTwo) ? EnumJogador.PlayerOne : EnumJogador.PlayerTwo;

            return $"Parabés jogador {ganhador}, você ganhou!!!";
        }
    }
}
