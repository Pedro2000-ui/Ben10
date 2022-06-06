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
            multiplos10.Clear();
            multiplos5.Clear();
            multiplos4.Clear();
            multiplos1.Clear();
            for (int i = 0; i < cartas.Length; i++)
            {
                if(Convert.ToInt32(cartas[i]) % 10 == 0 && Convert.ToInt32(cartas[i]) < 50)
                    multiplos10.Add(Convert.ToInt32(cartas[i]));
                
                else if (Convert.ToInt32(cartas[i]) % 5 == 0)
                    multiplos5.Add(Convert.ToInt32(cartas[i]));
                
                else if (Convert.ToInt32(cartas[i]) % 4 == 0)
                    multiplos4.Add(Convert.ToInt32(cartas[i]));
                
                else
                    multiplos1.Add(Convert.ToInt32(cartas[i]));
            }
            
            if(mesa.Length > 1)
            {
                for(int i = 2; i < mesa.Length; i += 2)
                {
                    //Estou em Vantagem
                    foreach (int multiploDe10 in multiplos10)
                        if (multiploDe10 < Convert.ToInt32(mesa[i]))
                        {
                            Jogo.Jogar(Convert.ToInt32(idJogador), senhaJogador, multiploDe10);
                            return;
                        }
                    foreach (int multiploDe5 in multiplos5)
                        if (multiploDe5 < Convert.ToInt32(mesa[i]))
                        {
                            Jogo.Jogar(Convert.ToInt32(idJogador), senhaJogador, multiploDe5);
                            return;
                        }
                    foreach (int multiploDe4 in multiplos4)
                        if (multiploDe4 < Convert.ToInt32(mesa[i]))
                        {
                            Jogo.Jogar(Convert.ToInt32(idJogador), senhaJogador, multiploDe4);
                            return;
                        }
                }
                //Estou em desvantagem
                if (multiplos1.Count > 0)
                    Jogo.Jogar(Convert.ToInt32(idJogador), senhaJogador, multiplos1[multiplos1.Count - 1]);
                else if (multiplos4.Count > 0)
                    Jogo.Jogar(Convert.ToInt32(idJogador), senhaJogador, multiplos4[multiplos4.Count - 1]);
                else if (multiplos5.Count > 0)
                    Jogo.Jogar(Convert.ToInt32(idJogador), senhaJogador, multiplos5[multiplos5.Count - 1]);
                else
                    Jogo.Jogar(Convert.ToInt32(idJogador), senhaJogador, multiplos10[multiplos10.Count - 1]);
            }
            else
                if (multiplos1.Count > 0)
                    Jogo.Jogar(Convert.ToInt32(idJogador), senhaJogador, multiplos1[0]);
                else if (multiplos4.Count > 0)
                    Jogo.Jogar(Convert.ToInt32(idJogador), senhaJogador, multiplos4[0]);
                else if (multiplos5.Count > 0)
                    Jogo.Jogar(Convert.ToInt32(idJogador), senhaJogador, multiplos5[0]);
                else
                    Jogo.Jogar(Convert.ToInt32(idJogador), senhaJogador, multiplos10[0]);
        }
        public int DefinirIlha(string[] ilhas, string idJogador, string senhaJogador, int ilhaDefinida, string rodada)
        {
            int max;
            int min;

            if (Convert.ToInt32(ilhas[0]) > Convert.ToInt32(ilhas[1]))
            {
                max = Convert.ToInt32(ilhas[0]);
                min = Convert.ToInt32(ilhas[1]);
            }
            else
            {
                max = Convert.ToInt32(ilhas[1]);
                min = Convert.ToInt32(ilhas[0]);
            }
            if (rodada == "3" && ilhaDefinida == 0)
                Jogo.DefinirIlha(Convert.ToInt32(idJogador), senhaJogador, max);
            else if (rodada == "4" && ilhaDefinida <= 1)
                Jogo.DefinirIlha(Convert.ToInt32(idJogador), senhaJogador, max);
            else
                Jogo.DefinirIlha(Convert.ToInt32(idJogador), senhaJogador, min);
            ilhaDefinida++;
            return ilhaDefinida;
        }
    }
}
