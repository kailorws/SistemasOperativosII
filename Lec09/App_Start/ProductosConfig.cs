using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lec09.Models;

namespace Lec09
{
    public class ProductosConfig
    {
        public static List<Producto> listaProductos;

        public static void CrearProductos()
        {
            listaProductos = new List<Producto>
            {
                new Producto
                {
                    IdProducto = 123,
                    Nombre = "Prod 1",
                    Descripcion = "Desc 1",
                    Precio = 5000,
                    CantidadDisponibles = 10
                },
                new Producto
                {
                    IdProducto = 456,
                    Nombre = "Prod 2",
                    Descripcion = "Desc 2",
                    Precio = 10000,
                    CantidadDisponibles = 20
                }
            };

        }
    }
}