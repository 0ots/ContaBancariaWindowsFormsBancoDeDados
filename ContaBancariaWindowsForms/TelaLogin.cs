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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace ContaBancariaWindowsForms
{
    public partial class frmTelaLogin : Form
    {
        public frmTelaLogin()
        {
            InitializeComponent();
        }


        private void btnAcessarContaBancaria_Click(object sender, EventArgs e)
        {
            MySqlConnection Conexao = new MySqlConnection("datasource=localhost;username=root;password=;database=contabancaria");

            try
            {
                string cpf = txtSenhaAcessarContaBancaria.Text;
                string senha = txtSenhaAcessarContaBancaria.Text;

                string sql_code = $"SELECT id FROM titular where cpf = '{cpf}' AND cpf = '{senha}'";

                MySqlCommand comando = new MySqlCommand(sql_code, Conexao);

                Conexao.Open();

                // Execute a consulta e obtenha o resultado
                object result = comando.ExecuteScalar();

                // Verifique se o resultado é nulo
                if (result != null)
                {
                    // As credenciais são válidas, obtenha o ID e acesse a próxima tela
                    int userID = Convert.ToInt32(result);
                    AcessarTelaInicialContaBancaria(userID);
                }
                else
                {
                    // As credenciais são inválidas, exiba uma mensagem de erro
                    MessageBox.Show("Credenciais inválidas");
                }
            }
            catch
            {
                lblErroAutenticacaoAcessarContaBancaria.Visible = true;
            }
            finally
            {
                // Certifique-se de fechar a conexão com o banco de dados, independentemente do resultado
                Conexao.Close();
            }
        }
        private void btnLimparCamposAcessarContaBancaria_Click(object sender, EventArgs e)
        {
            LimparCamposAcessarContaBancaria();
        }
        private void btnVoltarTelaInicialAcessarContaBancaria_Click(object sender, EventArgs e)
        {
            VoltarTelaInicialAcessarContaBancaria();
        }
        // Métodos
        public void LimparCamposAcessarContaBancaria()
        {
            txtCpflAcessarContaBancaria.Text = "";
            txtSenhaAcessarContaBancaria.Text = "";
        }
        public void LimparCamposErrosAcessarContaBancaria()
        {
            lblCpfSenhaAcessarContaBancaria.Text = "";
            lblErroSenhaAcessarContaBancaria.Text = "";

        }
        public void VoltarTelaInicialAcessarContaBancaria()
        {
            frmTelaInicial frmtelaicial = new frmTelaInicial();
            frmtelaicial.Show();
            this.Hide();
        }
        public void AcessarTelaInicialContaBancaria(int userID)
        {
            frmTelaInicialContaTitular frmtelainicialcontatitular = new frmTelaInicialContaTitular(userID);
            frmtelainicialcontatitular.Show();
            this.Hide();
        }
    }
}
