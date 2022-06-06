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
using System.Threading;

namespace Ben10
{
    public partial class Lobby : Form
    {
        public string idJogador;
        public string senhaJogador;
        public string nomeJogador;
        public string[] jogadores;
        public int id;
        List<Panel> bodesBaixo;
        List<Panel> bodesCima;
        List<Panel> cartas;
        List<Label> numCartas;
        Estrategia estrategia;
        public int xCarta;
        public int yCarta;
        public int xCartaMesa;
        public int yCartaMesa;
        public int ilhaDefinida;

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
            bodesBaixo = new List<Panel>();
            bodesCima = new List<Panel>();
            ilhaDefinida = 0;
            estrategia = new Estrategia();
            InitializeComponent();
        }
        public string[] verificarMao()
        {
            string retorno = Jogo.VerificarMao(Convert.ToInt32(this.idJogador), this.senhaJogador);
            if(retorno.Length > 0)
            {
                retorno = retorno.Replace("\r", "");
                retorno = retorno.Substring(0, retorno.Length - 1);
                string[] itensString = retorno.Split('\n');
                return itensString;
            }
            return null;
        }
        public string[] listarMesa()
        {
            bodesCima.Clear();
            bodesBaixo.Clear();
            numCartas.Clear();
            cartas.Clear();
            flpCartasMesa.Controls.Clear();
            
            string retorno;
            if (txtRodada.Text == "")
                retorno = Jogo.VerificarMesa(this.id);
            else
                retorno = Jogo.VerificarMesa(this.id, Convert.ToInt32(txtRodada.Text));
            if (retorno.StartsWith("ERRO"))
            {
                MessageBox.Show(retorno);
                return null;
            }
            retorno = retorno.Replace("\r", "");
            retorno = retorno.Replace("\n", ",");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] mesa = retorno.Split(',');
            if(mesa[0] == "")
                lblIlha.Text = "0";
            else
                lblIlha.Text = mesa[0].Replace("I", "");
            List<string> imagem = new List<string>();
            List<int> bodesSizeHeight = new List<int>();
            const int bodesSizeWidth = 23;
            int k = 0;
            for (int i = 2; i < mesa.Length; i+= 2)
            {
                Panel carta = new Panel();
                for (int j = i / 2; j <= i / 2; j++)
                {
                    //Verificação para Atribuir número de Bodes
                    if (Convert.ToInt32(mesa[i]) < 50 && Convert.ToInt32(mesa[i]) % 10 == 0) //Múltiplos de 10 até o número 49
                    {
                        bodesSizeHeight.Add(3 * bodesSizeWidth);
                        Panel bodeCima = new Panel();
                        bodeCima.BackColor = Color.Transparent;
                        bodeCima.Size = new Size(2 * bodesSizeWidth, bodesSizeWidth);
                        bodeCima.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("bode4");
                        bodeCima.Location = new Point(0, 55);
                        bodesCima.Add(bodeCima);
                        carta.Controls.Add(bodesCima[k]);
                        k++;
                    }
                    else if (Convert.ToInt32(mesa[i]) % 5 == 0) //Múltiplos de 5
                        bodesSizeHeight.Add(3 * bodesSizeWidth); //Serão mostrados três bodes
                    else if (Convert.ToInt32(mesa[i]) % 4 == 0) //Múltiplos de 4
                        bodesSizeHeight.Add(2 * bodesSizeWidth); //Serão mostrados dois bodes
                    else
                        bodesSizeHeight.Add(bodesSizeWidth); //Será mostrado um bode
                    //Verificações para Atribuir Layout da Carta
                    if (Convert.ToInt32(mesa[i]) <= 5)
                        imagem.Add("5");
                    else if (Convert.ToInt32(mesa[i]) <= 10)
                        imagem.Add("2");
                    else if (Convert.ToInt32(mesa[i]) <= 15)
                        imagem.Add("10");
                    else if (Convert.ToInt32(mesa[i]) <= 20)
                        imagem.Add("1");
                    else if (Convert.ToInt32(mesa[i]) <= 25)
                        imagem.Add("6");
                    else if (Convert.ToInt32(mesa[i]) <= 30)
                        imagem.Add("3");
                    else if (Convert.ToInt32(mesa[i]) <= 35)
                        imagem.Add("7");
                    else if (Convert.ToInt32(mesa[i]) <= 40)
                        imagem.Add("8");
                    else if (Convert.ToInt32(mesa[i]) <= 45)
                        imagem.Add("4");
                    else
                        imagem.Add("9");
                    Label numCarta = new Label();
                    numCarta.AutoSize = true;
                    numCarta.BackColor = Color.Transparent;
                    numCarta.Font = new Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    numCarta.ForeColor = SystemColors.ControlLightLight;
                    numCarta.Location = new Point(3, 9);
                    numCarta.Size = new Size(13, 13);
                    numCarta.Text = mesa[i];
                    numCartas.Add(numCarta);
                    Panel bodeBaixo = new Panel();
                    bodeBaixo.BackColor = Color.Transparent;
                    bodeBaixo.Size = new Size(bodesSizeHeight[j - 1], bodesSizeWidth);
                    bodeBaixo.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("bode4");
                    bodeBaixo.Location = new Point(0, 77);
                    bodesBaixo.Add(bodeBaixo);
                    carta.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("b" + imagem[j - 1]);
                    carta.Size = new Size(68, 100);
                    carta.Controls.Add(bodesBaixo[j - 1]);
                    carta.Controls.Add(numCartas[j - 1]);
                    cartas.Add(carta);
                    flpCartasMesa.Controls.Add(cartas[j - 1]);
                }
            }
            return mesa;
        }
        public void listarHistorico()
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
        public void listarCartas()
        {
            grpCartas.Visible = false;
            bodesCima.Clear();
            bodesBaixo.Clear();
            numCartas.Clear();
            cartas.Clear();
            grpCartas.Controls.Clear();
            //reseta as posições para os valores iniciais
            this.xCarta = 6;
            this.yCarta = 19;
            string[] itensString = this.verificarMao();
            if(itensString == null)
            {
                return;
            }
            else if (itensString[0].StartsWith("ERRO"))
            {
               MessageBox.Show(itensString[0]);
            }
            else 
            {
                int[] itens = new int[itensString.Length];
                int[] bodesSizeHeight = new int[itens.Length];
                string[] imagem = new string[itens.Length];
                const int bodesSizeWidth = 23;
                int j = 0;
                for (int i = 0; i <= itensString.Length - 1; i++) //apenas para converter o array de string em um array de int
                {
                    Panel carta = new Panel();
                    itens[i] = Convert.ToInt32(itensString[i]);
                    //Verificação para Atribuir número de Bodes
                    if (itens[i] < 50 && itens[i] % 10 == 0) //Múltiplos de 10 até o número 49
                    {
                        bodesSizeHeight[i] = 3 * bodesSizeWidth;
                        Panel bodeCima = new Panel();
                        bodeCima.BackColor = Color.Transparent;
                        bodeCima.Size = new Size(2 * bodesSizeWidth, bodesSizeWidth);
                        bodeCima.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("bode4");
                        bodeCima.Location = new Point(0, 55);
                        bodesCima.Add(bodeCima);
                        carta.Controls.Add(bodesCima[j]);
                        j++;
                    }
                    else if (itens[i] % 5 == 0) //Múltiplos de 5
                        bodesSizeHeight[i] = 3 * bodesSizeWidth; //Serão mostrados três bodes
                    else if (itens[i] % 4 == 0) //Múltiplos de 4
                        bodesSizeHeight[i] = 2 * bodesSizeWidth; //Serão mostrados dois bodes
                    else
                        bodesSizeHeight[i] = bodesSizeWidth; //Será mostrado um bode
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
                    numCarta.Font = new Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    numCarta.ForeColor = SystemColors.ControlLightLight;
                    numCarta.Location = new Point(3, 9);
                    numCarta.Name = "lblCarta" + (i + 1);
                    numCarta.Size = new Size(13, 13);
                    numCarta.Text = itensString[i];
                    numCartas.Add(numCarta);
                    Panel bodeBaixo = new Panel();
                    bodeBaixo.BackColor = Color.Transparent;
                    bodeBaixo.Size = new Size(bodesSizeHeight[i], bodesSizeWidth);
                    bodeBaixo.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("bode4");
                    bodeBaixo.Location = new Point(0, 77);
                    bodesBaixo.Add(bodeBaixo);
                    carta.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("b" + imagem[i]);
                    carta.Size = new Size(68, 100);
                    carta.Name = "panel" + (i + 1);
                    carta.Location = new Point(this.xCarta, this.yCarta);
                    carta.Controls.Add(bodesBaixo[i]);
                    carta.Controls.Add(numCartas[i]);
                    cartas.Add(carta);
                    grpCartas.Controls.Add(cartas[i]);
                    this.xCarta += 74;
                    if (i == 3)
                    {
                        this.xCarta = 6;
                        this.yCarta = 125;
                    }
                }
                Thread.Sleep(800);
                grpCartas.Visible = true;
            }
        }

        public void listarJogadores()
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
        
        private void Lobby_Load(object sender, EventArgs e)
        {
            lblNome.Text = this.nomeJogador;
            lblID.Text = this.idJogador;
            lblSenha.Text = this.senhaJogador;

            for (int i = 0; i < this.jogadores.Length; i++)
            {
                lstJogadores.Items.Add(this.jogadores[i]);
            }
            this.listarHistorico();
            timer1.Enabled = true;
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            this.listarJogadores();
        }
        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.IniciarPartida(Convert.ToInt32(this.idJogador), this.senhaJogador);
            if (retorno.StartsWith("ERRO"))
                MessageBox.Show(retorno);
            else
            {
                MessageBox.Show("Partida iniciada com sucesso!");
                btnIniciarPartida.Enabled = false;
                this.listarHistorico();
                this.listarCartas();
            }
        }
        private void btnMesa_Click(object sender, EventArgs e)
        {
            this.listarMesa();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            string retorno = Jogo.VerificarVez(this.id);
            if(retorno.Contains("E")) {
                timer1.Enabled = true;
                return;
            }
            
            string[] itens = retorno.Split(',');
            if (itens[2] == "1")
                this.listarJogadores();
            
            if (itens[1] == this.idJogador)
            {
                if (retorno.Contains("B"))
                {
                    string[] cartas = this.verificarMao();
                    string[] mesa = this.listarMesa();
                    estrategia.JogarCarta(cartas, this.idJogador, this.senhaJogador, mesa);
                    this.listarCartas();
                }
                else
                {
                    string[] ilhas = Jogo.VerificarIlha(Convert.ToInt32(this.idJogador), this.senhaJogador).Split(',');
                    this.ilhaDefinida = estrategia.DefinirIlha(ilhas, this.idJogador, this.senhaJogador, this.ilhaDefinida, itens[2]);
                }
            }
            this.listarMesa();
            this.listarHistorico();
            timer1.Enabled = true;
        }

        private void Lobby_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            this.listarHistorico();
        }
    }
}