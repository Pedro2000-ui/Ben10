namespace Ben10
{
    partial class Lobby
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstHistorico = new System.Windows.Forms.ListBox();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnCartas = new System.Windows.Forms.Button();
            this.grpCartas = new System.Windows.Forms.GroupBox();
            this.txtJogarCarta = new System.Windows.Forms.TextBox();
            this.txtIlha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnIlha = new System.Windows.Forms.Button();
            this.lstVerificarIlha = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVerificaIlha = new System.Windows.Forms.Button();
            this.btnVez = new System.Windows.Forms.Button();
            this.lstVez = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstMesa = new System.Windows.Forms.ListBox();
            this.btnMesa = new System.Windows.Forms.Button();
            this.txtRodada = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstJogadores
            // 
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.Location = new System.Drawing.Point(6, 19);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(138, 108);
            this.lstJogadores.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(6, 133);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(100, 23);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar Jogadores";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(191, 58);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(67, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "MostraNome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(191, 89);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(70, 13);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "MostraSenha";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(191, 29);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(50, 13);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "MostraID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID:";
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(153, 133);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(100, 23);
            this.btnIniciarPartida.TabIndex = 8;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstJogadores);
            this.groupBox1.Controls.Add(this.btnIniciarPartida);
            this.groupBox1.Controls.Add(this.btnListar);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblSenha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 187);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Servidor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstHistorico);
            this.groupBox2.Controls.Add(this.btnHistorico);
            this.groupBox2.Location = new System.Drawing.Point(18, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 413);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Histórico";
            // 
            // lstHistorico
            // 
            this.lstHistorico.FormattingEnabled = true;
            this.lstHistorico.Location = new System.Drawing.Point(12, 23);
            this.lstHistorico.Name = "lstHistorico";
            this.lstHistorico.Size = new System.Drawing.Size(267, 355);
            this.lstHistorico.TabIndex = 12;
            // 
            // btnHistorico
            // 
            this.btnHistorico.Location = new System.Drawing.Point(188, 384);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(85, 23);
            this.btnHistorico.TabIndex = 12;
            this.btnHistorico.Text = "Exibir Histórico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnCartas
            // 
            this.btnCartas.Location = new System.Drawing.Point(681, 395);
            this.btnCartas.Name = "btnCartas";
            this.btnCartas.Size = new System.Drawing.Size(97, 30);
            this.btnCartas.TabIndex = 12;
            this.btnCartas.Text = "Cartas";
            this.btnCartas.UseVisualStyleBackColor = true;
            this.btnCartas.Click += new System.EventHandler(this.btnCartas_Click);
            // 
            // grpCartas
            // 
            this.grpCartas.Location = new System.Drawing.Point(326, 12);
            this.grpCartas.Name = "grpCartas";
            this.grpCartas.Size = new System.Drawing.Size(452, 377);
            this.grpCartas.TabIndex = 11;
            this.grpCartas.TabStop = false;
            this.grpCartas.Text = "Cartas da Mão";
            // 
            // txtJogarCarta
            // 
            this.txtJogarCarta.Location = new System.Drawing.Point(856, 83);
            this.txtJogarCarta.Name = "txtJogarCarta";
            this.txtJogarCarta.Size = new System.Drawing.Size(129, 20);
            this.txtJogarCarta.TabIndex = 13;
            // 
            // txtIlha
            // 
            this.txtIlha.Location = new System.Drawing.Point(856, 232);
            this.txtIlha.Name = "txtIlha";
            this.txtIlha.Size = new System.Drawing.Size(129, 20);
            this.txtIlha.TabIndex = 14;
            this.txtIlha.TextChanged += new System.EventHandler(this.txtIlha_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(784, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Carta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(784, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ilha";
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(910, 109);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(75, 23);
            this.btnJogar.TabIndex = 16;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnIlha
            // 
            this.btnIlha.Enabled = false;
            this.btnIlha.Location = new System.Drawing.Point(910, 258);
            this.btnIlha.Name = "btnIlha";
            this.btnIlha.Size = new System.Drawing.Size(75, 23);
            this.btnIlha.TabIndex = 17;
            this.btnIlha.Text = "Definir ilha";
            this.btnIlha.UseVisualStyleBackColor = true;
            this.btnIlha.Click += new System.EventHandler(this.btnIlha_Click);
            // 
            // lstVerificarIlha
            // 
            this.lstVerificarIlha.FormattingEnabled = true;
            this.lstVerificarIlha.Location = new System.Drawing.Point(856, 164);
            this.lstVerificarIlha.Name = "lstVerificarIlha";
            this.lstVerificarIlha.Size = new System.Drawing.Size(129, 17);
            this.lstVerificarIlha.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(784, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Verificar Ilha";
            // 
            // btnVerificaIlha
            // 
            this.btnVerificaIlha.Location = new System.Drawing.Point(910, 187);
            this.btnVerificaIlha.Name = "btnVerificaIlha";
            this.btnVerificaIlha.Size = new System.Drawing.Size(75, 23);
            this.btnVerificaIlha.TabIndex = 20;
            this.btnVerificaIlha.Text = "Verificar";
            this.btnVerificaIlha.UseVisualStyleBackColor = true;
            this.btnVerificaIlha.Click += new System.EventHandler(this.btnVerificaIlha_Click);
            // 
            // btnVez
            // 
            this.btnVez.Location = new System.Drawing.Point(910, 41);
            this.btnVez.Name = "btnVez";
            this.btnVez.Size = new System.Drawing.Size(75, 23);
            this.btnVez.TabIndex = 21;
            this.btnVez.Text = "Verificar vez";
            this.btnVez.UseVisualStyleBackColor = true;
            this.btnVez.Click += new System.EventHandler(this.btnVez_Click);
            // 
            // lstVez
            // 
            this.lstVez.FormattingEnabled = true;
            this.lstVez.Location = new System.Drawing.Point(856, 12);
            this.lstVez.Name = "lstVez";
            this.lstVez.Size = new System.Drawing.Size(129, 17);
            this.lstVez.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(784, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Verificar Vez";
            // 
            // lstMesa
            // 
            this.lstMesa.FormattingEnabled = true;
            this.lstMesa.Location = new System.Drawing.Point(326, 395);
            this.lstMesa.Name = "lstMesa";
            this.lstMesa.Size = new System.Drawing.Size(178, 238);
            this.lstMesa.TabIndex = 23;
            // 
            // btnMesa
            // 
            this.btnMesa.Location = new System.Drawing.Point(510, 603);
            this.btnMesa.Name = "btnMesa";
            this.btnMesa.Size = new System.Drawing.Size(97, 30);
            this.btnMesa.TabIndex = 24;
            this.btnMesa.Text = "Mesa";
            this.btnMesa.UseVisualStyleBackColor = true;
            this.btnMesa.Click += new System.EventHandler(this.btnMesa_Click);
            // 
            // txtRodada
            // 
            this.txtRodada.Location = new System.Drawing.Point(561, 544);
            this.txtRodada.Name = "txtRodada";
            this.txtRodada.Size = new System.Drawing.Size(100, 20);
            this.txtRodada.TabIndex = 25;
            this.txtRodada.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(510, 547);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Rodada";
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 640);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRodada);
            this.Controls.Add(this.btnMesa);
            this.Controls.Add(this.lstMesa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstVez);
            this.Controls.Add(this.btnVez);
            this.Controls.Add(this.btnVerificaIlha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstVerificarIlha);
            this.Controls.Add(this.btnIlha);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIlha);
            this.Controls.Add(this.txtJogarCarta);
            this.Controls.Add(this.btnCartas);
            this.Controls.Add(this.grpCartas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Lobby";
            this.Text = "Lobby";
            this.Load += new System.EventHandler(this.Lobby_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstHistorico;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button btnCartas;
        private System.Windows.Forms.GroupBox grpCartas;
        private System.Windows.Forms.TextBox txtJogarCarta;
        private System.Windows.Forms.TextBox txtIlha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnIlha;
        private System.Windows.Forms.ListBox lstVerificarIlha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVerificaIlha;
        private System.Windows.Forms.Button btnVez;
        private System.Windows.Forms.ListBox lstVez;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstMesa;
        private System.Windows.Forms.Button btnMesa;
        private System.Windows.Forms.TextBox txtRodada;
        private System.Windows.Forms.Label label8;
    }
}