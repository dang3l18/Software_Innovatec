using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Software_Innovatec
{
    public class Metodos
    {
        public static int agregar(DatosGetRegistrarProductos pget)
        {
            int retorno = 0;

            CONEXION.opencon();
            SqlCommand comando = new SqlCommand(string.Format("INSERT INTO Productos (CodigoProducto, Estado, Producto, Edicion, Cantidad, PrecioCompra, PrecioVenta, Stock) VALUES ('{0}', '{1}', '{2}', '{3}')",
                pget.CodigoProducto, pget.Estado, pget.Producto, pget.Edicion,pget.Cantidad,pget.PrecioCompra,pget.PrecioVenta,pget.Stock), CONEXION.obtenerconexión());

            retorno = comando.ExecuteNonQuery();
            CONEXION.cerrarcon();
            return retorno;
        }



    }
}
