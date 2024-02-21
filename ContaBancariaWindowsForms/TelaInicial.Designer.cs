namespace ContaBancariaWindowsForms
{
    partial class frmTelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaInicial));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.btnCriarContaContaBancaria = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAcessarContaContaBancaria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(334, 222);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(143, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Bem-vindo(a) ao Banco Oots";
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Location = new System.Drawing.Point(317, 239);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(169, 13);
            this.lblSubTitulo.TabIndex = 2;
            this.lblSubTitulo.Text = "Selecione uma das opções abaixo";
            // 
            // btnCriarContaContaBancaria
            // 
            this.btnCriarContaContaBancaria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCriarContaContaBancaria.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCriarContaContaBancaria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarContaContaBancaria.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCriarContaContaBancaria.FlatAppearance.BorderSize = 2;
            this.btnCriarContaContaBancaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarContaContaBancaria.Location = new System.Drawing.Point(402, 264);
            this.btnCriarContaContaBancaria.Name = "btnCriarContaContaBancaria";
            this.btnCriarContaContaBancaria.Size = new System.Drawing.Size(75, 48);
            this.btnCriarContaContaBancaria.TabIndex = 3;
            this.btnCriarContaContaBancaria.Text = "Criar Conta";
            this.btnCriarContaContaBancaria.UseVisualStyleBackColor = false;
            this.btnCriarContaContaBancaria.Click += new System.EventHandler(this.btnCriarContaContaBancaria_Click);
            this.btnCriarContaContaBancaria.MouseLeave += new System.EventHandler(this.btnCriarContaContaBancaria_MouseLeave);
            this.btnCriarContaContaBancaria.MouseHover += new System.EventHandler(this.btnCriarContaContaBancaria_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(346, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnAcessarContaContaBancaria
            // 
            this.btnAcessarContaContaBancaria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAcessarContaContaBancaria.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAcessarContaContaBancaria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcessarContaContaBancaria.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAcessarContaContaBancaria.FlatAppearance.BorderSize = 2;
            this.btnAcessarContaContaBancaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcessarContaContaBancaria.Location = new System.Drawing.Point(325, 264);
            this.btnAcessarContaContaBancaria.Name = "btnAcessarContaContaBancaria";
            this.btnAcessarContaContaBancaria.Size = new System.Drawing.Size(75, 48);
            this.btnAcessarContaContaBancaria.TabIndex = 17;
            this.btnAcessarContaContaBancaria.Text = "Acessar Conta";
            this.btnAcessarContaContaBancaria.UseVisualStyleBackColor = false;
            this.btnAcessarContaContaBancaria.Click += new System.EventHandler(this.btnAcessarContaContaBancaria_Click);
            this.btnAcessarContaContaBancaria.MouseLeave += new System.EventHandler(this.btnAcessarContaContaBancaria_MouseLeave);
            this.btnAcessarContaContaBancaria.MouseHover += new System.EventHandler(this.btnAcessarContaContaBancaria_MouseHover);
            // 
            // frmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAcessarContaContaBancaria);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCriarContaContaBancaria);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco Oots";
            this.Load += new System.EventHandler(this.frmTelaInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Button btnCriarContaContaBancaria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAcessarContaContaBancaria;
    }
}

