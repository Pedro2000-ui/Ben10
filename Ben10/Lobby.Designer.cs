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
            this.txtTest = new System.Windows.Forms.TextBox();
            this.btnCartas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.groupBox2.Size = new System.Drawing.Size(279, 247);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Histórico";
            // 
            // lstHistorico
            // 
            this.lstHistorico.FormattingEnabled = true;
            this.lstHistorico.Location = new System.Drawing.Point(6, 19);
            this.lstHistorico.Name = "lstHistorico";
            this.lstHistorico.Size = new System.Drawing.Size(267, 186);
            this.lstHistorico.TabIndex = 12;
            // 
            // btnHistorico
            // 
            this.btnHistorico.Location = new System.Drawing.Point(188, 218);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(85, 23);
            this.btnHistorico.TabIndex = 12;
            this.btnHistorico.Text = "Exibir Histórico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(806, 31);
            this.txtTest.Multiline = true;
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(69, 211);
            this.txtTest.TabIndex = 13;
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 144);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.panel6);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.panel7);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.panel8);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Location = new System.Drawing.Point(326, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(452, 377);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cartas da Mão";
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(339, 203);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(105, 144);
            this.panel5.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(339, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(105, 144);
            this.panel4.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(228, 203);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(105, 144);
            this.panel6.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(228, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(105, 144);
            this.panel3.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(117, 203);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(105, 144);
            this.panel7.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(117, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 144);
            this.panel2.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(6, 203);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(105, 144);
            this.panel8.TabIndex = 4;
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 474);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.btnCartas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Lobby";
            this.Text = "Lobby";
            this.Load += new System.EventHandler(this.Lobby_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Button btnCartas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
    }
}