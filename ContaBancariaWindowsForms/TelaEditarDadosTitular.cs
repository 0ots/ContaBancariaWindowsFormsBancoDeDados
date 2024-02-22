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
    public partial class frmTelaEditarDadosTitular : Form
    {
        private int userID;
        public frmTelaEditarDadosTitular(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        Titular titular = new Titular();

        private void TelaEditarDadosTitular_Load(object sender, EventArgs e)
        {

            MySqlConnection Conexao = new MySqlConnection("datasource=localhost;username=root;password=;database=contabancaria");

            string obter_nome_titular = titular.ObterNome(userID);

            string obter_senha_titular = titular.ObterSenha(userID);

            string obter_email_titular = titular.ObterEmail(userID);

            string obter_telefone_titular = titular.ObterTelefone(userID);

            MySqlCommand comando_obter_nome = new MySqlCommand(obter_nome_titular, Conexao);
            MySqlCommand comando_obter_senha = new MySqlCommand(obter_senha_titular, Conexao);
            MySqlCommand comando_obter_email = new MySqlCommand(obter_email_titular, Conexao);
            MySqlCommand comando_obter_telefone = new MySqlCommand(obter_telefone_titular, Conexao);

            Conexao.Open();

            string nome = comando_obter_nome.ExecuteScalar()?.ToString();
            string senha = comando_obter_senha.ExecuteScalar()?.ToString();
            string email = comando_obter_email.ExecuteScalar()?.ToString();
            string telefone = comando_obter_telefone.ExecuteScalar()?.ToString();

            Conexao.Close();

            txtNomeEditarContaBancaria.Text = nome;
            txtSenhaEditarContaBancaria.Text = senha;
            txtEmailEditarContaBancaria.Text = email;
            txtTelefoneEditarContaBancaria.Text = telefone;

        }
        private void btnAtualizarDadosContaBancaria_Click(object sender, EventArgs e)
        {
            int erro = 0;
            bool isInteger = false;

            var nome = txtNomeEditarContaBancaria.Text;
            while (nome.Length < 3)
            {
                lblErroNomeEditarContaBancaria.Visible = true;
                lblErroNomeEditarContaBancaria.Text = "O nome deve conter pelo menos 3 caracteres";
                erro++;
                break;
            }
            while (!isInteger)
            {
                lblErroNomeEditarContaBancaria.Visible = true;
                nome = txtNomeEditarContaBancaria.Text;
                if (int.TryParse(nome, out _))
                {
                    lblErroNomeEditarContaBancaria.Visible = true;
                    lblErroNomeEditarContaBancaria.Text = "O nome deve conter apenas caracteres de A - Z";
                    isInteger = true;
                    erro++;
                }
                if (double.TryParse(nome, out _))
                {
                    lblErroNomeEditarContaBancaria.Visible = true;
                    lblErroNomeEditarContaBancaria.Text = "O nome deve conter apenas caracteres de A - Z";
                    isInteger = true;
                    erro++;
                }
                break;
            }

            var senha = txtSenhaEditarContaBancaria.Text;
            while (senha.Length < 6)
            {
                lblErroSenhaEditarContaBancaria.Visible = true;
                lblErroSenhaEditarContaBancaria.Text = "A senha deve conter entre 6 e 12 caracteres";
                erro++;
                break;
            }

            var email = txtEmailEditarContaBancaria.Text;

            var telefone = txtTelefoneEditarContaBancaria.Text;
            while (telefone.Length < 11)
            {
                lblErroTelefoneEditarContaBancaria.Visible = true;
                lblErroTelefoneEditarContaBancaria.Text = "O telefone deve conter 11 caracteres númericos";
                erro++;
                break;
            }

            if(erro == 0)
            {

                MySqlConnection Conexao = new MySqlConnection("datasource=localhost;username=root;password=;database=contabancaria");

                try
                {
                    string alterar_dados = titular.AlterarDados(nome, senha, email, telefone, userID);

                    MySqlCommand comando_alterar_dados = new MySqlCommand(alterar_dados, Conexao);

                    Conexao.Open();

                    string alterar_dados_titular = comando_alterar_dados.ExecuteScalar()?.ToString();

                    MessageBox.Show("Dados atualizados com sucesso!");

                    frmTelaInicialContaTitular frmtelainicialcontatitular = new frmTelaInicialContaTitular(userID);
                    frmtelainicialcontatitular.Show();
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("Houve um erro ao atualizar os dados");
                }
                finally
                {
                    Conexao.Close();
                }

            }
        }
        private void btnVoltarTelaInicialCriarContaBancaria_Click(object sender, EventArgs e)
        {
            VoltarTelaInicialContaBancaria();
        }
        public void VoltarTelaInicialContaBancaria()
        {
            frmTelaInicialContaTitular frmtelainicialcontatitular = new frmTelaInicialContaTitular(userID);
            frmtelainicialcontatitular.Show();
            this.Hide();
        }
    }
}
