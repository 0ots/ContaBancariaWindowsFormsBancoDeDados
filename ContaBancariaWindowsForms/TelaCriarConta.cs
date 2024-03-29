﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ContaBancariaWindowsForms
{
    public partial class frmTelaCriarConta : Form
    {
        public frmTelaCriarConta()
        {
            InitializeComponent();
        }
        private void btnLimparCamposContaBancaria_Click(object sender, EventArgs e)
        {
            LimparCamposCriarContaBancaria();
            LimparCamposErros();
        }
        private void btnVoltarTelaInicialCriarContaBancaria_Click(object sender, EventArgs e)
        {
            VoltarTelaInicial();
        }
        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            LimparCamposErros();

            int erro = 0;
            bool isInteger = false;

            var nome = txtNomeCriarContaBancaria.Text;

            while (nome.Length < 3)
            {
                lblErroNomeCriarContaBancaria.Visible = true;
                lblErroNomeCriarContaBancaria.Text = "O nome deve conter pelo menos 3 caracteres";
                erro++;
                break;
            }
            while (!isInteger)
            {
                lblErroNomeCriarContaBancaria.Visible = true;
                nome = txtNomeCriarContaBancaria.Text;
                if (int.TryParse(nome, out _))
                {
                    lblErroNomeCriarContaBancaria.Visible = true;
                    lblErroNomeCriarContaBancaria.Text = "O nome deve conter apenas caracteres de A - Z";
                    isInteger = true;
                    erro++;
                }
                if (double.TryParse(nome, out _))
                {
                    lblErroNomeCriarContaBancaria.Visible = true;
                    lblErroNomeCriarContaBancaria.Text = "O nome deve conter apenas caracteres de A - Z";
                    isInteger = true;
                    erro++;
                }
                break;
            }

            var senha = txtSenhaCriarContaBancaria.Text;
            while(senha.Length < 6)
            {
                lblErroSenhaCriarContaBancaria.Visible= true;
                lblErroSenhaCriarContaBancaria.Text = "A senha deve conter entre 6 e 12 caracteres";
                erro++;
                break;
            }

            var email = txtEmailCriarContaBancaria.Text;

            var telefone = txtTelefoneCriarContaBancaria.Text;
            while (telefone.Length < 11)
            {
                lblErroTelefoneCriarContaBancaria.Visible = true;
                lblErroTelefoneCriarContaBancaria.Text = "O telefone deve conter 11 caracteres númericos";
                erro++;
                break;
            }

            var cpf = txtCpfCriarContaBancaria.Text;
            while (cpf.Length < 11)
            {
                lblErroCpfCriarContaBancaria.Visible = true;
                lblErroCpfCriarContaBancaria.Text = "O CPF deve conter 11 caracteres númericos";
                erro++;
                break;
            }

            List<Titular> titular = new List<Titular>();
            titular.Add(new Titular(nome, senha, email, telefone, cpf));

            if (erro == 0)
            {
                MySqlConnection Conexao = new MySqlConnection("datasource=localhost;username=root;password=;database=contabancaria");
                try
                {
                    foreach (Titular t in titular)
                    {
                        string sql_code = t.InserirTitular();
                        MySqlCommand comando = new MySqlCommand(sql_code, Conexao);
                        Conexao.Open();
                        comando.ExecuteReader();
                        MessageBox.Show("Conta criada com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCamposCriarContaBancaria();
                        LimparCamposErros();
                        VoltarTelaInicial();
                    }
                }
                catch
                {
                    MessageBox.Show("Houve um erro ao cadastrar sua conta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Conexao.Close();
                }
            }
        }

        public void VoltarTelaInicial()
        {
            frmTelaInicial telainicial = new frmTelaInicial();
            this.Hide();
            telainicial.Show();
        }

        private void LimparCamposCriarContaBancaria()
        {
            txtNomeCriarContaBancaria.Text = "";
            txtSenhaCriarContaBancaria.Text = "";
            txtEmailCriarContaBancaria.Text = "";
            txtTelefoneCriarContaBancaria.Text = "";
            txtCpfCriarContaBancaria.Text = "";
        }

        public void LimparCamposErros()
        {
            lblErroNomeCriarContaBancaria.Text = "";
            lblErroSenhaCriarContaBancaria.Text = "";
            lblErroEmailCriarContaBancaria.Text = "";
            lblErroTelefoneCriarContaBancaria.Text = "";
            lblErroCpfCriarContaBancaria.Text = "";
        }

    }
}