using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sanita.Models;

namespace Sanita.Controllers
{
    public class ProductosController : Controller
    {
        //
        // GET: /Productos/
        ProductoContext dbProductos = new ProductoContext();
        public ActionResult Index()
        {
            List<Producto> productos = dbProductos.Productos();
            return View(productos.Take(30));
        }



        public PartialViewResult Search(String des)
        {
            List<Producto> productos = dbProductos.Productos().FindAll(x => x.Descripcion.ToUpper().Contains(des.ToUpper())).ToList();
            return PartialView("_Productos", productos);
        }



        public PartialViewResult Next(int ix)
        {
            List<Producto> productos = dbProductos.Productos();
            productos = productos.GetRange(ix, 30);
            return PartialView("_Productos", productos);
        }


        public PartialViewResult Back(int ix)
        {
            if (ix > 30)
            {
                List<Producto> productos = dbProductos.Productos();
                productos = productos.GetRange(ix - 31, 30);
                return PartialView("_Productos", productos);
            }
            return PartialView();
        }
    }
}
