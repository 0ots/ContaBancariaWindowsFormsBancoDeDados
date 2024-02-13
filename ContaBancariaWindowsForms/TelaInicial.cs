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
            frmCriarConta telacriarconta = new frmCriarConta();
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
