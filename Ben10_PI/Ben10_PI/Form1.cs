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

namespace Ben10_PI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            
            lstPartidas.Items.Clear();
            string retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] partidas = retorno.Split('\n');
            for (int i = 0; i < partidas.Length; i++)
            {
                lstPartidas.Items.Add(partidas[i]);
            }
            
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            lstJogadores.Items.Clear();
            
            if(lstPartidas.SelectedItem != null)
            {
                string partida = lstPartidas.SelectedItem.ToString();
                string[] itens = partida.Split(',');
                lblIdPartida.Text = itens[0];
                lblNomePartida.Text = itens[1];
                lblIdPartida.Visible = true;
                lblNomePartida.Visible = true;
                lblMostraErro.Visible = false;

                int id = Convert.ToInt32(lblIdPartida.Text);
                string retorno = Jogo.ListarJogadores(id);

                if(retorno.Length > 0)
                {
                    retorno = retorno.Replace("\r", "");
                    retorno = retorno.Substring(0, retorno.Length - 1);
                    string[] jogadores = retorno.Split('\n');
                    for (int i = 0; i < jogadores.Length; i++)
                    {
                        lstJogadores.Items.Add(jogadores[i]);
                    }
                }
                else
                {
                    lstJogadores.Items.Add("Não há jogadores na partida");
                }
            }
            else
            {
                lblIdPartida.Visible = false;
                lblNomePartida.Visible = false;
                lblMostraErro.Visible = true;
                lblMostraErro.Text = "Nenhuma Partida Selecionada";
            }
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.CriarPartida(txtNomePartida.Text, txtSenha.Text);
            char verifica = retorno.First();
            if(verifica == 'E')
            {
                lblMostraErro.Visible = true;
                lblMostraErro.Text = retorno;
            }
            else
            {
                txtNomePartida.Text = "";
                txtSenha.Text = "";
                lblMostraErro.Visible = true;
                lblMostraErro.Text = "Partida criada com Sucesso!";
            }
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (txtIdPartida.Text.Length > 0)
            {
                id = Convert.ToInt32(txtIdPartida.Text);
            }
            string retorno = Jogo.EntrarPartida(id, txtNomeJogador.Text, txtSenhaEntrarPartida.Text);
            char verificaErro = retorno.First();

            if(verificaErro == 'E')
            {
                lblMostraErro.Visible = true;
                lblMostraErro.Text = retorno;
            }
            else
            {
                txtNomeJogador.Text = "";
                txtSenhaEntrarPartida.Text = "";
                txtIdPartida.Text = "";
                lblMostraErro.Visible = true;
                lblMostraErro.Text = "Sucesso ao entrar na partida";

                retorno = retorno.Replace("\r", "");
                string[] infoJogador = retorno.Split(',');
                lblIdJogador.Text = infoJogador[0];
                lblSenhaJogador.Text = infoJogador[1];
                lblIdJogador.Visible = true;
                lblSenhaJogador.Visible = true;

            }
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            Form2 tela2 = new Form2();
            tela2.ShowDialog();
            
        }
    }
}
