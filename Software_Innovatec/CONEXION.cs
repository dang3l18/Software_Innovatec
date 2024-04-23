using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Software_Innovatec
{
    public class CONEXION
    {
        public static SqlConnection Conn = new SqlConnection("Data Source=DESKTOP-D66FKKU\\DANGEL;Initial Catalog=Base_de_datos_CONEXION;Persist Security Info=True;User ID=sa;Password=dang3l18112007");

        public static SqlConnection obtenerconexión()
        {
            return Conn;
        }
        // Metodo de Abrir Conexcion
        public static void opencon()
        {
            try
            {
                Conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // Metodo de cerrar Conexcion
        public static void cerrarcon()
        {
            if (Conn != null)
            {
                try
                {
                    Conn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
