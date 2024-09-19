namespace Jogo_da_Velha
{
    partial class JogoDaVelha
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
            this.lblJogo = new System.Windows.Forms.Label();
            this.lblJog = new System.Windows.Forms.Label();
            this.lblVez = new System.Windows.Forms.Label();
            this.lblLinha = new System.Windows.Forms.Label();
            this.txtLinha = new System.Windows.Forms.TextBox();
            this.txtColuna = new System.Windows.Forms.TextBox();
            this.lblColuna = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJogo
            // 
            this.lblJogo.AutoSize = true;
            this.lblJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogo.Location = new System.Drawing.Point(61, 57);
            this.lblJogo.Name = "lblJogo";
            this.lblJogo.Size = new System.Drawing.Size(186, 31);
            this.lblJogo.TabIndex = 0;
            this.lblJogo.Text = "Jogo da Velha\r\n";
            // 
            // lblJog
            // 
            this.lblJog.AutoSize = true;
            this.lblJog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJog.Location = new System.Drawing.Point(62, 204);
            this.lblJog.Name = "lblJog";
            this.lblJog.Size = new System.Drawing.Size(125, 20);
            this.lblJog.TabIndex = 1;
            this.lblJog.Text = "Jogador da Vez:";
            // 
            // lblVez
            // 
            this.lblVez.AutoSize = true;
            this.lblVez.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVez.Location = new System.Drawing.Point(281, 200);
            this.lblVez.Name = "lblVez";
            this.lblVez.Size = new System.Drawing.Size(27, 26);
            this.lblVez.TabIndex = 2;
            this.lblVez.Text = "X";
            // 
            // lblLinha
            // 
            this.lblLinha.AutoSize = true;
            this.lblLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinha.Location = new System.Drawing.Point(62, 251);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(184, 20);
            this.lblLinha.TabIndex = 3;
            this.lblLinha.Text = "Digite o número da linha:";
            // 
            // txtLinha
            // 
            this.txtLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinha.Location = new System.Drawing.Point(269, 248);
            this.txtLinha.Name = "txtLinha";
            this.txtLinha.Size = new System.Drawing.Size(39, 26);
            this.txtLinha.TabIndex = 4;
            // 
            // txtColuna
            // 
            this.txtColuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColuna.Location = new System.Drawing.Point(269, 289);
            this.txtColuna.Name = "txtColuna";
            this.txtColuna.Size = new System.Drawing.Size(39, 26);
            this.txtColuna.TabIndex = 6;
            // 
            // lblColuna
            // 
            this.lblColuna.AutoSize = true;
            this.lblColuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColuna.Location = new System.Drawing.Point(62, 292);
            this.lblColuna.Name = "lblColuna";
            this.lblColuna.Size = new System.Drawing.Size(198, 20);
            this.lblColuna.TabIndex = 5;
            this.lblColuna.Text = "Digite o número da coluna:";
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(362, 292);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(75, 23);
            this.btnJogar.TabIndex = 7;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // JogoDaVelha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.txtColuna);
            this.Controls.Add(this.lblColuna);
            this.Controls.Add(this.txtLinha);
            this.Controls.Add(this.lblLinha);
            this.Controls.Add(this.lblVez);
            this.Controls.Add(this.lblJog);
            this.Controls.Add(this.lblJogo);
            this.Name = "JogoDaVelha";
            this.Text = "JogoDaVelha";
            this.Load += new System.EventHandler(this.JogoDaVelha_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJogo;
        private System.Windows.Forms.Label lblJog;
        private System.Windows.Forms.Label lblVez;
        private System.Windows.Forms.Label lblLinha;
        private System.Windows.Forms.TextBox txtLinha;
        private System.Windows.Forms.TextBox txtColuna;
        private System.Windows.Forms.Label lblColuna;
        private System.Windows.Forms.Button btnJogar;
    }
}

