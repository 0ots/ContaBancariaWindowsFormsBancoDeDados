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
        public frmTelaInicialContaTitular()
        {
            InitializeComponent();
        }
        private void btnEncerrarSecaoTelaInicialContaBancaria_Click(object sender, EventArgs e)
        {
            frmTelaInicial frmtelainicial = new frmTelaInicial();
            frmtelainicial.Show();
            this.Hide();
        }
        private void btnRealizarDepositoTelaInicialContaBancaria_Click(object sender, EventArgs e)
        {
            frmTelaRealizarDeposito frmtelarealizardepostio = new frmTelaRealizarDeposito();
            frmtelarealizardepostio.Show();
            this.Hide();
        }
        private void btnRealizarSaqueTelaInicialContaBancaria_Click(object sender, EventArgs e)
        {
            frmTelaRealizarSaque frmtelarealizarsaque = new frmTelaRealizarSaque();
            frmtelarealizarsaque.Show();
            this.Hide();
        }
    }
}
