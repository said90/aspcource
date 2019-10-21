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
    }
}