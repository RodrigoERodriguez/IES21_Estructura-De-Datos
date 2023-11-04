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
    public partial class frmOperacionesEnBaseDeDatos : Form
    {
        clsBaseDeDatos ObjBaseDeDatos = new clsBaseDeDatos();

        public frmOperacionesEnBaseDeDatos()
        {
            InitializeComponent();
        }

        //==============================================================================================================
        //Operaciones de PROYECCION
        //==============================================================================================================

        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT TITULO FROM LIBRO";
            ObjBaseDeDatos.Listar(dgvBaseDeDatos, SQL);
        }

        private void btnProyeccionMultiAtributo_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT TITULO, IDIDIOMA FROM LIBRO";
            ObjBaseDeDatos.Listar(dgvBaseDeDatos, SQL);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT TITULO, NOMBRE FROM LIBRO inner join PAIS on LIBRO.IDPAIS= PAIS.IDPAIS";
            ObjBaseDeDatos.Listar(dgvBaseDeDatos, SQL);
        }

        //==============================================================================================================
        //Operaciones de SELECCION
        //==============================================================================================================

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT * FROM LIBRO WHERE IDidioma = 2";
            ObjBaseDeDatos.Listar(dgvBaseDeDatos, SQL);
        }

        private void btnSeleccionMultiAtributo_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT * FROM LIBRO WHERE IDLIBRO > 30 AND IDIDIOMA = 1";
            ObjBaseDeDatos.Listar(dgvBaseDeDatos, SQL);
        }

        private void btnSeleccionPorConvolucion_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT * FROM (select * from libro where idIdioma > 1) as X " + "Where IDPAIS = 2";
            ObjBaseDeDatos.Listar(dgvBaseDeDatos, SQL);
        }

        //==============================================================================================================
        //Operaciones ALGEBRAICAS
        //==============================================================================================================

        private void btnUnion_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT * FROM LIBRO WHERE idIdioma = 2 " + " Union " + " SELECT * FROM LIBRO WHERE idIdioma = 3";
            ObjBaseDeDatos.Listar(dgvBaseDeDatos, SQL);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT * FROM LIBRO WHERE idAutor = 2 " + " and idLibro in " + " (SELECT IDLIBRO WHERE IDPAIS = 3)" + "order by 1 asc";
            ObjBaseDeDatos.Listar(dgvBaseDeDatos, SQL);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT * FROM LIBRO WHERE idIdioma = 2 and idLibro not in " + "(SELECT idLibro FROM libro WHERE idPais = 3)" + "order by 1 asc";
            ObjBaseDeDatos.Listar(dgvBaseDeDatos, SQL);
        }
    }
}
