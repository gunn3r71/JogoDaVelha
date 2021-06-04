using JogoDaVelha.Jogo.Core;
using JogoDaVelha.Jogo.Interface;
using System;

namespace JogoDaVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            var partida = new PartidaJogoVelha(3);
            while (!partida.Finalizada)
            {
                Console.Clear();
                Tela.Exibir(partida.Tabuleiro);

                Console.WriteLine($"vez de jogador: {partida.JogadorAtual}");
                partida.AlternarTurno();

                Console.ReadLine();
            }
        }
    }
}
