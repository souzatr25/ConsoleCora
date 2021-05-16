using System;
using GameTop.Lib;
using GameTop;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(new Jogador1(), new Jogador2());

            jogo.IniciarJogo();
        }
    }    

    

}
