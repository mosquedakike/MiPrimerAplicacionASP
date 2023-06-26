using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MiPrimerAplicacionASP.Models;

namespace MiPrimerAplicacionASP.Controllers
{
    public class SucursalController : Controller
    {
        // GET
        public ActionResult Index()
        {
            List<SucursalCLS> listaSucursal = null;
            using (var bd = new BDPasajeEntities())
            {
                listaSucursal = (from sucursal in bd.Sucursal
                    where sucursal.BHABILITADO==1
                    select new SucursalCLS
                    {
                        iidsucursal = sucursal.IIDSUCURSAL,
                        nombre = sucursal.NOMBRE,
                        telefono = sucursal.TELEFONO,
                        email = sucursal.EMAIL
                    }).ToList();
            }
            return View(listaSucursal);
        }

        public ActionResult Agregar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Agregar(SucursalCLS oSucursalCls)
        {
            if (!ModelState.IsValid)
            {
                return View(oSucursalCls);
            }
            else
            {
                using (var bd = new BDPasajeEntities())
                {
                    Sucursal oSucursal = new Sucursal();
                    
                }
            }
        }
    }
}