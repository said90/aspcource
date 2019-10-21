using ASPCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPCourse.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            List<ClienteCLS> lstClientes = null;
                
            using (var bd = new BDPasajeEntities())
            {
                lstClientes = bd.Cliente.Select(x => new ClienteCLS
                {
                    iidcliente= x.IIDCLIENTE,
                    nombre= x.NOMBRE,
                    appaterno= x.APPATERNO,
                    apmaterno= x.APMATERNO,
                    telefonofijo=x.TELEFONOFIJO
                }).ToList();
            }
            return View(lstClientes);
        }
        List<SelectListItem> lst;
        private void llenarSexo() {
            using (var bd = new BDPasajeEntities())
            {
                lst = bd.Sexo.Where(x => x.BHABILITADO==1).Select(x=> new SelectListItem {
                    Text = x.NOMBRE,
                    Value= x.IIDSEXO.ToString()
                }).ToList();
                lst.Insert(0, new SelectListItem { Text = "-- Seleccione --", Value = "" });
            }
        }

        public ActionResult Agregar()
        {
            llenarSexo();
            ViewBag.lista = lst;
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(ClienteCLS oClienteCLS)
        {
            using (var bd = new BDPasajeEntities())
            {

            }

            return View();
        }
    }
}