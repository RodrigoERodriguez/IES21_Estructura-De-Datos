using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezED_Estructuras
{
    internal class clsBaseDeDatos
    {
        private OleDbConnection Conexion = new OleDbConnection();//Establece la conexion con la base de datos
        private OleDbCommand Comando = new OleDbCommand();//Ordena los comandos
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();//Adapta los datos de la base

        private string CadenaConexionViejo = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Libreria.mdb";
        private string CadenaConexionNuevo = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Libreria.mdb";

        public void Listar(DataGridView grilla)
        {
            try
            {
                Conexion.ConnectionString = CadenaConexionViejo;//No puedo abrir la conexion sin antes definirla
                Conexion.Open();

                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;//Traigo la tabla como esta en el acces
                Comando.CommandText = "Libro";//Le digo como se llama la tabla

                Adaptador = new OleDbDataAdapter(Comando);//Ejecuto el comando
                DataSet DS = new DataSet();
                Adaptador.Fill(DS, "Libro");//Lleno el data set con la tabla solicitada

                grilla.DataSource = null;//Limpio el registro
                grilla.DataSource = DS.Tables["Libro"];//Cargo la grilla con la tabla

                Conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Conexion.Close();
            }
        }

        public void Listar(DataGridView grilla, string InstruccionSQL)
        {
            try
            {
                Conexion.ConnectionString = CadenaConexionViejo;//No puedo abrir la conexion sin antes definirla
                Conexion.Open();

                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.Text;//Traigo la tabla como esta en el acces
                Comando.CommandText = InstruccionSQL;//Le digo como se llama la tabla

                Adaptador = new OleDbDataAdapter(Comando);//Ejecuto el comando
                DataSet DS = new DataSet();
                Adaptador.Fill(DS, "Resultado");//Lleno el data set con la tabla solicitada

                grilla.DataSource = null;//Limpio el registro
                grilla.DataSource = DS.Tables["Resultado"];//Cargo la grilla con la tabla

                Conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Conexion.Close();
            }
        }
    }
}
