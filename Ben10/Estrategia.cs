using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodeOfWarServer;

namespace Ben10
{
    public class Estrategia
    {
        public static void JogarCarta(string[] cartas, string idJogador, string senhaJogador)
        {
            Jogo.Jogar(Convert.ToInt32(idJogador), senhaJogador, Convert.ToInt32(cartas[0]));
        }

        public static int DefinirIlha(string[] ilhas, string idJogador, string senhaJogador, int ilhaDefinida)
        {
            if (Convert.ToInt32(ilhas[0]) > Convert.ToInt32(ilhas[1]))
                Jogo.DefinirIlha(Convert.ToInt32(idJogador), senhaJogador, Convert.ToInt32(ilhas[1]));
            else
                Jogo.DefinirIlha(Convert.ToInt32(idJogador), senhaJogador, Convert.ToInt32(ilhas[0]));
            ilhaDefinida++;
            return ilhaDefinida;
        }
    }
}
