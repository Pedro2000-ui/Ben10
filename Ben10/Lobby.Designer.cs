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
            this.components = new System.ComponentModel.Container();
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
            this.grpCartas = new System.Windows.Forms.GroupBox();
            this.txtRodada = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnMesa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpMesa = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblIlha = new System.Windows.Forms.Label();
            this.flpCartasMesa = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpMesa.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btnListar.BackColor = System.Drawing.Color.White;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Location = new System.Drawing.Point(6, 133);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(100, 23);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar Jogadores";
            this.btnListar.UseVisualStyleBackColor = false;
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
            this.btnIniciarPartida.BackColor = System.Drawing.Color.White;
            this.btnIniciarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarPartida.Location = new System.Drawing.Point(153, 133);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(100, 23);
            this.btnIniciarPartida.TabIndex = 8;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(93)))), ((int)(((byte)(67)))));
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
            this.groupBox1.Size = new System.Drawing.Size(441, 187);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Servidor";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(93)))), ((int)(((byte)(67)))));
            this.groupBox2.Controls.Add(this.lstHistorico);
            this.groupBox2.Controls.Add(this.btnHistorico);
            this.groupBox2.Location = new System.Drawing.Point(18, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 479);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Histórico";
            // 
            // lstHistorico
            // 
            this.lstHistorico.FormattingEnabled = true;
            this.lstHistorico.Location = new System.Drawing.Point(6, 16);
            this.lstHistorico.Name = "lstHistorico";
            this.lstHistorico.Size = new System.Drawing.Size(423, 420);
            this.lstHistorico.TabIndex = 12;
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.Color.White;
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorico.Location = new System.Drawing.Point(188, 450);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(85, 23);
            this.btnHistorico.TabIndex = 12;
            this.btnHistorico.Text = "Exibir Histórico";
            this.btnHistorico.UseVisualStyleBackColor = false;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // grpCartas
            // 
            this.grpCartas.Location = new System.Drawing.Point(707, 448);
            this.grpCartas.Name = "grpCartas";
            this.grpCartas.Size = new System.Drawing.Size(314, 240);
            this.grpCartas.TabIndex = 11;
            this.grpCartas.TabStop = false;
            this.grpCartas.Text = "Cartas da Mão";
            // 
            // txtRodada
            // 
            this.txtRodada.Location = new System.Drawing.Point(1219, 599);
            this.txtRodada.Name = "txtRodada";
            this.txtRodada.Size = new System.Drawing.Size(26, 20);
            this.txtRodada.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1168, 602);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Rodada";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnMesa
            // 
            this.btnMesa.BackgroundImage = global::Ben10.Properties.Resources.retangulo;
            this.btnMesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMesa.FlatAppearance.BorderSize = 0;
            this.btnMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMesa.Location = new System.Drawing.Point(1170, 628);
            this.btnMesa.Name = "btnMesa";
            this.btnMesa.Size = new System.Drawing.Size(75, 23);
            this.btnMesa.TabIndex = 24;
            this.btnMesa.Text = "Mesa";
            this.btnMesa.UseVisualStyleBackColor = true;
            this.btnMesa.Click += new System.EventHandler(this.btnMesa_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(93)))), ((int)(((byte)(67)))));
            this.panel2.Location = new System.Drawing.Point(-18, -7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 711);
            this.panel2.TabIndex = 29;
            // 
            // grpMesa
            // 
            this.grpMesa.Controls.Add(this.panel3);
            this.grpMesa.Controls.Add(this.flpCartasMesa);
            this.grpMesa.Controls.Add(this.pictureBox7);
            this.grpMesa.Controls.Add(this.pictureBox5);
            this.grpMesa.Controls.Add(this.pictureBox4);
            this.grpMesa.Controls.Add(this.pictureBox3);
            this.grpMesa.Controls.Add(this.pictureBox2);
            this.grpMesa.Location = new System.Drawing.Point(534, 12);
            this.grpMesa.Name = "grpMesa";
            this.grpMesa.Size = new System.Drawing.Size(711, 430);
            this.grpMesa.TabIndex = 12;
            this.grpMesa.TabStop = false;
            this.grpMesa.Text = "Mesa";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Ben10.Properties.Resources.ilha;
            this.panel3.Controls.Add(this.lblIlha);
            this.panel3.Location = new System.Drawing.Point(561, 290);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 140);
            this.panel3.TabIndex = 11;
            // 
            // lblIlha
            // 
            this.lblIlha.AutoSize = true;
            this.lblIlha.BackColor = System.Drawing.Color.Transparent;
            this.lblIlha.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIlha.Location = new System.Drawing.Point(47, 50);
            this.lblIlha.Name = "lblIlha";
            this.lblIlha.Size = new System.Drawing.Size(0, 33);
            this.lblIlha.TabIndex = 8;
            // 
            // flpCartasMesa
            // 
            this.flpCartasMesa.Location = new System.Drawing.Point(162, 151);
            this.flpCartasMesa.Name = "flpCartasMesa";
            this.flpCartasMesa.Size = new System.Drawing.Size(387, 125);
            this.flpCartasMesa.TabIndex = 10;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox7.Image = global::Ben10.Properties.Resources.bolinhodecartaoficial;
            this.pictureBox7.Location = new System.Drawing.Point(6, 305);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(120, 117);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Image = global::Ben10.Properties.Resources.bolinhodecartaoficial;
            this.pictureBox5.Location = new System.Drawing.Point(429, 307);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(120, 117);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::Ben10.Properties.Resources._8cards_L;
            this.pictureBox4.Location = new System.Drawing.Point(571, 89);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(173, 195);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::Ben10.Properties.Resources._8cards_D;
            this.pictureBox3.Location = new System.Drawing.Point(266, -28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(195, 173);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::Ben10.Properties.Resources._8cards_R;
            this.pictureBox2.Location = new System.Drawing.Point(-38, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 195);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ben10.Properties.Resources.omnitrix;
            this.pictureBox1.Location = new System.Drawing.Point(1101, 448);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(151)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1370, 707);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnMesa);
            this.Controls.Add(this.txtRodada);
            this.Controls.Add(this.grpMesa);
            this.Controls.Add(this.grpCartas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Lobby";
            this.Text = "Lobby - Ben10";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Lobby_FormClosed);
            this.Load += new System.EventHandler(this.Lobby_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.grpMesa.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.GroupBox grpCartas;
        private System.Windows.Forms.Button btnMesa;
        private System.Windows.Forms.TextBox txtRodada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpMesa;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblIlha;
        private System.Windows.Forms.FlowLayoutPanel flpCartasMesa;
        private System.Windows.Forms.Panel panel3;
    }
}