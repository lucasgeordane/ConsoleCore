

using GameTop.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly iJogador _Jogador1;
        private readonly iJogador _Jogador2;

        public JogoFODA(iJogador jogador1, iJogador jogador2)
        {
            this._Jogador1 = jogador1;
            this._Jogador2 = jogador2;
        }
        public void IniciarJogo()
        {

            System.Console.Write(_Jogador1.Corre());
            System.Console.Write(_Jogador1.Passa());
            System.Console.Write(_Jogador1.Chuta());

            System.Console.Write(_Jogador2.Corre());
            System.Console.Write(_Jogador2.Passa());
            System.Console.Write(_Jogador2.Chuta());


        }
    }


}