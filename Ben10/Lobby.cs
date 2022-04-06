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
        List<Panel> cartas;
        List<Label> numCartas;
        public int xCarta;
        public int yCarta;
       
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
            cartas = new List<Panel>();
            numCartas = new List<Label>();
            this.xCarta = 6;
            this.yCarta = 29;
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
            if (retorno.Contains("ERRO"))
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

            for (int i = 0; i < historico.Length; i++)
            {
                lstHistorico.Items.Add(historico[i]);
            }
        }

        private void btnCartas_Click(object sender, EventArgs e)
        {
            numCartas.Clear();
            cartas.Clear();
            string retorno = Jogo.VerificarMao(Convert.ToInt32(this.idJogador), this.senhaJogador);
            if (retorno.Contains("ERRO"))
            {
                MessageBox.Show(retorno, "Para verificar a mão é necessário iniciar a partida!!!");
                return;
            }
            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] itensString = retorno.Split('\n');
            int[] itens = new int[itensString.Length];
            int[] bodesSizeHeigth = new int[itens.Length];
            string[] imagem = new string[itens.Length];
            const int bodesSizeWidth = 28;
            for (int i = 0; i <= itensString.Length - 1; i++) //apenas para converter o array de string em um array de int
            {
                itens[i] = Convert.ToInt32(itensString[i]);
                //Verificação para Atribuir número de Bodes
                if (itens[i] < 50 && itens[i] % 10 == 0) //Múltiplos de 10 até o número 49
                    bodesSizeHeigth[i] = 5 * bodesSizeWidth; //Serão mostrados cinco Bodes
                else if (itens[i] % 5 == 0) //Múltiplos de 5
                    bodesSizeHeigth[i] = 3 * bodesSizeWidth; //Serão mostrados três bodes
                else if (itens[i] % 4 == 0) //Múltiplos de 4
                    bodesSizeHeigth[i] = 2 * bodesSizeWidth; //Serão mostrados dois bodes
                else
                    bodesSizeHeigth[i] = 28; //Será mostrado um bode
                //Verificações para Atribuir Layout da Carta
                if (itens[i] <= 5)
                    imagem[i] = "5";
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
                
                Label numCarta = new Label();
                numCarta.AutoSize = true;
                numCarta.BackColor = Color.Transparent;
                numCarta.Font = new Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                numCarta.ForeColor = SystemColors.ControlLightLight;
                numCarta.Location = new Point(13, 11);
                numCarta.Name = "lblCarta" + (i + 1);
                numCarta.Size = new Size(23, 16);
                numCarta.TabIndex = i + 1;
                numCarta.Text = itensString[i];
                numCartas.Add(numCarta);
                Panel carta = new Panel();
                carta.Controls.Add(numCartas[i]);
                carta.Location = new Point(this.xCarta, this.yCarta);
                carta.Name = "panel" + (i + 1);
                carta.Size = new Size(105, 144);
                carta.TabIndex = i + 1;
                carta.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("b" + imagem[i]);
                cartas.Add(carta);
                grpCartas.Controls.Add(cartas[i]);
                if (i == 3) //Se já tiverem 4 cartas criadas
                {
                    this.yCarta = 203;
                    this.xCarta = 6;
                }
                else 
                    this.xCarta += 111;
            }
            //reseta as posições para os valores iniciais
            this.xCarta = 6; 
            this.yCarta = 29;
           
        }



        private void btnVez_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.VerificarVez(this.id);
            lstVez.Items.Clear();
            if (retorno.Contains("ERRO"))
            {
                MessageBox.Show(retorno);
            }
            lstVez.Items.Add(retorno);
            
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            if (txtJogarCarta.Text == "")
            {
                MessageBox.Show("Insira o Número da Carta!");
            }
            else
            {
                string retorno = Jogo.Jogar(Convert.ToInt32(this.idJogador), this.senhaJogador, Convert.ToInt32(txtJogarCarta.Text));
                if (retorno.Contains("ERRO"))
                {
                    MessageBox.Show(retorno);
                }
                MessageBox.Show("Carta Jogada com sucesso!");
                txtJogarCarta.Text = "";
            }
        }

        private void btnVerificaIlha_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.VerificarIlha(Convert.ToInt32(this.idJogador), this.senhaJogador);
            lstVerificarIlha.Items.Clear();
            if (retorno.Contains("ERRO"))
            {
                MessageBox.Show(retorno);
            }
            lstVerificarIlha.Items.Add(retorno);
            
        }

        private void btnIlha_Click(object sender, EventArgs e)
        {
            if (txtIlha.Text == "")
            {
                MessageBox.Show("Insira o valor da ilha!");
            }
            else
            {
                string retorno = Jogo.DefinirIlha(Convert.ToInt32(this.idJogador), this.senhaJogador, Convert.ToInt32(txtIlha.Text));
                if (retorno.Contains("ERRO"))
                {
                    MessageBox.Show(retorno);
                }
                txtIlha.Text = "";
            }
            
            
        }
    }
}
