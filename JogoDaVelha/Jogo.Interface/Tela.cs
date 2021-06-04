using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Jogo.Interface
{
    public static class Tela
    {
        public static void Exibir(Tabuleiro.Tabuleiro tabuleiro)
        {
            for (int linha = 0; linha < tabuleiro.Linhas; linha++)
            {
                Console.Write($"{linha} ");
                for (int coluna = 0; coluna < tabuleiro.Colunas; coluna++)
                {
                    if (coluna == 1)
                        Console.Write(" |");
                    if (coluna == 2)
                        Console.Write("| ");
                    Console.Write((tabuleiro.Tab[linha,coluna] != null) ? tabuleiro.Tab[linha, coluna] : "-");
                }
                Console.WriteLine();
            }
            Console.WriteLine("  0  1  2");
        }
    }
}
