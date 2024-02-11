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
        private void btnCriarContaContaBancaria_Click(object sender, EventArgs e)
        {
            AcessarTelaCriarConta();
        }
        private void btnAcessarContaContaBancaria_Click(object sender, EventArgs e)
        {
            AcessarTelaInicialContaTitular();
        }
        // Método para acessar a tela de criar conta
        public void AcessarTelaCriarConta()
        {
            frmCriarConta telacriarconta = new frmCriarConta();
            this.Hide();
            telacriarconta.Show();
        }
        // Método para acessar a tela inicial da conta do titular
        public void AcessarTelaInicialContaTitular()
        {
            frmTelaInicialContaTitular frmtelainicialcontatitular = new frmTelaInicialContaTitular();
            frmtelainicialcontatitular.Show();
        }
    }
}
