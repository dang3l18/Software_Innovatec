using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Software_Innovatec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Usuario")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.LightGray;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Usuario";
                txtNombre.ForeColor = Color.Silver;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Silver;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnACCEDER_Click(object sender, EventArgs e)
        {
            {
                if (txtNombre.Text.Equals(""))
                {
                    MessageBox.Show("El usuario no debe estar en blanco!...");
                    txtNombre.Focus();
                    return;
                }

                if (txtContraseña.Text.Equals(""))
                {
                    MessageBox.Show("La contraseña no debe estar en blanco!...");
                    txtContraseña.Focus();
                    return;
                }

                DataTable dt = new DataTable();
                string consulta;
                consulta = "select * from Usuario where Nombre = @Nombre AND Contraseña = @Contraseña";
                CONEXION.opencon();
                SqlDataAdapter da = new SqlDataAdapter(consulta, CONEXION.obtenerconexión());
                CONEXION.cerrarcon();

                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 20).Value = txtNombre.Text;
                da.SelectCommand.Parameters.Add("@Contraseña", SqlDbType.VarChar, 50).Value = txtContraseña.Text;

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    PERMISOS.Registrar = Convert.ToBoolean(dt.Rows[0][3]);
                    PERMISOS.Consultar = Convert.ToBoolean(dt.Rows[0][4]);
                    PERMISOS.Su = Convert.ToBoolean(dt.Rows[0][5]);

                    Form principal = new Inventario();
                    principal.Show();
                    principal.Visible = true;
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuario Incorrecto");
                    txtContraseña.Focus();

                }
                CONEXION.cerrarcon();
            }
        }
    }
}