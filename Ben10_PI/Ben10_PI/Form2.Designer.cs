
namespace Ben10_PI
{
    partial class Form2
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
            this.lstHistorico = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.lblFeedBack = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdPartida = new System.Windows.Forms.TextBox();
            this.btnExibirHistorico = new System.Windows.Forms.Button();
            this.txtIdJogador = new System.Windows.Forms.TextBox();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnVerificaVez = new System.Windows.Forms.Button();
            this.lstVerificaVez = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstHistorico
            // 
            this.lstHistorico.FormattingEnabled = true;
            this.lstHistorico.Location = new System.Drawing.Point(492, 62);
            this.lstHistorico.Name = "lstHistorico";
            this.lstHistorico.Size = new System.Drawing.Size(296, 212);
            this.lstHistorico.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Histórico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID do Jogador:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha do Jogador:";
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(12, 86);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(94, 28);
            this.btnIniciarPartida.TabIndex = 8;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // lblFeedBack
            // 
            this.lblFeedBack.AutoSize = true;
            this.lblFeedBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedBack.Location = new System.Drawing.Point(12, 1);
            this.lblFeedBack.Name = "lblFeedBack";
            this.lblFeedBack.Size = new System.Drawing.Size(176, 19);
            this.lblFeedBack.TabIndex = 9;
            this.lblFeedBack.Text = "Mensagem de FeedBack";
            this.lblFeedBack.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID da Partida:";
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPartida.Location = new System.Drawing.Point(567, 12);
            this.txtIdPartida.Multiline = true;
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.Size = new System.Drawing.Size(27, 16);
            this.txtIdPartida.TabIndex = 11;
            // 
            // btnExibirHistorico
            // 
            this.btnExibirHistorico.Location = new System.Drawing.Point(492, 280);
            this.btnExibirHistorico.Name = "btnExibirHistorico";
            this.btnExibirHistorico.Size = new System.Drawing.Size(296, 28);
            this.btnExibirHistorico.TabIndex = 12;
            this.btnExibirHistorico.Text = "Exibir Histórico";
            this.btnExibirHistorico.UseVisualStyleBackColor = true;
            this.btnExibirHistorico.Click += new System.EventHandler(this.btnExibirHistorico_Click);
            // 
            // txtIdJogador
            // 
            this.txtIdJogador.Location = new System.Drawing.Point(112, 34);
            this.txtIdJogador.Multiline = true;
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.Size = new System.Drawing.Size(29, 16);
            this.txtIdJogador.TabIndex = 20;
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Location = new System.Drawing.Point(112, 62);
            this.txtSenhaJogador.Multiline = true;
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(116, 16);
            this.txtSenhaJogador.TabIndex = 21;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 408);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(94, 30);
            this.btnVoltar.TabIndex = 22;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnVerificaVez
            // 
            this.btnVerificaVez.Location = new System.Drawing.Point(12, 280);
            this.btnVerificaVez.Name = "btnVerificaVez";
            this.btnVerificaVez.Size = new System.Drawing.Size(120, 28);
            this.btnVerificaVez.TabIndex = 23;
            this.btnVerificaVez.Text = "Verificar Vez";
            this.btnVerificaVez.UseVisualStyleBackColor = true;
            this.btnVerificaVez.Click += new System.EventHandler(this.btnVerificaVez_Click);
            // 
            // lstVerificaVez
            // 
            this.lstVerificaVez.FormattingEnabled = true;
            this.lstVerificaVez.Location = new System.Drawing.Point(12, 167);
            this.lstVerificaVez.Name = "lstVerificaVez";
            this.lstVerificaVez.Size = new System.Drawing.Size(120, 95);
            this.lstVerificaVez.TabIndex = 24;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstVerificaVez);
            this.Controls.Add(this.btnVerificaVez);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.txtIdJogador);
            this.Controls.Add(this.btnExibirHistorico);
            this.Controls.Add(this.txtIdPartida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFeedBack);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstHistorico);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstHistorico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Label lblFeedBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdPartida;
        private System.Windows.Forms.Button btnExibirHistorico;
        private System.Windows.Forms.TextBox txtIdJogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnVerificaVez;
        private System.Windows.Forms.ListBox lstVerificaVez;
    }
}