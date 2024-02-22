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
    public partial class frmTelaInicialContaTitular : Form
    {
        private int userID;
        public frmTelaInicialContaTitular(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }
        private void btnEncerrarSecaoTelaInicialContaBancaria_Click(object sender, EventArgs e)
        {
            frmTelaInicial frmtelainicial = new frmTelaInicial();
            frmtelainicial.Show();
            this.Hide();
            this.Dispose();
        }
        private void btnRealizarDepositoTelaInicialContaBancaria_Click(object sender, EventArgs e)
        {
            frmTelaRealizarDeposito frmtelarealizardepostio = new frmTelaRealizarDeposito(userID);
            frmtelarealizardepostio.Show();
            this.Hide();
        }
        private void btnRealizarSaqueTelaInicialContaBancaria_Click(object sender, EventArgs e)
        {
            frmTelaRealizarSaque frmtelarealizarsaque = new frmTelaRealizarSaque(userID);
            frmtelarealizarsaque.Show();
            this.Hide();
        }
        private void frmTelaInicialContaTitular_Load(object sender, EventArgs e)
        {
            MySqlConnection Conexao = new MySqlConnection("datasource=localhost;username=root;password=;database=contabancaria");

            string sql_code_nome = $"SELECT nome FROM titular WHERE id = '{userID}'";
            string sql_code_saldo = $"SELECT saldo FROM titular WHERE id = '{userID}'";

            MySqlCommand comando_obter_nome = new MySqlCommand(sql_code_nome, Conexao);
            MySqlCommand comando_obter_saldo = new MySqlCommand(sql_code_saldo, Conexao);

            Conexao.Open();

            string nome = comando_obter_nome.ExecuteScalar()?.ToString();
            string saldo = comando_obter_saldo.ExecuteScalar()?.ToString();

            Conexao.Close();

            lblRetornarNomeTitularTelaInicialContaBancaria.Text = nome;
            lblRetornarSaldoTelaInicialContaBancaria.Text = saldo;
        }

        private void btnEditarTitularContaBancaria_Click(object sender, EventArgs e)
        {
            frmTelaEditarDadosTitular frmtelaeditardadostitular = new frmTelaEditarDadosTitular(userID);
            frmtelaeditardadostitular.Show();
            this.Hide();
        }
    }
}
