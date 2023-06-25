using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MiPrimerAplicacionASP.Models;

namespace MiPrimerAplicacionASP.Controllers
{
    public class ClienteController : Controller
    {
        // GET
        public ActionResult Index()
        {
            List<ClienteCLS> listaCliente = null;
            using (var bd = new BDPasajeEntities())
            {
                listaCliente = (from cliente in bd.Cliente
                    where cliente.BHABILITADO == 1
                    select new ClienteCLS
                    {
                        iidcliente = cliente.IIDCLIENTE,
                        nombre = cliente.NOMBRE,
                        appaterno = cliente.APPATERNO,
                        apmaterno = cliente.APMATERNO,
                        telefono = cliente.TELEFONOFIJO

                    }).ToList();
            }
            return View(listaCliente);
        }
    }
}