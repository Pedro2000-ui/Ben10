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
        List<int> multiplos10;
        List<int> multiplos5;
        List<int> multiplos4;
        List<int> multiplos1;

        public Estrategia()
        {
            multiplos10 = new List<int>();
            multiplos5 = new List<int>();
            multiplos4 = new List<int>();
            multiplos1 = new List<int>();
        }

        public void JogarCarta(string[] cartas, string idJogador, string senhaJogador, string[] mesa)
        {
            for(int i = 0; i < cartas.Length; i++)
            {
                if(Convert.ToInt32(cartas[i]) % 10 == 0 && Convert.ToInt32(cartas[i]) < 49)
                    multiplos10.Add(Convert.ToInt32(cartas[i]));
                
                else if (Convert.ToInt32(cartas[i]) % 5 == 0)
                    multiplos5.Add(Convert.ToInt32(cartas[i]));
                
                else if (Convert.ToInt32(cartas[i]) % 4 == 0)
                    multiplos4.Add(Convert.ToInt32(cartas[i]));
                
                else
                    multiplos1.Add(Convert.ToInt32(cartas[i]));
            }
            
            if(mesa != null && mesa.Length > 1)
            {
                for(int i = 2; i < mesa.Length; i += 2)
                {
                    for(int j = 0; j < cartas.Length; j++)
                    {
                        if(multiplos10.Count > 0 && multiplos10[j] < Convert.ToInt32(cartas[i]))
                        {
                            Jogo.Jogar(Convert.ToInt32(idJogador), senhaJogador, multiplos10[j]);
                            break;
                        }
                        else if(multiplos5.Count > 0 && multiplos5[j] < Convert.ToInt32(cartas[i]))
                        {
                            Jogo.Jogar(Convert.ToInt32(idJogador), senhaJogador, multiplos5[j]);
                            break;
                        }
                        else if(multiplos4.Count > 0 && multiplos4[j] < Convert.ToInt32(cartas[i]))
                        {
                            Jogo.Jogar(Convert.ToInt32(idJogador), senhaJogador, multiplos4[j]);
                            break;
                        }
                        else if (multiplos1.Count > 0)
                        {
                            Jogo.Jogar(Convert.ToInt32(idJogador), senhaJogador, multiplos1[j]);
                            break;
                        }
                    }
                }
            }
            else
                Jogo.Jogar(Convert.ToInt32(idJogador), senhaJogador, multiplos1[0]);
        }

        public int DefinirIlha(string[] ilhas, string idJogador, string senhaJogador, int ilhaDefinida)
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
