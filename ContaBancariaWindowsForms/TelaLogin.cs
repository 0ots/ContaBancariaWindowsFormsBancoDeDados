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
                string cpf = txtCpfAcessarContaBancaria.Text;
                string senha = txtSenhaAcessarContaBancaria.Text;
                
                string sql_code = $"SELECT id FROM titular where cpf = '{cpf}' AND senha = '{senha}'";

                MySqlCommand comando = new MySqlCommand(sql_code, Conexao);

                Conexao.Open();

                object result = comando.ExecuteScalar();

                if (result != null)
                {
                    int userID = Convert.ToInt32(result);
                    AcessarTelaInicialContaBancaria(userID);
                }
                else
                {
                    lblErroAutenticacaoAcessarContaBancaria.Visible = true;
                }
            }
            catch
            {
                lblErroAutenticacaoAcessarContaBancaria.Visible = true;
            }
            finally
            {
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
        public void LimparCamposAcessarContaBancaria()
        {
            txtCpfAcessarContaBancaria.Text = "";
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
