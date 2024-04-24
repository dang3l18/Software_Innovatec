using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Innovatec
{
    public partial class Registro_de_Productos : Form
    {
        public Registro_de_Productos()
        {
            InitializeComponent();
        }

   

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DatosGetRegistrarProductos Datosget = new DatosGetRegistrarProductos();

            Datosget.CodigoProducto = int.Parse(txtCodigoProducto.Text);
            Datosget.Estado = CBEstado.Text;
            Datosget.Producto = txtProducto.Text;
            Datosget.Edicion = txtEdicion.Text;
            Datosget.Cantidad = int.Parse(txtCantidad.Text);
            Datosget.PrecioCompra = decimal.Parse(txtPrecioCompra.Text);
            Datosget.PrecioVenta = decimal.Parse(txtPrecioVenta.Text);
            Datosget.Stock = int.Parse(txtStock.Text);




            int Resultado = Metodos.agregar(Datosget);

            if (Resultado > 0)
            {
                MessageBox.Show("Datos de Cliente Guardados Correctamente ", "Datos Guardados ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se Puedieron Guardar Datos de Cliente ", " Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            void Limpiar()
            {
                txtCodigoProducto.Clear();
                txtProducto.Clear();
                txtEdicion.Clear();
               txtCantidad.Clear();
                txtPrecioCompra.Clear();
                txtPrecioVenta.Clear();
                txtStock.Clear();
            }
        }
    }
}
