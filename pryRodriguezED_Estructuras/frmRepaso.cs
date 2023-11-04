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
    public partial class frmRepaso : Form
    {
        clsBaseDeDatos ObjBaseDeDatos = new clsBaseDeDatos();

        public frmRepaso()
        {
            InitializeComponent();
        }

        private void cbCriterios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCriterios.SelectedIndex > -1)
            {
                btnListar.Enabled = true;
            }
            else
            {
                btnListar.Enabled = false;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string SQL = "";

            switch (cbCriterios.SelectedIndex)
            {
                case 0:
                    txtLeyenda.Text = cbCriterios.Text + "";
                    SQL = "SELECT TITULO FROM LIBRO";
                    break;
                case 1:
                    txtLeyenda.Text = cbCriterios.Text + "";
                    SQL = "SELECT TITULO, IDIDIOMA FROM LIBRO";
                    break;
                case 2:
                    txtLeyenda.Text = cbCriterios.Text + "";
                    SQL = "SELECT TITULO, NOMBRE FROM LIBRO inner join PAIS on LIBRO.IDPAIS= PAIS.IDPAIS";
                    break; 
                case 3:
                    txtLeyenda.Text = cbCriterios.Text + "";
                    SQL = "SELECT * FROM LIBRO WHERE IDidioma = 2";
                    break; 
                case 4:
                    txtLeyenda.Text = cbCriterios.Text + "";
                    SQL = "";
                    break;
                case 5:
                    txtLeyenda.Text = cbCriterios.Text + "";
                    SQL = "";
                    break;
                case 6:
                    txtLeyenda.Text = cbCriterios.Text + "";
                    SQL = "SELECT * FROM (select * from libro where idIdioma > 1) as X " + "Where IDPAIS = 2";
                    break;
                case 7:
                    txtLeyenda.Text = cbCriterios.Text + "";
                    SQL = "SELECT * FROM LIBRO WHERE idIdioma = 2 " + " Union " + " SELECT * FROM LIBRO WHERE idIdioma = 3";
                    break;
                case 8:
                    txtLeyenda.Text = cbCriterios.Text + "";
                    SQL = "SELECT * FROM LIBRO WHERE idAutor = 2 " + " and idLibro in " + " (SELECT IDLIBRO WHERE IDPAIS = 3)" + "order by 1 asc";
                    break;
                case 9:
                    txtLeyenda.Text = cbCriterios.Text + "";
                    SQL = "SELECT * FROM LIBRO WHERE idIdioma = 2 and idLibro not in " + "(SELECT idLibro FROM libro WHERE idPais = 3)" + "order by 1 asc";
                    break;
            }

            ObjBaseDeDatos.Listar(dgvGrillaConsulta, SQL);
        }
    }
}
