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
            
            //pasta_aplicacao = Application.StartupPath + @"\";
            
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
            retorno = retorno.Replace("\r", "");
            string[] itensString = retorno.Split('\n');
            int[] itens = new int[itensString.Length];
            string imagem;

            for(int i = 0; i < itensString.Length; i++) //apenas para converter o array de string em um array de int
            {
                itens[i] = Convert.ToInt32(itensString[i]);
            }

            foreach(int item in itens)
            {
                if (item <= 5)
                    imagem = "5";
                else if (item <= 10)
                    imagem = "2";
                else if (item <= 15)
                    imagem = "10";
                else if (item <= 20)
                    imagem = "1";
                else if (item <= 25)
                    imagem = "6";
                else if (item <= 30) ;
            
            }
            //string a = "b7";
            //panel1.BackgroundImage = Image.FromFile(this.pasta_aplicacao + @"imagens\" + a + ".png");
            
            
            panel1.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("b6");
            panel3.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("b8");
            panel4.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("b9");
        }
    }
}
