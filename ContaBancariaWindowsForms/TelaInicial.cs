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
    public partial class frmTelaInicial : Form
    {
        public frmTelaInicial()
        {
            InitializeComponent();
        }
        private void frmTelaInicial_Load(object sender, EventArgs e)
        {

            MySqlConnection Conexao = new MySqlConnection("datasource=localhost;username=root;password=;database=contabancaria");
            try
            {
                Conexao.Open();
            }
            catch
            {
                MessageBox.Show("Houve um erro ao conectar com o banco de dados. \nContate o administrador.", "Mensagem", MessageBoxButtons.OK);
                this.Close();
            }
            finally
            {
                Conexao.Close();
            }
        }
        private void btnAcessarContaContaBancaria_Click(object sender, EventArgs e)
        {
            AcessarTelaLoginContaBancaria();
        }
        private void btnCriarContaContaBancaria_Click(object sender, EventArgs e)
        {
            AcessarTelaCriarContaBancaria();
        }
        // Método para acessar a tela de criar conta
        public void AcessarTelaCriarContaBancaria()
        {
            frmTelaCriarConta telacriarconta = new frmTelaCriarConta();
            this.Hide();
            telacriarconta.Show();
        }
        // Método para acessar a tela inicial da conta do titular
        public void AcessarTelaLoginContaBancaria()
        {
            frmTelaLogin frmtelalogin = new frmTelaLogin();
            frmtelalogin.Show();
            this.Hide();
        }
    }
}
