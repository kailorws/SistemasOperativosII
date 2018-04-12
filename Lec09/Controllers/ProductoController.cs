using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lec09.Models;

namespace Lec09.Controllers
{
    public class ProductoController : Controller
    {
        //
        // GET: /Producto/
        public ActionResult Index()
        {
            ViewBag.Cantidad = ProductosConfig.listaProductos
                .Count;
            return View(ProductosConfig.listaProductos);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Producto producto)
        {
            if (ModelState.IsValid)
            {
                ProductosConfig.listaProductos.Add(producto);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Details(int id)
        {
            var producto = ProductosConfig.listaProductos.FirstOrDefault
                (x => x.IdProducto == id);
            return View(producto);
        }

        public ActionResult Edit(int id)
        {
            var producto = ProductosConfig.listaProductos.FirstOrDefault
                (x => x.IdProducto == id);
            return View(producto);
        }

        [HttpPost]
        public ActionResult Edit(Producto producto)
        {
            var productoEliminar = ProductosConfig.listaProductos
                .FirstOrDefault(x => x.IdProducto == producto.IdProducto);
            if (ModelState.IsValid)
            {
                ProductosConfig.listaProductos.Remove(productoEliminar);
                ProductosConfig.listaProductos.Add(producto);
                return RedirectToAction("Index");
            }
            return View(producto);
        }

        public ActionResult Delete(int id)
        {
            var productoEliminar = ProductosConfig.listaProductos
                .FirstOrDefault(x => x.IdProducto == id);
            ProductosConfig.listaProductos.Remove(productoEliminar);
            return RedirectToAction("Index");
        }
	}
}