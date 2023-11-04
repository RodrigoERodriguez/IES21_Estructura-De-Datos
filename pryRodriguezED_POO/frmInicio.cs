using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezED_POO
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        //====================================

        Clientes objCliente1 = new Clientes();

        private void btnComprar_Click(object sender, EventArgs e)
        {
            //Declaro la variable del importe
            decimal Importe = 0;
            //Convierto lo de la caja de texto a un decimal
            Importe = Convert.ToDecimal(txtImporte.Text);
            objCliente1.Comprar(Importe);
            lblDeuda.Text = objCliente1.Deuda.ToString();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            decimal Importe = 0;
            Importe = Convert.ToDecimal(txtImporte.Text);
            objCliente1.Pagar(Importe);
            lblDeuda.Text = objCliente1.Deuda.ToString();
        }
    }
}
