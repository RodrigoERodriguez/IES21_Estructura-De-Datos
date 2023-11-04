using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezED_Estructuras
{
    public partial class frmConsultaEnBaseDeDatos : Form
    {
        clsBaseDeDatos ObjBaseDeDatos = new clsBaseDeDatos();

        public frmConsultaEnBaseDeDatos()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string SQL= txtComandoSQL.Text;
            ObjBaseDeDatos.Listar(dgvGrillaConsulta, SQL);
        }
    }
}
