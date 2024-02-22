using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaBancariaWindowsForms
{
    public partial class frmTelaRealizarSaque : Form
    {
        private int userID;
        public frmTelaRealizarSaque(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }
        private void btnRealizarSaqueTelaInicialContaBancaria_Click(object sender, EventArgs e)
        {
            try
            {
                Titular titular = new Titular();
                double valor_a_sacar = double.Parse(txtQuantidadeRealizarSaqueContaBancaria.Text);

                MySqlConnection Conexao = new MySqlConnection("datasource=localhost;username=root;password=;database=contabancaria");

                string sql_code_obter_saldo_atual = titular.RetornarSaldoTitular(userID);
                MySqlCommand comando_obter_saldo_atual = new MySqlCommand(sql_code_obter_saldo_atual, Conexao);

                Conexao.Open();

                string obter_saldo_atual = comando_obter_saldo_atual.ExecuteScalar()?.ToString();

                double novo_valor_saldo = double.Parse(obter_saldo_atual) - valor_a_sacar;

                string sql_code_inserir_novo_saldo = titular.RealizarSaque(novo_valor_saldo, userID);
                MySqlCommand comando_inserir_novo_saldo = new MySqlCommand(sql_code_inserir_novo_saldo, Conexao);

                string inserir_novo_saldo = comando_inserir_novo_saldo.ExecuteScalar()?.ToString();

                Conexao.Close();

                MessageBox.Show("Saque realizado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmTelaInicialContaTitular frmtelainicialcontatitular = new frmTelaInicialContaTitular(userID);
                frmtelainicialcontatitular.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Houve um erro ao realizar o saque.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmTelaInicialContaTitular frmtelainicialcontatitular = new frmTelaInicialContaTitular(userID);
                frmtelainicialcontatitular.Show();
                this.Hide();
            }
        }
        private void btnLimparCampoRealizarDepositoTelaInicialContaBancaria_Click(object sender, EventArgs e)
        {
            txtQuantidadeRealizarSaqueContaBancaria.Text = "";
        }
        private void btnEncerrarRealizarSaqueTelaInicialContaBancaria_Click(object sender, EventArgs e)
        {
            frmTelaInicialContaTitular frmtelainicialcontatitular = new frmTelaInicialContaTitular(userID);
            frmtelainicialcontatitular.Show();
            this.Hide();
        }

        private void frmTelaRealizarSaque_Load(object sender, EventArgs e)
        {
            MySqlConnection Conexao = new MySqlConnection("datasource=localhost;username=root;password=;database=contabancaria");

            string obter_nome_titular = $"SELECT nome FROM titular WHERE id = '{userID}'";

            try
            {
                MySqlCommand comando_obter_nome = new MySqlCommand(obter_nome_titular, Conexao);

                Conexao.Open();

                string nome = comando_obter_nome.ExecuteScalar()?.ToString();

                lblNomeRealizarSaqueContaBancaria.Text = nome;
            }
            catch
            {
                MessageBox.Show("houve um erro ao conectar com o banco de dados. \n Contate o administrador", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Conexao.Close();
            }

        }
    }
}
