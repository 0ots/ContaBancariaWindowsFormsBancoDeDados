namespace ContaBancariaWindowsForms
{
    partial class frmTelaCriarConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaCriarConta));
            this.txtNomeCriarContaBancaria = new System.Windows.Forms.TextBox();
            this.lblNomeCriarContaBancaria = new System.Windows.Forms.Label();
            this.btnCriarConta = new System.Windows.Forms.Button();
            this.btnLimparCamposContaBancaria = new System.Windows.Forms.Button();
            this.lblTituloCriarContaBancaria = new System.Windows.Forms.Label();
            this.lblEmailCriarContaBancaria = new System.Windows.Forms.Label();
            this.txtEmailCriarContaBancaria = new System.Windows.Forms.TextBox();
            this.lblTelefoneCriarContaBancaria = new System.Windows.Forms.Label();
            this.txtTelefoneCriarContaBancaria = new System.Windows.Forms.TextBox();
            this.lblCpfCriarContaBancaria = new System.Windows.Forms.Label();
            this.txtCpfCriarContaBancaria = new System.Windows.Forms.TextBox();
            this.btnVoltarTelaInicialCriarContaBancaria = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblErroNomeCriarContaBancaria = new System.Windows.Forms.Label();
            this.lblErroEmailCriarContaBancaria = new System.Windows.Forms.Label();
            this.lblErroTelefoneCriarContaBancaria = new System.Windows.Forms.Label();
            this.lblErroCpfCriarContaBancaria = new System.Windows.Forms.Label();
            this.lblErroSenhaCriarContaBancaria = new System.Windows.Forms.Label();
            this.lblSenhaCriarContaBancaria = new System.Windows.Forms.Label();
            this.txtSenhaCriarContaBancaria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeCriarContaBancaria
            // 
            this.txtNomeCriarContaBancaria.AccessibleDescription = "";
            this.txtNomeCriarContaBancaria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCriarContaBancaria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCriarContaBancaria.Location = new System.Drawing.Point(305, 170);
            this.txtNomeCriarContaBancaria.MaxLength = 60;
            this.txtNomeCriarContaBancaria.Name = "txtNomeCriarContaBancaria";
            this.txtNomeCriarContaBancaria.Size = new System.Drawing.Size(206, 20);
            this.txtNomeCriarContaBancaria.TabIndex = 1;
            // 
            // lblNomeCriarContaBancaria
            // 
            this.lblNomeCriarContaBancaria.AutoSize = true;
            this.lblNomeCriarContaBancaria.Location = new System.Drawing.Point(391, 154);
            this.lblNomeCriarContaBancaria.Name = "lblNomeCriarContaBancaria";
            this.lblNomeCriarContaBancaria.Size = new System.Drawing.Size(35, 13);
            this.lblNomeCriarContaBancaria.TabIndex = 2;
            this.lblNomeCriarContaBancaria.Text = "Nome";
            // 
            // btnCriarConta
            // 
            this.btnCriarConta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCriarConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarConta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCriarConta.FlatAppearance.BorderSize = 2;
            this.btnCriarConta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCriarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarConta.Location = new System.Drawing.Point(305, 386);
            this.btnCriarConta.Name = "btnCriarConta";
            this.btnCriarConta.Size = new System.Drawing.Size(59, 45);
            this.btnCriarConta.TabIndex = 4;
            this.btnCriarConta.Text = "Criar";
            this.btnCriarConta.UseVisualStyleBackColor = false;
            this.btnCriarConta.Click += new System.EventHandler(this.btnCriarConta_Click);
            // 
            // btnLimparCamposContaBancaria
            // 
            this.btnLimparCamposContaBancaria.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimparCamposContaBancaria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparCamposContaBancaria.FlatAppearance.BorderSize = 2;
            this.btnLimparCamposContaBancaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparCamposContaBancaria.Location = new System.Drawing.Point(380, 386);
            this.btnLimparCamposContaBancaria.Name = "btnLimparCamposContaBancaria";
            this.btnLimparCamposContaBancaria.Size = new System.Drawing.Size(59, 45);
            this.btnLimparCamposContaBancaria.TabIndex = 5;
            this.btnLimparCamposContaBancaria.Text = "Limpar";
            this.btnLimparCamposContaBancaria.UseVisualStyleBackColor = false;
            this.btnLimparCamposContaBancaria.Click += new System.EventHandler(this.btnLimparCamposContaBancaria_Click);
            // 
            // lblTituloCriarContaBancaria
            // 
            this.lblTituloCriarContaBancaria.AutoSize = true;
            this.lblTituloCriarContaBancaria.Location = new System.Drawing.Point(302, 131);
            this.lblTituloCriarContaBancaria.Name = "lblTituloCriarContaBancaria";
            this.lblTituloCriarContaBancaria.Size = new System.Drawing.Size(209, 13);
            this.lblTituloCriarContaBancaria.TabIndex = 6;
            this.lblTituloCriarContaBancaria.Text = "Insira os dados abaixo para criar sua conta";
            // 
            // lblEmailCriarContaBancaria
            // 
            this.lblEmailCriarContaBancaria.AutoSize = true;
            this.lblEmailCriarContaBancaria.Location = new System.Drawing.Point(391, 237);
            this.lblEmailCriarContaBancaria.Name = "lblEmailCriarContaBancaria";
            this.lblEmailCriarContaBancaria.Size = new System.Drawing.Size(35, 13);
            this.lblEmailCriarContaBancaria.TabIndex = 8;
            this.lblEmailCriarContaBancaria.Text = "E-mail";
            // 
            // txtEmailCriarContaBancaria
            // 
            this.txtEmailCriarContaBancaria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailCriarContaBancaria.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmailCriarContaBancaria.Location = new System.Drawing.Point(305, 253);
            this.txtEmailCriarContaBancaria.Name = "txtEmailCriarContaBancaria";
            this.txtEmailCriarContaBancaria.Size = new System.Drawing.Size(206, 20);
            this.txtEmailCriarContaBancaria.TabIndex = 7;
            // 
            // lblTelefoneCriarContaBancaria
            // 
            this.lblTelefoneCriarContaBancaria.AutoSize = true;
            this.lblTelefoneCriarContaBancaria.Location = new System.Drawing.Point(383, 285);
            this.lblTelefoneCriarContaBancaria.Name = "lblTelefoneCriarContaBancaria";
            this.lblTelefoneCriarContaBancaria.Size = new System.Drawing.Size(49, 13);
            this.lblTelefoneCriarContaBancaria.TabIndex = 10;
            this.lblTelefoneCriarContaBancaria.Text = "Telefone";
            // 
            // txtTelefoneCriarContaBancaria
            // 
            this.txtTelefoneCriarContaBancaria.AccessibleDescription = "";
            this.txtTelefoneCriarContaBancaria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefoneCriarContaBancaria.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtTelefoneCriarContaBancaria.Location = new System.Drawing.Point(305, 301);
            this.txtTelefoneCriarContaBancaria.MaxLength = 11;
            this.txtTelefoneCriarContaBancaria.Name = "txtTelefoneCriarContaBancaria";
            this.txtTelefoneCriarContaBancaria.Size = new System.Drawing.Size(206, 20);
            this.txtTelefoneCriarContaBancaria.TabIndex = 9;
            this.txtTelefoneCriarContaBancaria.WordWrap = false;
            // 
            // lblCpfCriarContaBancaria
            // 
            this.lblCpfCriarContaBancaria.AutoSize = true;
            this.lblCpfCriarContaBancaria.Location = new System.Drawing.Point(393, 334);
            this.lblCpfCriarContaBancaria.Name = "lblCpfCriarContaBancaria";
            this.lblCpfCriarContaBancaria.Size = new System.Drawing.Size(27, 13);
            this.lblCpfCriarContaBancaria.TabIndex = 14;
            this.lblCpfCriarContaBancaria.Text = "CPF";
            // 
            // txtCpfCriarContaBancaria
            // 
            this.txtCpfCriarContaBancaria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpfCriarContaBancaria.CausesValidation = false;
            this.txtCpfCriarContaBancaria.Location = new System.Drawing.Point(305, 350);
            this.txtCpfCriarContaBancaria.MaxLength = 11;
            this.txtCpfCriarContaBancaria.Name = "txtCpfCriarContaBancaria";
            this.txtCpfCriarContaBancaria.Size = new System.Drawing.Size(206, 20);
            this.txtCpfCriarContaBancaria.TabIndex = 13;
            // 
            // btnVoltarTelaInicialCriarContaBancaria
            // 
            this.btnVoltarTelaInicialCriarContaBancaria.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltarTelaInicialCriarContaBancaria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltarTelaInicialCriarContaBancaria.FlatAppearance.BorderSize = 2;
            this.btnVoltarTelaInicialCriarContaBancaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarTelaInicialCriarContaBancaria.Location = new System.Drawing.Point(452, 386);
            this.btnVoltarTelaInicialCriarContaBancaria.Name = "btnVoltarTelaInicialCriarContaBancaria";
            this.btnVoltarTelaInicialCriarContaBancaria.Size = new System.Drawing.Size(59, 45);
            this.btnVoltarTelaInicialCriarContaBancaria.TabIndex = 16;
            this.btnVoltarTelaInicialCriarContaBancaria.Text = "Voltar";
            this.btnVoltarTelaInicialCriarContaBancaria.UseVisualStyleBackColor = false;
            this.btnVoltarTelaInicialCriarContaBancaria.Click += new System.EventHandler(this.btnVoltarTelaInicialCriarContaBancaria_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(350, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // lblErroNomeCriarContaBancaria
            // 
            this.lblErroNomeCriarContaBancaria.AutoSize = true;
            this.lblErroNomeCriarContaBancaria.Location = new System.Drawing.Point(534, 173);
            this.lblErroNomeCriarContaBancaria.Name = "lblErroNomeCriarContaBancaria";
            this.lblErroNomeCriarContaBancaria.Size = new System.Drawing.Size(26, 13);
            this.lblErroNomeCriarContaBancaria.TabIndex = 18;
            this.lblErroNomeCriarContaBancaria.Text = "Erro";
            this.lblErroNomeCriarContaBancaria.Visible = false;
            // 
            // lblErroEmailCriarContaBancaria
            // 
            this.lblErroEmailCriarContaBancaria.AutoSize = true;
            this.lblErroEmailCriarContaBancaria.Location = new System.Drawing.Point(534, 256);
            this.lblErroEmailCriarContaBancaria.Name = "lblErroEmailCriarContaBancaria";
            this.lblErroEmailCriarContaBancaria.Size = new System.Drawing.Size(26, 13);
            this.lblErroEmailCriarContaBancaria.TabIndex = 19;
            this.lblErroEmailCriarContaBancaria.Text = "Erro";
            this.lblErroEmailCriarContaBancaria.Visible = false;
            // 
            // lblErroTelefoneCriarContaBancaria
            // 
            this.lblErroTelefoneCriarContaBancaria.AutoSize = true;
            this.lblErroTelefoneCriarContaBancaria.Location = new System.Drawing.Point(534, 304);
            this.lblErroTelefoneCriarContaBancaria.Name = "lblErroTelefoneCriarContaBancaria";
            this.lblErroTelefoneCriarContaBancaria.Size = new System.Drawing.Size(26, 13);
            this.lblErroTelefoneCriarContaBancaria.TabIndex = 20;
            this.lblErroTelefoneCriarContaBancaria.Text = "Erro";
            this.lblErroTelefoneCriarContaBancaria.Visible = false;
            // 
            // lblErroCpfCriarContaBancaria
            // 
            this.lblErroCpfCriarContaBancaria.AutoSize = true;
            this.lblErroCpfCriarContaBancaria.Location = new System.Drawing.Point(534, 353);
            this.lblErroCpfCriarContaBancaria.Name = "lblErroCpfCriarContaBancaria";
            this.lblErroCpfCriarContaBancaria.Size = new System.Drawing.Size(26, 13);
            this.lblErroCpfCriarContaBancaria.TabIndex = 21;
            this.lblErroCpfCriarContaBancaria.Text = "Erro";
            this.lblErroCpfCriarContaBancaria.Visible = false;
            // 
            // lblErroSenhaCriarContaBancaria
            // 
            this.lblErroSenhaCriarContaBancaria.AutoSize = true;
            this.lblErroSenhaCriarContaBancaria.Location = new System.Drawing.Point(534, 214);
            this.lblErroSenhaCriarContaBancaria.Name = "lblErroSenhaCriarContaBancaria";
            this.lblErroSenhaCriarContaBancaria.Size = new System.Drawing.Size(26, 13);
            this.lblErroSenhaCriarContaBancaria.TabIndex = 24;
            this.lblErroSenhaCriarContaBancaria.Text = "Erro";
            this.lblErroSenhaCriarContaBancaria.Visible = false;
            // 
            // lblSenhaCriarContaBancaria
            // 
            this.lblSenhaCriarContaBancaria.AutoSize = true;
            this.lblSenhaCriarContaBancaria.Location = new System.Drawing.Point(389, 195);
            this.lblSenhaCriarContaBancaria.Name = "lblSenhaCriarContaBancaria";
            this.lblSenhaCriarContaBancaria.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaCriarContaBancaria.TabIndex = 23;
            this.lblSenhaCriarContaBancaria.Text = "Senha";
            // 
            // txtSenhaCriarContaBancaria
            // 
            this.txtSenhaCriarContaBancaria.AccessibleDescription = "";
            this.txtSenhaCriarContaBancaria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenhaCriarContaBancaria.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtSenhaCriarContaBancaria.Location = new System.Drawing.Point(305, 211);
            this.txtSenhaCriarContaBancaria.MaxLength = 12;
            this.txtSenhaCriarContaBancaria.Name = "txtSenhaCriarContaBancaria";
            this.txtSenhaCriarContaBancaria.Size = new System.Drawing.Size(206, 20);
            this.txtSenhaCriarContaBancaria.TabIndex = 22;
            this.txtSenhaCriarContaBancaria.UseSystemPasswordChar = true;
            // 
            // frmTelaCriarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblErroSenhaCriarContaBancaria);
            this.Controls.Add(this.lblSenhaCriarContaBancaria);
            this.Controls.Add(this.txtSenhaCriarContaBancaria);
            this.Controls.Add(this.lblErroCpfCriarContaBancaria);
            this.Controls.Add(this.lblErroTelefoneCriarContaBancaria);
            this.Controls.Add(this.lblErroEmailCriarContaBancaria);
            this.Controls.Add(this.lblErroNomeCriarContaBancaria);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVoltarTelaInicialCriarContaBancaria);
            this.Controls.Add(this.lblCpfCriarContaBancaria);
            this.Controls.Add(this.txtCpfCriarContaBancaria);
            this.Controls.Add(this.lblTelefoneCriarContaBancaria);
            this.Controls.Add(this.txtTelefoneCriarContaBancaria);
            this.Controls.Add(this.lblEmailCriarContaBancaria);
            this.Controls.Add(this.txtEmailCriarContaBancaria);
            this.Controls.Add(this.lblTituloCriarContaBancaria);
            this.Controls.Add(this.btnLimparCamposContaBancaria);
            this.Controls.Add(this.btnCriarConta);
            this.Controls.Add(this.lblNomeCriarContaBancaria);
            this.Controls.Add(this.txtNomeCriarContaBancaria);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaCriarConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco Oots";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomeCriarContaBancaria;
        private System.Windows.Forms.Label lblNomeCriarContaBancaria;
        private System.Windows.Forms.Button btnCriarConta;
        private System.Windows.Forms.Button btnLimparCamposContaBancaria;
        private System.Windows.Forms.Label lblTituloCriarContaBancaria;
        private System.Windows.Forms.Label lblEmailCriarContaBancaria;
        private System.Windows.Forms.TextBox txtEmailCriarContaBancaria;
        private System.Windows.Forms.Label lblTelefoneCriarContaBancaria;
        private System.Windows.Forms.TextBox txtTelefoneCriarContaBancaria;
        private System.Windows.Forms.Label lblCpfCriarContaBancaria;
        private System.Windows.Forms.TextBox txtCpfCriarContaBancaria;
        private System.Windows.Forms.Button btnVoltarTelaInicialCriarContaBancaria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblErroNomeCriarContaBancaria;
        private System.Windows.Forms.Label lblErroEmailCriarContaBancaria;
        private System.Windows.Forms.Label lblErroTelefoneCriarContaBancaria;
        private System.Windows.Forms.Label lblErroCpfCriarContaBancaria;
        private System.Windows.Forms.Label lblErroSenhaCriarContaBancaria;
        private System.Windows.Forms.Label lblSenhaCriarContaBancaria;
        private System.Windows.Forms.TextBox txtSenhaCriarContaBancaria;
    }
}