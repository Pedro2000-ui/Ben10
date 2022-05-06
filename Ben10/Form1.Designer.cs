namespace Ben10
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.txtJogador = new System.Windows.Forms.TextBox();
            this.txtSenhaPartida2 = new System.Windows.Forms.TextBox();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.lblSenhaPartiad = new System.Windows.Forms.Label();
            this.lblJogador = new System.Windows.Forms.Label();
            this.lblSenhaPartida2 = new System.Windows.Forms.Label();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.btnPartidas = new System.Windows.Forms.Button();
            this.lstPartidas = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(232, 48);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(100, 20);
            this.txtNomePartida.TabIndex = 0;
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(232, 94);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaPartida.TabIndex = 1;
            // 
            // txtJogador
            // 
            this.txtJogador.Location = new System.Drawing.Point(232, 214);
            this.txtJogador.Name = "txtJogador";
            this.txtJogador.Size = new System.Drawing.Size(100, 20);
            this.txtJogador.TabIndex = 2;
            // 
            // txtSenhaPartida2
            // 
            this.txtSenhaPartida2.Location = new System.Drawing.Point(232, 257);
            this.txtSenhaPartida2.Name = "txtSenhaPartida2";
            this.txtSenhaPartida2.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaPartida2.TabIndex = 3;
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Location = new System.Drawing.Point(229, 32);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(86, 13);
            this.lblNomePartida.TabIndex = 4;
            this.lblNomePartida.Text = "Nome da Partida";
            // 
            // lblSenhaPartiad
            // 
            this.lblSenhaPartiad.AutoSize = true;
            this.lblSenhaPartiad.Location = new System.Drawing.Point(229, 78);
            this.lblSenhaPartiad.Name = "lblSenhaPartiad";
            this.lblSenhaPartiad.Size = new System.Drawing.Size(89, 13);
            this.lblSenhaPartiad.TabIndex = 5;
            this.lblSenhaPartiad.Text = "Senha da Partida";
            // 
            // lblJogador
            // 
            this.lblJogador.AutoSize = true;
            this.lblJogador.Location = new System.Drawing.Point(229, 198);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(45, 13);
            this.lblJogador.TabIndex = 6;
            this.lblJogador.Text = "Jogador";
            // 
            // lblSenhaPartida2
            // 
            this.lblSenhaPartida2.AutoSize = true;
            this.lblSenhaPartida2.Location = new System.Drawing.Point(229, 241);
            this.lblSenhaPartida2.Name = "lblSenhaPartida2";
            this.lblSenhaPartida2.Size = new System.Drawing.Size(89, 13);
            this.lblSenhaPartida2.TabIndex = 7;
            this.lblSenhaPartida2.Text = "Senha da Partida";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(232, 283);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(100, 23);
            this.btnEntrarPartida.TabIndex = 8;
            this.btnEntrarPartida.Text = "Entrar na Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(232, 120);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(100, 23);
            this.btnCriarPartida.TabIndex = 9;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // btnPartidas
            // 
            this.btnPartidas.Location = new System.Drawing.Point(20, 311);
            this.btnPartidas.Name = "btnPartidas";
            this.btnPartidas.Size = new System.Drawing.Size(186, 23);
            this.btnPartidas.TabIndex = 10;
            this.btnPartidas.Text = "Listar Partidas";
            this.btnPartidas.UseVisualStyleBackColor = true;
            this.btnPartidas.Click += new System.EventHandler(this.btnPartidas_Click);
            // 
            // lstPartidas
            // 
            this.lstPartidas.FormattingEnabled = true;
            this.lstPartidas.Location = new System.Drawing.Point(20, 19);
            this.lstPartidas.Name = "lstPartidas";
            this.lstPartidas.Size = new System.Drawing.Size(186, 277);
            this.lstPartidas.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstPartidas);
            this.groupBox1.Controls.Add(this.txtNomePartida);
            this.groupBox1.Controls.Add(this.btnPartidas);
            this.groupBox1.Controls.Add(this.txtSenhaPartida);
            this.groupBox1.Controls.Add(this.btnCriarPartida);
            this.groupBox1.Controls.Add(this.txtJogador);
            this.groupBox1.Controls.Add(this.btnEntrarPartida);
            this.groupBox1.Controls.Add(this.txtSenhaPartida2);
            this.groupBox1.Controls.Add(this.lblSenhaPartida2);
            this.groupBox1.Controls.Add(this.lblNomePartida);
            this.groupBox1.Controls.Add(this.lblJogador);
            this.groupBox1.Controls.Add(this.lblSenhaPartiad);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 342);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(379, 377);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(395, 416);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(395, 416);
            this.Name = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.TextBox txtJogador;
        private System.Windows.Forms.TextBox txtSenhaPartida2;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Label lblSenhaPartiad;
        private System.Windows.Forms.Label lblJogador;
        private System.Windows.Forms.Label lblSenhaPartida2;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Button btnPartidas;
        private System.Windows.Forms.ListBox lstPartidas;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

