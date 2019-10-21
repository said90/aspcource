using ASPCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPCourse.Controllers
{
    public class MarcaController : Controller
    {
        // GET: Marca
        public ActionResult Index()
        {
            List<MarcaCLS> lstMarca = null;
            using (var bd = new BDPasajeEntities())
            {
                lstMarca = bd.Marca.Select(x => new MarcaCLS
                {
                    iidmarca = x.IIDMARCA,
                    descripcion = x.DESCRIPCION,
                    nombre = x.NOMBRE
                }).ToList();

            }
            return View(lstMarca);
        }

        public ActionResult Agregar()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Agregar(MarcaCLS oMarcaCLS)
        {
            if (!ModelState.IsValid)
            {
                return View(oMarcaCLS);
            }
            else {
                using (var bd = new BDPasajeEntities())
                {
                    Marca oMarca = new Marca();
                    oMarca.NOMBRE = oMarcaCLS.nombre;
                    oMarca.DESCRIPCION = oMarcaCLS.descripcion;
                    oMarca.BHABILITADO = 1;
                    bd.Marca.Add(oMarca);
                    bd.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            return View();
        }
    }
}