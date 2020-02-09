



using GameTop.Interface;
using GameTOP.lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            iJogador jogador1 = new Jogador("Lucas");
            iJogador jogador2 = new Jogador("Carlos");

            JogoFODA jogo = new JogoFODA(jogador1, jogador2);
            jogo.IniciarJogo();
        }
    }


}
