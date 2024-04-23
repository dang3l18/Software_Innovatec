using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Innovatec
{
    public class DatosGet
    {
        public int codigo_producto { get; set; }
        public string nombre_producto { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string categoria { get; set; }
        public decimal precio_compra { get; set; }
        public decimal precio_venta { get; set; }
        public string stock { get; set; }
        public string ubicacion { get; set; }
        public string estado { get; set; }



        public DatosGet() { }
        public DatosGet(int Pcodigo_producto, string Pnombre_producto, string Pmarca, string Pmodelo, string Pcategoria, decimal Pprecio_compra, decimal Pprecio_venta, string Pstock, string Pubicacion, string Pestado)
        {
            this.codigo_producto = Pcodigo_producto;
            this.nombre_producto = Pnombre_producto;
            this.marca = Pmarca;
            this.modelo = Pmodelo;
            this.categoria = Pcategoria;
            this.precio_compra = precio_compra;
            this.precio_venta = Pprecio_venta;
            this.stock = Pstock;
            this.ubicacion = Pubicacion;
            this.estado = Pestado;


        }
    }
}