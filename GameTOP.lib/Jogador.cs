using GameTop.Interface;

namespace GameTOP.lib
{
    public class Jogador : iJogador
    {
        public string _nome { get; set; }

        public Jogador(string nome)
        {
            this._nome = nome;
        }
        public string Corre()
        {
            return $"{_nome} está Correndo \n";
        }

        public string Passa()
        {
            return $"{_nome} está passando \n";
        }

        public string Chuta()
        {
            return $"{_nome} está Chutando \n";
        }
    }
}