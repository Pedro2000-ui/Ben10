using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BodeOfWarServer;

namespace Ben10
{
    public partial class Lobby : Form
    {
        public string idJogador;
        public string senhaJogador;
        public string nomeJogador;
        public string[] jogadores;
        public int id;
        string pasta_aplicacao = "";
        public Lobby(string retorno, string nome, string jogadores, int id)
        {
            string[] itens = retorno.Split(',');
            this.idJogador = itens[0];
            this.senhaJogador = itens[1];
            this.nomeJogador = nome;
            this.id = id;
            jogadores = jogadores.Replace("\r", "");
            jogadores = jogadores.Replace(',', ' ');
            jogadores = jogadores.Substring(0, jogadores.Length - 1);
            this.jogadores = jogadores.Split('\n');

            InitializeComponent();
        }

        private void Lobby_Load(object sender, EventArgs e)
        {
            lblNome.Text = this.nomeJogador;
            lblID.Text = this.idJogador;
            lblSenha.Text = this.senhaJogador;

            for (int i = 0; i < this.jogadores.Length; i++)
            {
                lstJogadores.Items.Add(this.jogadores[i]);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string jogadores = Jogo.ListarJogadores(this.id);
            jogadores = jogadores.Replace("\r", "");
            jogadores = jogadores.Replace(',', ' ');
            jogadores = jogadores.Substring(0, jogadores.Length - 1);
            this.jogadores = jogadores.Split('\n');
            

            lstJogadores.Items.Clear();
            for (int i = 0; i < this.jogadores.Length; i++)
            {
                lstJogadores.Items.Add(this.jogadores[i]);
            }
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.IniciarPartida(Convert.ToInt32(this.idJogador), this.senhaJogador);
            if(retorno.Contains("ERRO"))
                MessageBox.Show(retorno);
            else
            {
                MessageBox.Show("Partida iniciada com sucesso!");
                btnIniciarPartida.Enabled = false;
            }           
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            lstHistorico.Items.Clear();

            string retorno = Jogo.ExibirNarracao(this.id);
            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] historico = retorno.Split('\n');

            for(int i = 0; i <historico.Length; i++)
            {
                lstHistorico.Items.Add(historico[i]);
            }
        }

        private void btnCartas_Click(object sender, EventArgs e)
        {
            
            string retorno = Jogo.VerificarMao(Convert.ToInt32(this.idJogador), this.senhaJogador);
            txtTest.Text = retorno;
            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] itensString = retorno.Split('\n');
            int[] itens = new int[itensString.Length];
            string[] imagem = new string [itens.Length];

            for (int i = 0; i <= itensString.Length - 1; i++) //apenas para converter o array de string em um array de int
            {
                itens[i] = Convert.ToInt32(itensString[i]);

                if (itens[i] <= 5)
                {
                    imagem[i] = "5";
                    //if(itens[i] == 4)
                }
                else if (itens[i] <= 10)
                    imagem[i] = "2";
                
                else if (itens[i] <= 15)
                    imagem[i] = "10";
                else if (itens[i] <= 20)
                    imagem[i] = "1";
                else if (itens[i] <= 25)
                    imagem[i] = "6";
                else if (itens[i] <= 30)
                    imagem[i] = "3";
                else if (itens[i] <= 35)
                    imagem[i] = "7";
                else if (itens[i] <= 40)
                    imagem[i] = "8";
                else if (itens[i] <= 45)
                    imagem[i] = "4";
                else
                    imagem[i] = "9";
            }

            lblCarta1.Text = itensString[0];
            lblCarta2.Text = itensString[1];
            lblCarta3.Text = itensString[2]; 
            lblCarta4.Text = itensString[3];
            lblCarta5.Text = itensString[4];
            lblCarta6.Text = itensString[5];
            lblCarta7.Text = itensString[6];
            lblCarta8.Text = itensString[7];
            panel1.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("b" + imagem[0]);
            //panelBode1.Size = new Size(10, 25);
            panel2.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("b" + imagem[1]);
            panel3.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("b" + imagem[2]);
            panel4.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("b" + imagem[3]);
            panel5.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("b" + imagem[4]);
            panel6.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("b" + imagem[5]);
            panel7.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("b" + imagem[6]);
            panel8.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("b" + imagem[7]);
        }

        private void lblCarta1_Click(object sender, EventArgs e)
        {

        }
    }
}
