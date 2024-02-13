using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ContaBancariaWindowsForms
{
    public partial class frmCriarConta : Form
    {
        public frmCriarConta()
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
            List<Titular> titular = new List<Titular>();
            var nome = txtNomeCriarContaBancaria.Text;
            var senha = txtSenhaCriarContaBancaria.Text;
            var email = txtEmailCriarContaBancaria.Text;
            var telefone = txtTelefoneCriarContaBancaria.Text;
            var cpf = txtCpfCriarContaBancaria.Text;
            titular.Add(new Titular(nome, senha, email, telefone, cpf));
            int erro = 0;
            bool isInteger = false;
            while (!isInteger)
            {
                nome = txtNomeCriarContaBancaria.Text;
                if (int.TryParse(nome, out _))
                {
                    lblErroNomeCriarContaBancaria.Text = "Apenas caracteres de A - Z";
                    isInteger = true;
                    erro++;
                }
                if (double.TryParse(nome, out _))
                {
                    lblErroNomeCriarContaBancaria.Text = "Apenas caracteres A - Z";
                    isInteger = true;
                    erro++;
                }
                break;
            }
            if (erro == 0)
            {
                try
                {
                    MySqlConnection Conexao = new MySqlConnection("datasource=localhost;username=root;password=;database=contabancaria");
                    foreach (Titular t in titular)
                    {
                        // Invoca o método MeuMetodo para cada objeto Titular na lista
                        string sql_code = t.InserirTitular();
                        MySqlCommand comando = new MySqlCommand(sql_code, Conexao);
                        Conexao.Open();
                        comando.ExecuteReader();
                        MessageBox.Show("Titular inserido com sucesso!");
                        LimparCamposCriarContaBancaria();
                        LimparCamposErros();
                    }
                }
                catch
                {
                    MessageBox.Show("Houve um erro ao cadastrar o titular");
                }
            }
        }
        // Métodos
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
           
            lblErroEmailCriarContaBancaria.Text = "";
            lblErroTelefoneCriarContaBancaria.Text = "";
            lblErroCpfCriarContaBancaria.Text = "";
        }
    }
}