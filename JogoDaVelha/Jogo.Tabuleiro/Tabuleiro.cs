using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Jogo.Tabuleiro
{
    public abstract class Tabuleiro
    {
        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
        }

        public int Linhas { get; private set; }
        public int Colunas { get; private set; }
        public string[,] Tab { get; protected set; }
    
        public void ConfiguraTabuleiro()
        {
            this.Tab = new string[this.Linhas,this.Colunas];
        }
    }
}
