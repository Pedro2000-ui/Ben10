﻿using System;
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
    public partial class Form1 : Form
    {
        public int id;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPartidas_Click(object sender, EventArgs e)
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

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.CriarPartida(txtNomePartida.Text, txtSenhaPartida.Text);
           
            txtNomePartida.Text = "";
            txtSenhaPartida.Text = "";
           
            if (retorno.Contains("ERRO"))           
                MessageBox.Show(retorno);           
            else
                MessageBox.Show("Partida Criada com Sucesso!");
            
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            

            if (lstPartidas.SelectedItem != null)
            {
                string partida = lstPartidas.SelectedItem.ToString();
                string[] itens = partida.Split(',');
                this.id = Convert.ToInt32(itens[0]);
                
                string retorno = Jogo.EntrarPartida(this.id, txtJogador.Text, txtSenhaPartida2.Text);

                if (retorno.Contains("ERRO"))
                    MessageBox.Show(retorno);
                else
                {
                    MessageBox.Show("Sucesso ao entrar na partida!");

                    string jogadores = Jogo.ListarJogadores(this.id);

                    Lobby tela2 = new Lobby(retorno, txtJogador.Text, jogadores, this.id);
                    txtJogador.Text = "";
                    txtSenhaPartida2.Text = "";
                    tela2.ShowDialog();


                }




            }
            else
                MessageBox.Show("Selecione uma Partida!");

        }


    }
}