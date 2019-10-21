using ASPCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPCourse.Controllers
{
    public class SucursalController : Controller
    {
        // GET: Sucursal
        public ActionResult Index()
        {
            List<SucursalCLS> lstSucursales = null;
            using (var bd = new BDPasajeEntities())
            {
                lstSucursales = bd.Sucursal.Where(x=>x.BHABILITADO==1).Select(x => new SucursalCLS
                {
                    iidsucursal=x.IIDSUCURSAL,
                    nombre= x.NOMBRE,
                    telefono= x.TELEFONO,
                    email= x.EMAIL
                }).ToList();
            }
            return View(lstSucursales);
        }

        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(SucursalCLS oSucursalCLS)
        {
            if (!ModelState.IsValid)
            {
                return View(oSucursalCLS);
            }

            using (var bd = new BDPasajeEntities())
            {
                Sucursal oSucursal = new Sucursal();
                oSucursal.NOMBRE = oSucursalCLS.nombre;
                oSucursal.DIRECCION = oSucursalCLS.direccion;
                oSucursal.TELEFONO = oSucursalCLS.telefono;
                oSucursal.EMAIL = oSucursalCLS.email;
                oSucursal.FECHAAPERTURA = oSucursalCLS.fechaApertura;
                oSucursal.BHABILITADO = 1;
                bd.Sucursal.Add(oSucursal);
                bd.SaveChanges();

            }
            return RedirectToAction("Index");
        }
    }
}