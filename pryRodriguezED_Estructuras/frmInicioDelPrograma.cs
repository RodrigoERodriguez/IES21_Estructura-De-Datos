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
    public partial class frmInicioDelPrograma : Form
    {
        public frmInicioDelPrograma()
        {
            InitializeComponent();
            PersonalizarBotones();
        }
        //==============================================================================================================

        private void PersonalizarBotones()//Esconde los botones del submenu cuando 
                                          //inicializa el programa.
        {
            PSubMenuLineales.Visible = false;
            pSubMenuNoLineales.Visible = false;
            pSubMenuBaseDeDatos.Visible = false;
            pSubMenuSistemas.Visible = false;
        }

        //==============================================================================================================

        private void EsconderSubMenu()//Oculta los Submenus y botones
        {
            if (PSubMenuLineales.Visible == true)
            {
                PSubMenuLineales.Visible = false;
            }

            if (pSubMenuNoLineales.Visible == true)
            {
                pSubMenuNoLineales.Visible = false;
            }

            if (pSubMenuBaseDeDatos.Visible == true)
            {
                pSubMenuBaseDeDatos.Visible = false;
            }

            if (pSubMenuSistemas.Visible == true)
            {
                pSubMenuSistemas.Visible = false;
            }
        }

        //==============================================================================================================

        private void MostrarSubMenu(Panel SubMenu)//Alternara la visibilidad del submenu
        {
            if (SubMenu.Visible == false)
            {
                EsconderSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        //==============================================================================================================


        void abrirFormulario(Form form)//Llamo un formulario al panel central del programa
        {
            while (pCentral.Controls.Count > 0)//Va a borrar lo que este en el panel central
                                               //permitiendo asi que se abra otro formulario mas
            {
                pCentral.Controls.RemoveAt(index: 0);
            }
            Form formhijo = form;
            formhijo.TopLevel = false; //TopLevel es una propiedad nativa de los formularios
                                       //La cual deshabilitaremos
            formhijo.FormBorderStyle = FormBorderStyle.None; //Con esto saco el borde del formulario que llamo
            formhijo.Dock = DockStyle.Fill; //Ocupa todo el lugar del panel central

            pCentral.Controls.Add(formhijo);
            formhijo.Show();
        }

        //==============================================================================================================

        private void frmInicioDelPrograma_Load(object sender, EventArgs e)
        {

        }

        //==============================================================================================================

        private void btnLinealesMenu_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PSubMenuLineales);
        }

        private void btnPila_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmPila());
            EsconderSubMenu();
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmCola());
            EsconderSubMenu();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmLista());
            EsconderSubMenu();
        }

        //==============================================================================================================

        private void btnNoLinealesMenu_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pSubMenuNoLineales);
        }

        private void btnArbolBinario_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmArbolBinario());
            EsconderSubMenu();
        }

        //==============================================================================================================

        private void btnBaseDeDatosMenu_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pSubMenuBaseDeDatos);
        }

        private void btnBaseDeDatos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmOperacionesEnBaseDeDatos());
            EsconderSubMenu();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmConsultaEnBaseDeDatos());
            EsconderSubMenu();
        }

        private void btnRepaso_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmRepaso());
            EsconderSubMenu();
        }

        //==============================================================================================================

        private void btnSistemasMenu_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pSubMenuSistemas);
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmSistema());
            EsconderSubMenu();
        }
    }
}
