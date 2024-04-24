﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Innovatec
{
    public class DatosGetRegistrarProductos



    {
        // Registro de productos
        public int CodigoProducto { get; set; }
        public string Estado { get; set; }
        public string Producto { get; set; }
        public string Edicion { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }

        public DatosGetRegistrarProductos() { }
        // Campos de productos
        public DatosGetRegistrarProductos(int Pcodigo_producto, string Pestado_producto, string Pnombre_producto, string Pedicion, int Pcantidad, decimal Pprecio_compra, decimal Pprecio_venta, int Pstock)

        {
            this.CodigoProducto = Pcodigo_producto;
            this.Estado = Pestado_producto;
            this.Producto = Pnombre_producto;
            this.Edicion = Pedicion;
            this.Cantidad = Pcantidad;
            this.PrecioCompra = Pprecio_compra;
            this.PrecioVenta = Pprecio_venta;
            this.Stock = Pstock;


        }

    }



    }










