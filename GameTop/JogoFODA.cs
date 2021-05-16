using GameTop.Interface;

namespace GameTop
{
    public class JogoFODA
    {
        public readonly iJogador _jogador1;

        public readonly iJogador _jogador2;
        public JogoFODA(iJogador jogador1, iJogador jogador2)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }

        public void IniciarJogo()
        {
            _jogador1.Corre();
            _jogador1.Chuta();
            _jogador1.Passe();        

            _jogador2.Corre();
            _jogador2.Chuta();
            _jogador2.Passe();        
        }

    }
}