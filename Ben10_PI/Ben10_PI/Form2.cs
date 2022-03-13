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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            int idJogador = 0;
            if (txtIdJogador.Text.Length > 0)
            {
                idJogador = Convert.ToInt32(txtIdJogador.Text);
            }
            
            string retorno = Jogo.IniciarPartida(idJogador, txtSenhaJogador.Text);
            char verificaErro = retorno.First();

            if(verificaErro == 'E')
            {
                lblFeedBack.Visible = true;
                lblFeedBack.Text = retorno;
                return;
            }
            lblFeedBack.Visible = true;
            lblFeedBack.Text = "Partida Iniciada com Sucesso!";
        }

        private void btnExibirHistorico_Click(object sender, EventArgs e)
        {
            lstHistorico.Items.Clear();
            int idPartida = 0;
            if (txtIdPartida.Text.Length > 0) { 
                idPartida = Convert.ToInt32(txtIdPartida.Text);
            }
            string retorno = Jogo.ExibirNarracao(idPartida);
            char verificaErro = retorno.First();
            if (verificaErro == 'E')
            {
                lblFeedBack.Visible = true;
                lblFeedBack.Text = retorno;
                return;
            }
            lblFeedBack.Visible = false;
            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] infoHistorico = retorno.Split('\n');

            for (int i = 0; i < infoHistorico.Length; i++)
            {
                lstHistorico.Items.Add(infoHistorico[i]);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerificaVez_Click(object sender, EventArgs e)
        {
            lstVerificaVez.Items.Clear();
            int idPartida = 0;
            if (txtIdPartida.Text.Length > 0)
            {
                idPartida = Convert.ToInt32(txtIdPartida.Text);
            }
            string retorno = Jogo.VerificarVez(idPartida);
            char verificaErro = retorno.First();

            if(verificaErro == 'E')
            {
                lblFeedBack.Visible = true;
                lblFeedBack.Text = retorno;
                return;
            }

            lblFeedBack.Visible = false;
            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            lstVerificaVez.Items.Add(retorno);

        }
    }
}
